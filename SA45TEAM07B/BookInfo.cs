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
    public partial class BookInfo : SA45Team07B.BaseForm
    {
        Book bookFound;

        public BookInfo()
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
                        txtbPublisher.Text = context.Publishers.Where(x => x.PublisherID == bookFound.PublisherID).First().PublisherName.ToString();
                        txtbSubjectName.Text = context.BookSubjects.Where(x => x.SubjectCode == bookFound.SubjectCode).First().SubjectName.ToString();
                    }
                    txtbCallNum.Text = bookFound.CallNumber.ToString();
                    txtbPrice.Text = string.Format("{0:c}",bookFound.Price);
                    if (bookFound.Edition != null)
                    {
                        txtbEd.Text = bookFound.Edition.ToString();
                    }
                    if (bookFound.PublishedYear != null)
                    {
                        mtbYear.Text = bookFound.PublishedYear.ToString();
                    }
                    bookFound.RFIDs = popsearch.RFIDsOfBookFound;
                }
            }
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                //use bookid to find rfid list, use rfids to find each transaction in Issuetran, loop to check availability

                ////get rfid liststed 
                var rfids = from x in context.RFIDs
                            where x.BookID == bookFound.BookID
                            orderby x.Availability
                            select new
                            {
                                RFID = x.RFID.ToUpper(),
                                Availability = x.Availability.ToUpper(),
                                DateBorrowed = context.IssueTrans.Where(y => y.RFID == x.RFID).FirstOrDefault().DateIssued.ToString(),
                                DueDate = context.IssueTrans.Where(y => y.TransactionID == x.LastTransactionID).FirstOrDefault().DateDue.ToString(),
                                BorrowedBy = context.IssueTrans.Where(y => y.TransactionID == x.LastTransactionID).FirstOrDefault().MemberID.ToString()
                            };
                dgvAvail.DataSource = rfids.ToList();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
