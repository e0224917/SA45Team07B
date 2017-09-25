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

        public static Book GetBookFromRFID(string RFID)
        {
            if (RFID.Length < 10)
            {
                return null;
            }
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

        public static bool GetRFIDStatus(string RFID)
        {
            if (RFID.Length < 10)
            {
                throw new FormatException();
            }
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
    }
}
