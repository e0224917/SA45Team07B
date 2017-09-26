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
    public partial class ReturnForm : SA45Team07B.BaseForm
    {
        private RFIDTag RFIDofReturnBook;
        private Book returnBook;
        private IssueTran lastTransaction;
        private Member borrower;

        public ReturnForm()
        {
            InitializeComponent();
        }

        private void btnSearchRFID_Click(object sender, EventArgs e)
        {
            using (BookPopUpSearch bps = new BookPopUpSearch("onloan"))
            {
               if(bps.ShowDialog() == DialogResult.OK)
                {
                    this.RFIDofReturnBook = bps.RFIDFound;
                    this.returnBook = bps.BookFound;
                }
            }

            using(SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                lastTransaction = (from x in context.IssueTrans
                                   where x.TransactionID == RFIDofReturnBook.LastTransactionID
                                   select x).FirstOrDefault();


                if (lastTransaction == null)
                {
                    MessageBox.Show("No last transaction record.");
                }
                else
                {
                    borrower = lastTransaction.Members;
                    DisplayTextboxData();
                }
            }

        }


        private void DisplayTextboxData()
        {
            txtbRFID.Text = RFIDofReturnBook.RFID.ToString();
            txtbBookTitle.Text = returnBook.BookTitle.ToString();
            txtbBookID.Text = returnBook.BookID.ToString();

            dtpIssueDate.Value = lastTransaction.DateIssued;
            dtpDueDate.Value = lastTransaction.DateDue;

            txtbMemberID.Text = borrower.MemberID.ToString();
            txtbMemberName.Text = borrower.MemberName.ToString();
            txtbSchoolID.Text = borrower.SchoolID.ToString();
            txtbMemberType.Text = borrower.MemberCategories.CategoryName.ToString();
            txtbFaculty.Text = borrower.Faculties.FacultyName.ToString();

            dtpReturnDate.Value = DateTime.Today;
            dtpReturnDate.MinDate = dtpIssueDate.Value;

            txtbFine.Text = string.Format("{0:c}", CalculateFine());
        }

        private decimal CalculateFine()
        {
            // TODO - implement this
            decimal fine = 0.0M;
            decimal fineperday = borrower.MemberCategories.FinePerDay;

            if (dtpReturnDate.Value > dtpDueDate.Value)
            {
                fine = (decimal) (dtpReturnDate.Value - dtpDueDate.Value).TotalDays * fineperday;
            }

            return fine;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // TODO :  to check with return date is earlier than issuedate
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

        }
    }
}
