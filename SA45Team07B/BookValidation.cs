using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;


namespace SA45Team07B
{
    public partial class Book
    {
        public bool ISBNValidation(Control mtb, ErrorProvider ep)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                //validate length of isbn
                if (mtb.Text.Length != 13)
                {
                    ep.SetError(mtb, "Please enter a valid ISBN consists of 13 digits");
                    return false;
                }
                //validate if an existing isbn
                else if (context.Books.Where(x => x.ISBN == mtb.Text).FirstOrDefault() != null)
                {
                    ep.SetError(mtb, "ISBN already exists");
                    return false;
                }
                else
                {
                    ep.SetError(mtb, "");
                    return true;
                }
            }
        }

        public void AddRFID(ListBox lbox)
        {
            foreach (var item in lbox.Items)
            {
                RFIDTag newrifd = new RFIDTag();
                newrifd.RFID = item.ToString();
                newrifd.BookID = this.BookID;
                this.RFIDs.Add(newrifd);
            }
        }

        public void AddRFID(List<string> rfidList)
        {
            foreach (var rfid in rfidList)
            {
                RFIDTag newrifd = new RFIDTag();
                newrifd.RFID = rfid;
                newrifd.BookID = this.BookID;
                this.RFIDs.Add(newrifd);
            }
        }

        public bool PriceValidation(Control txtb, ErrorProvider ep)
        {
            decimal price;
            if (!decimal.TryParse(txtb.Text, out price))
            {
                ep.SetError(txtb, "Please enter a valid number");
                return false;
            }
            else
            {
                ep.SetError(txtb, "");
                return true;
            }
        }

        public bool CallNumValidation(Control txtb, ErrorProvider ep)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                //check for existing call number
                if (context.Books.Where(x => x.CallNumber == txtb.Text).FirstOrDefault() != null)
                {
                    ep.SetError(txtb, "Book with the same Call Number already exists");
                    return false;
                }
                else if (txtb.Text.Length == 0)
                {
                    ep.SetError(txtb, "Please enter a call number");
                    return false;
                }
                else
                {
                    ep.SetError(txtb, "");
                    return true;
                }
            }
        }

        public bool YearValidation(Control mtb, ErrorProvider ep)
        {
            if (mtb.Text.Length == 4 || mtb.Text.Length == 0)
            {
                ep.SetError(mtb, "");
                return true;
            }
            else
            {
                ep.SetError(mtb, "Please enter year in the format of yyyy");
                return false;
            }

        }
        public bool PublisherValidation(ComboBox cbx, ErrorProvider ep)
        {
            if (cbx.SelectedItem == null)
            {
                ep.SetError(cbx, "Please select publisher");
                return false;
            }
            else
            {
                ep.SetError(cbx, "");
                return true;
            }
        }
        public bool SubjectNameValidation(ComboBox cbx, ErrorProvider ep)
        {
            if (cbx.SelectedItem == null)
            {
                ep.SetError(cbx, "Please select subject");
                return false;
            }
            else
            {
                ep.SetError(cbx, "");
                return true;
            }
        }
        public bool TitleValidation(Control txtb, ErrorProvider ep)
        {
            if (txtb.Text == string.Empty)
            {
                ep.SetError(txtb, "Please enter a title");
                return false;
            }
            ep.SetError(txtb, "");
            return true;
        }

        public bool RFIDValidation(Control txtb, ListBox lbox, ErrorProvider ep)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                if (txtb.Text.Length < 10)
                {
                    ep.SetError(txtb, "Invalid RFID");
                    return false;
                }
                else if (context.RFIDs.Where(x => x.RFID == txtb.Text).FirstOrDefault() != null)
                {
                    ep.SetError(txtb, "RFID already exists");
                    return false;
                }
                else
                {
                    foreach (var rfid in lbox.Items)
                    {
                        if (rfid.ToString() == txtb.Text)
                        {
                            ep.SetError(txtb, "Already added");
                            return false;
                        }
                    }
                    ep.SetError(txtb, "");

                    return true;
                }
            }

        }

    }
}
