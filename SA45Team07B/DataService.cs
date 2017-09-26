using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
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

        public static void MakeRFIDAdjusment(string RFID, bool discontinued, string remarks)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            RFIDTag tag = context.RFIDs.Where(x => x.RFID == RFID).First();

            tag.Discontinued = discontinued ? "y" : "n";

            StockAdjustment adj = new StockAdjustment();
            adj.RFID = RFID;
            adj.DateAdjusted = DateTime.Now;
            adj.QtyAdjusted = discontinued ? (short)-1 : (short)1;
            adj.Remarks = remarks;

            context.StockAdjustments.Add(adj);

            context.SaveChanges();
        }

        public static bool CreateBorrowTransaction(string RFID, long memberID)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                Member member = context.Members.Where(x => x.MemberID == memberID).First();
                short loanPeriod = member.MemberCategories.LoanPeriod;

                IssueTran tran = new IssueTran();
                tran.RFID = RFID;
                tran.MemberID = memberID;
                tran.DateIssued = DateTime.Today;
                tran.DateDue = DateTime.Today.AddDays(loanPeriod);
                context.IssueTrans.Add(tran);

                member.LoanedQty += 1;

                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }

            }

        }
    }
}
