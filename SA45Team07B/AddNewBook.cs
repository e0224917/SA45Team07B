using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class AddNewBook : SA45Team07B.BaseForm
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            //display store generated BookID in txtbox
            txtbBkId.Text = (context.Books.OrderByDescending(x => x.BookID).First().BookID + 1).ToString();
            //load combobox
            LoadPublisherList();
            LoadSubjectNameList();
        }

        public void LoadSubjectNameList()
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();
            cbxSubjectName.DataSource = context.BookSubjects.Select(x => x.SubjectName).ToList();
            cbxSubjectName.SelectedIndex = -1;
        }

        public void LoadPublisherList()
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();
            cbxPublisher.DataSource = context.Publishers.Select(x => x.PublisherName).ToList();
            cbxPublisher.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            Book newbook = new Book()
            {
                //assign value for fields not require validation
                BookTitle = txtbBkTitle.Text,
                Author = txtbAuthor.Text,
                PublisherID = context.Publishers.Where(x => x.PublisherName == cbxPublisher.Text).First().PublisherID.ToString(),
                SubjectCode = context.BookSubjects.Where(x => x.SubjectName == cbxSubjectName.Text).First().SubjectCode.ToString(),
            };

            //assign value for fields require validation
            if (ValidateISBN(mtbISBN.Text) && ValidateCallNum(txtbCallNum.Text) && ValidatePrice(txtbPrice.Text))
            {
                newbook.ISBN = mtbISBN.Text;
                newbook.CallNumber = txtbCallNum.Text;
                newbook.Price = decimal.Parse(txtbPrice.Text);
            }

            //assign value for fields allow null value
            if (txtbEd.Text != string.Empty)
            {
                newbook.Edition = txtbEd.Text;
            }
            if (mtbYear.Text != string.Empty)
            {
                if (ValidateYear(mtbYear.Text))
                {
                    newbook.PublishedYear = mtbYear.Text;
                }
            }
            long bookid = (long)context.Books.OrderByDescending(x => x.BookID).First().BookID + 1;

            //add RFID for single or multiple copies of the book
            foreach (var item in lbxRFID.Items)
            {
                RFIDTag newrfid = new RFIDTag()
                {
                    RFID = item.ToString(),
                    BookID = bookid,
                    Discontinued = "n",
                    Availability = "y"
                };
                newbook.RFIDs.Add(newrfid);
            }
            newbook.TotalCopy = (Int16)newbook.RFIDs.Count();

            //Final validation
            if (!ValidateISBN(mtbISBN.Text)|| !ValidateCallNum(txtbCallNum.Text) || !ValidateRFID(txtbRFID.Text) 
                || !ValidatePublisher(cbxPublisher.Text) || !ValidateSubjectName(cbxSubjectName.Text))
            {
                MessageBox.Show("Not able to add this book. Please refer to individual error message");
            }
            else
            {
                context.Books.Add(newbook);
                context.SaveChanges();
                lblOnSubmit.ForeColor = Color.Red;
                lblOnSubmit.Text = "Book added!";
                Close();
            }
        }


        //add RFID into listbox--------------------------------------------------------------------------
        private void btnAddRFID_Click(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B.SA45Team07B_LibraryEntities();
            ValidateRFID(txtbRFID.Text);
        }

        private void btnDeleteRFID_Click(object sender, EventArgs e)
        {
            lbxRFID.Items.Remove(lbxRFID.SelectedItem);
        }

        //run friendly validation on each control-------------------------------------------------------------------

        private void mtbISBN_Validating(object sender, CancelEventArgs e)
        {
            ValidateISBN(mtbISBN.Text);
        }
        private void txtbPrice_Validating(object sender, CancelEventArgs e)
        {
            ValidatePrice(txtbPrice.Text);
        }
        private void txtbCallNum_Validating(object sender, CancelEventArgs e)
        {
            ValidateCallNum(txtbCallNum.Text);
        }
        private void mtbYear_Validating(object sender, CancelEventArgs e)
        {
            ValidateYear(mtbYear.Text);
        }
        private void cbxPublisher_Validating(object sender, CancelEventArgs e)
        {
            ValidatePublisher(cbxPublisher.Text);
        }
        private void cbxSubjectName_Validating(object sender, CancelEventArgs e)
        {
            ValidateSubjectName(cbxSubjectName.Text);
        }

        //validation methods for each field------------------------------------------------------------------

        public bool ValidateISBN(string s)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();
            
            //validate length of isbn
            if (s.Length != 13)
            {
                errorProviderAddBk.SetError(mtbISBN, "Please enter a valid ISBN consists of 13 digits");
                return false;
            }
            //validate if an existing isbn
            else if (context.Books.Where(x => x.ISBN == s).FirstOrDefault() != null)
            {
                errorProviderAddBk.SetError(mtbISBN, "ISBN already exists");
                return false;
            }
            else
            {
                errorProviderAddBk.SetError(mtbISBN, "");
                return true;
            }
        }
        public bool ValidatePrice(string s)
        {
            decimal price;
            if (!decimal.TryParse(s, out price))
            {
                errorProviderAddBk.SetError(txtbPrice, "Please enter a valid number");
                return false;
            }
            else
            {
                errorProviderAddBk.SetError(txtbPrice, "");
                return true;
            }
        }
        public bool ValidateCallNum(string s)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            //check for existing call number
            if (context.Books.Where(x => x.CallNumber == s).FirstOrDefault() != null)
            {
                errorProviderAddBk.SetError(txtbCallNum, "Book with the same Call Number already exists");
                return false;
            }
            else
            {
                errorProviderAddBk.SetError(txtbCallNum, "");
                return true;
            }
        }
        public bool ValidateYear(string s)
        {
            if (s.Length != 4)
            {
                errorProviderAddBk.SetError(mtbYear, "Please enter year in the format of yyyy");
                return false;
            }
            else
            {
                errorProviderAddBk.SetError(mtbYear, "");
                return true;
            }
        }
        private bool ValidatePublisher(string text)
        {
            if (cbxPublisher.SelectedItem == null)
            {
                errorProviderAddBk.SetError(cbxPublisher, "Please select publisher");
                return false;
            }
            else
            {
                errorProviderAddBk.SetError(cbxPublisher, "");
                return true;
            }
        }
        private bool ValidateSubjectName(string text)
        {
            if (cbxSubjectName.SelectedItem == null)
            {
                errorProviderAddBk.SetError(cbxSubjectName, "Please select subject");
                return false;
            }
            else
            {
                errorProviderAddBk.SetError(cbxSubjectName, "");
                return true;
            }
        }
        private bool ValidateRFID(string text)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            if (context.RFIDs.Where(x => x.RFID == txtbRFID.Text).FirstOrDefault() != null)
            {
                errorProviderAddBk.SetError(txtbRFID, "RFID already exists");
                return false;
            }

            //if not, check if RFID entered is already in listbox
            else
            {
                foreach (var rfid in lbxRFID.Items)
                {
                    if (rfid.ToString() == txtbRFID.Text)
                    {
                        errorProviderAddBk.SetError(txtbRFID, "Already added");
                        return false;
                    }
                }
                errorProviderAddBk.SetError(txtbRFID, "");
                lbxRFID.Items.Add(txtbRFID.Text);
                txtbRFID.Clear();
                return true;
            }
        }

    }
}

   


