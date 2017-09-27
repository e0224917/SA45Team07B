using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Threading.Tasks;

namespace SA45Team07B
{
    class DataService
    {
        private DataService() { }

        public static Book GetBook(string RFID)
        {

            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            try
            {
                RFIDTag tag = context.RFIDs.Where(x => x.RFID == RFID).First();
                return tag.Books;
            }
            catch (InvalidOperationException e)
            {
                return null;
            }

        }

        public static RFIDTag GetRFIDTag(string RFID)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            try
            {
                RFIDTag tag = context.RFIDs.Where(x => x.RFID == RFID).First();
                return tag;
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }

        public static Member GetMember(long memberID)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            try
            {
                Member member = context.Members.Where(x => x.MemberID == memberID).First();
                return member;
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }

        public static bool GetRFIDDiscontinueStatus(string RFID)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            RFIDTag tag = context.RFIDs.Where(x => x.RFID == RFID).First();

            return tag.Discontinued == "y" ? true : false;
        }

        public static List<string> GetMemberCategories()
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            var query = from x in context.MemberCategories
                        select x.CategoryName;

            return query.ToList();
        }

        public static List<string> GetFacultiesList()
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            var query = from y in context.Faculties
                         select y.FacultyName;

            return query.ToList();
        }

        public static void MakeRFIDAdjusment(string RFID, bool discontinued, string remarks)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            RFIDTag tag = context.RFIDs.Where(x => x.RFID == RFID).First();

            tag.Discontinued = discontinued ? "y" : "n";

            StockAdjustment adj = new StockAdjustment
            {
                RFID = RFID,
                DateAdjusted = DateTime.Now,
                QtyAdjusted = discontinued ? (short)-1 : (short)1,
                Remarks = remarks
            };

            context.StockAdjustments.Add(adj);

            context.SaveChanges();
        }

        public static bool CreateBorrowTransaction(Dictionary<string, string> queries)
        {
            string RFID = queries["RFID"];
            long memberID = long.Parse(queries["MemberID"]);
            DateTime issueDate = DateTime.Parse(queries["DateIssued"]);
            DateTime dueDate = DateTime.Parse(queries["DateDue"]);

            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            RFIDTag rFIDTag = context.RFIDs.Where(x => x.RFID == RFID).First();

            /*This transaction combines three sequences: 
             * - create new issue tran in IssueTrans
             * - increment of member's loan qty in Members
             * - change the availability of RFID in RFIDs
             * */
            using (TransactionScope ts = new TransactionScope())
            {
                IssueTran tran = new IssueTran
                {
                    RFID = RFID,
                    MemberID = memberID,
                    DateIssued = issueDate,
                    DateDue = dueDate
                };

                context.IssueTrans.Add(tran);

                Member member = context.Members.Where(x => x.MemberID == memberID).First();
                member.LoanedQty += 1;

                rFIDTag.Availability = "n";

                try
                {
                    context.SaveChanges();
                    ts.Complete();
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            //After the transaction succeeded, update the trans id in RDIDs
            var query = (from x in context.IssueTrans orderby x.TransactionID descending select x).Take(1);
            rFIDTag.LastTransactionID = query.First().TransactionID;
            context.SaveChanges();
            return true;
        }
    }
}
