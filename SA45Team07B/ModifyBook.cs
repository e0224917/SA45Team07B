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
    public partial class ModifyBook : SA45Team07B.BaseForm
    {
        Book bookFound, bookModified;

        public ModifyBook()
        {
            InitializeComponent();
        }

        private void btnFindBk_Click(object sender, EventArgs e)
        {
            using (BookPopUpSearch popsearch = new BookPopUpSearch())
            {
                if (popsearch.ShowDialog() == DialogResult.OK)
                {
                    bookFound = popsearch.BookFound;
                    txtbBkId.Text = bookFound.BookID.ToString();
                    mtbISBN.Text = bookFound.ISBN.ToString();
                    txtbBkTitle.Text = bookFound.BookTitle.ToString();
                    txtbAuthor.Text = bookFound.Author.ToString();
                    using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
                    {
                        cbxPublisher.DataSource = context.Publishers.Select(x => x.PublisherName).ToList();
                        cbxPublisher.SelectedItem = context.Publishers.Where(x => x.PublisherID == bookFound.PublisherID).First().PublisherName.ToString();
                        cbxSubjectName.DataSource = context.BookSubjects.Select(x => x.SubjectName).ToList();
                        cbxSubjectName.SelectedItem = context.BookSubjects.Where(x => x.SubjectCode == bookFound.SubjectCode).First().SubjectName.ToString();
                    }
                    txtbCallNum.Text = bookFound.CallNumber.ToString();
                    txtbPrice.Text = bookFound.Price.ToString();
                    if (bookFound.Edition != null)
                    {
                        txtbEd.Text = bookFound.Edition.ToString();
                    }
                    if (bookFound.PublishedYear != null)
                    {
                        mtbYear.Text = bookFound.PublishedYear.ToString();
                    }
                    bookFound.RFIDs = popsearch.RFIDsOfBookFound;
                    foreach (RFIDTag rfid in bookFound.RFIDs)
                    {
                        lbxRFID.Items.Add(rfid.RFID.ToString());
                    }
                }
            }
            bookModified = new SA45Team07B.Book();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bookModified.BookID = bookFound.BookID;
            //modification on selectioned item
            bookModified.Author = txtbAuthor.Text; //Author not require validation
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                bookModified.PublisherID = context.Publishers.Where(x => x.PublisherName == cbxPublisher.Text).First().PublisherID.ToString();
                bookModified.SubjectCode = context.BookSubjects.Where(x => x.SubjectName == cbxSubjectName.Text).First().SubjectCode.ToString();
            }
            bookModified.AddRFID(lbxRFID, bookModified);

            bookModified.TotalCopy = (Int16)bookModified.RFIDs.Count();

            //Submission validation
            if (!this.ValidateChildren() || lbxRFID.Items.Count == 0)
            {
                MessageBox.Show("Not able to add this book. Please refer to individual error message");
            }
            else
            {
                using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
                {
                    context.Books.Remove(context.Books.Where(x=>x.BookID == bookFound.BookID).First());
                    context.Books.Add(bookModified);
                    context.SaveChanges();
                    MessageBox.Show("Book Modified");
                    Close();
                }
            }
        }

        private void mtbISBN_Validating(object sender, CancelEventArgs e)
        {
            bookModified.ISBN = mtbISBN.Text;
            if (bookModified.ISBN != bookFound.ISBN)
            {
                if (!bookModified.ISBNValidation(mtbISBN, epModifyBk))
                {
                    mtbISBN.Text = bookFound.ISBN;
                    bookModified.ISBN = bookFound.ISBN;
                }
            }
        }

        //private void cbxPublisher_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
        //    {
        //        bookModified.PublisherID = context.Publishers.Where(x => x.PublisherName == cbxPublisher.Text).First().PublisherID.ToString();
        //    }
        //}

        //private void cbxSubjectName_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
        //    {
        //        bookModified.SubjectCode = context.BookSubjects.Where(x => x.SubjectName == cbxSubjectName.Text).First().SubjectCode.ToString();
        //    }
        //}

        private void txtbCallNum_Validating(object sender, CancelEventArgs e)
        {
            bookModified.CallNumber = txtbCallNum.Text;
            if (bookFound.CallNumber != bookModified.CallNumber)
            {
                if (!bookModified.CallNumValidation(txtbCallNum, epModifyBk))
                {
                    bookModified.CallNumber = bookFound.CallNumber;
                    txtbCallNum.Text = bookFound.CallNumber;
                }
            }
        }

        private void txtbPrice_Validating(object sender, CancelEventArgs e)
        {
            //if there is modification
            if (bookFound.Price.ToString() != txtbPrice.Text )
            {
                //check if able to assign changed price to bookmodified.price
                decimal price;
                if (Decimal.TryParse(txtbPrice.Text, out price))
                {
                    bookModified.Price = price;
                }
                else
                {
                    bookModified.Price = bookFound.Price;
                    txtbPrice.Text = bookFound.Price.ToString();
                }
            }
            else //if there is no modification
            {
                bookModified.Price = bookFound.Price;
            }
        }

        private void mtbYear_Validating(object sender, CancelEventArgs e)
        {
            bookModified.PublishedYear = mtbYear.Text;
            if (bookFound.PublishedYear != bookModified.PublishedYear)
            {
                if (!bookModified.YearValidation(mtbYear, epModifyBk))
                {
                    bookModified.PublishedYear = bookFound.PublishedYear;
                    mtbYear.Text = bookFound.PublishedYear;
                }
            }
        }

        private void btnAddRFID_Click(object sender, EventArgs e)
        {
            //varify the txtbox
            using (SA45Team07B_LibraryEntities context = new SA45Team07B.SA45Team07B_LibraryEntities())
            {
                if (bookModified.RFIDValidation(txtbRFID, lbxRFID, epModifyBk))
                {
                    bookModified.RFIDs.Select(x => x.RFID).ToList().Add(txtbRFID.Text);
                    lbxRFID.Items.Add(txtbRFID.Text);
                    txtbRFID.Clear();
                }
            }
        }

        private void btnDeleteRFID_Click(object sender, EventArgs e)
        {
            if (lbxRFID.SelectedItem != null)
            {
                lbxRFID.Items.Remove(lbxRFID.SelectedItem);
            }
        }

        private void txtbBkTitle_Validating(object sender, CancelEventArgs e)
        {
            bookModified.BookTitle = txtbBkTitle.Text;
            if (bookFound.BookTitle != bookModified.BookTitle)
            {
                if(!bookModified.TitleValidation(txtbBkTitle, epModifyBk))
                {
                    txtbBkTitle.Text = bookFound.BookTitle;
                    bookModified.BookTitle = bookFound.BookTitle;
                }
            }
        }


    }
}
