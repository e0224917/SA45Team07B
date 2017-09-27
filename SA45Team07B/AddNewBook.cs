using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace SA45Team07B
{
    public partial class AddNewBook : SA45Team07B.BaseForm
    {
        Book newbook;
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                //display store generated BookID in txtbox
                txtbBkId.Text = (context.Books.OrderByDescending(x => x.BookID).First().BookID + 1).ToString();
                //load combobox
                LoadPublisherList();
                LoadSubjectNameList();
            }
        }

        public void LoadSubjectNameList()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                cbxSubjectName.DataSource = context.BookSubjects.Select(x => x.SubjectName).ToList();
                cbxSubjectName.SelectedIndex = -1;
            }
        }

        public void LoadPublisherList()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                cbxPublisher.DataSource = context.Publishers.Select(x => x.PublisherName).ToList();
                cbxPublisher.SelectedIndex = -1;
                newbook = new SA45Team07B.Book();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel add?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {

                //assign value for fields not require validation
                newbook.BookTitle = txtbBkTitle.Text;
                newbook.Author = txtbAuthor.Text;
                if (newbook.PublisherValidation(cbxPublisher, epAddBk) && newbook.SubjectNameValidation(cbxSubjectName, epAddBk))
                {
                    newbook.PublisherID = context.Publishers.Where(x => x.PublisherName == cbxPublisher.Text).First().PublisherID.ToString();
                    newbook.SubjectCode = context.BookSubjects.Where(x => x.SubjectName == cbxSubjectName.Text).First().SubjectCode.ToString();
                }

                if (newbook.ISBNValidation(mtbISBN, epAddBk) 
                    && newbook.CallNumValidation(txtbPrice, epAddBk) 
                    && newbook.PriceValidation(txtbPrice, epAddBk))
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
                    if (newbook.YearValidation(mtbYear, epAddBk))
                    {
                        newbook.PublishedYear = mtbYear.Text;
                    }
                }
                long bookid = (long)context.Books.OrderByDescending(x => x.BookID).First().BookID + 1;

                //add RFID for single or multiple copies of the book

                newbook.AddRFID(lbxRFID);
                newbook.TotalCopy = (Int16)newbook.RFIDs.Count();
                MessageBox.Show(newbook.TotalCopy.ToString());

                //Submission validation
                if (!this.ValidateChildren() || lbxRFID.Items.Count == 0)
                {
                    MessageBox.Show("Not able to add this book. Please refer to individual error message");
                }
                else
                {
                    context.Books.Add(newbook);
                    context.SaveChanges();
                    MessageBox.Show("Book Added");
                    Close();
                }
            }
        }

        //add RFID into listbox--------------------------------------------------------------------------
        private void btnAddRFID_Click(object sender, EventArgs e)
        {
            using(SA45Team07B_LibraryEntities context = new SA45Team07B.SA45Team07B_LibraryEntities())
            {
                if (newbook.RFIDValidation(txtbRFID, lbxRFID, epAddBk))
                {
                    lbxRFID.Items.Add(txtbRFID.Text);
                    txtbRFID.Clear();
                }
            }
        }

        private void btnDeleteRFID_Click(object sender, EventArgs e)
        {
            lbxRFID.Items.Remove(lbxRFID.SelectedItem);
        }

        //run friendly validation on each control-------------------------------------------------------------------

        private void mtbISBN_Validating(object sender, CancelEventArgs e)
        {
            newbook.ISBNValidation(mtbISBN, epAddBk);
        }
        private void txtbBkTitle_Validating(object sender, CancelEventArgs e)
        {
            newbook.TitleValidation(txtbBkTitle, epAddBk);
        }
        private void txtbPrice_Validating(object sender, CancelEventArgs e)
        {
            newbook.PriceValidation(txtbPrice, epAddBk);
        }
        private void txtbCallNum_Validating(object sender, CancelEventArgs e)
        {
            newbook.CallNumValidation(txtbCallNum, epAddBk);
        }
        private void mtbYear_Validating(object sender, CancelEventArgs e)
        {
            newbook.YearValidation(mtbYear, epAddBk);
        }
        private void cbxPublisher_Validating(object sender, CancelEventArgs e)
        {
            newbook.PublisherValidation(cbxPublisher, epAddBk);
        }
        private void cbxSubjectName_Validating(object sender, CancelEventArgs e)
        {
            newbook.SubjectNameValidation(cbxSubjectName, epAddBk);
        }

        
    }

    }


   


