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
        private MemberCategories borrowerMemberType;
        private Faculty borrowerFaculty;


        public ReturnForm()
        {
            InitializeComponent();
        }

        private void btnSearchRFID_Click(object sender, EventArgs e)
        {
            using (BookPopUpSearch bps = new BookPopUpSearch("onloan"))
            {
                if (bps.ShowDialog() == DialogResult.OK)
                {
                    this.txtbRFID.Text = bps.RFIDFound.RFID.ToString();
                    ValidatetxtbRFID();
                }
                else
                {
                    return;
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

            txtbMemberType.Text = borrowerMemberType.CategoryName.ToString();
            txtbFaculty.Text = borrowerFaculty.FacultyName.ToString();

            dtpReturnDate.Value = DateTime.Today;
            dtpReturnDate.MinDate = dtpIssueDate.Value;

            txtbFine.Text = string.Format("{0:c}", CalculateFine());
        }


        private void ClearTextboxData()
        {
            txtbRFID.Text = string.Empty;
            txtbBookTitle.Text = string.Empty;
            txtbBookID.Text = string.Empty;

            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;

            txtbMemberID.Text = string.Empty;
            txtbMemberName.Text = string.Empty;
            txtbSchoolID.Text = string.Empty;

            txtbMemberType.Text = string.Empty;
            txtbFaculty.Text = string.Empty;

            dtpReturnDate.Value = DateTime.Today;

            txtbFine.Text = string.Empty;
        }


        private decimal CalculateFine()
        {
            decimal fine = 0.0M;
            decimal fineperday = borrower.MemberCategories.FinePerDay;

            if (dtpReturnDate.Value > dtpDueDate.Value)
            {
                fine = (decimal) (dtpReturnDate.Value - dtpDueDate.Value).TotalDays * fineperday;

                this.txtbFine.BackColor = SystemColors.Control;
                this.txtbFine.ForeColor = Color.Red;
            }
            else
            {
                this.txtbFine.BackColor = SystemColors.Control;
                this.txtbFine.ForeColor = SystemColors.WindowText;
            }

            return fine;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.dtpReturnDate.Value >= this.dtpIssueDate.Value)
            {
                using(TransactionScope ts = new TransactionScope())
                {
                    if (txtbRemarks.Text.Length > 255)
                    {
                        // should no happen as the textbox max length is 255
                        MessageBox.Show("Remarks exceed maximum length.");
                    }
                    else
                    {
                        using(SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
                        {

                            RFIDofReturnBook = (from x in context.RFIDs
                                                where x.RFID == RFIDofReturnBook.RFID
                                                select x).First();

                            lastTransaction = (from x in context.IssueTrans
                                               where (x.TransactionID == lastTransaction.TransactionID)
                                               select x).First();

                            borrower = (from x in context.Members
                                        where x.MemberID == lastTransaction.MemberID
                                        select x).First();

                            lastTransaction.DateActualReturned = this.dtpReturnDate.Value;
                            lastTransaction.Status = "in";
                            lastTransaction.Remarks = txtbRemarks.Text.ToString();

                            RFIDofReturnBook.Availability = "y";

                            borrower.LoanedQty -= 1;

                            int i = context.SaveChanges();
                            ts.Complete();

                            if(i > 0)
                            {
                                toolStripStatusLabel1.Text = "Return was successful.";
                                txtbRemarks.Text = string.Empty;
                                ClearTextboxData();
                                this.ActiveControl = txtbRFID;
                            }
                            else
                            {
                                MessageBox.Show("Return was not successful. Please try again.");
                            }
                        }

                    }
                }
            }
            else
            {
                // cannot happen
                MessageBox.Show("Invalid Return Date.");
            }
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            this.btnSubmit.Enabled = false;
            this.dtpReturnDate.MaxDate = DateTime.Today;
            this.ActiveControl = txtbRFID;
        }

        private void txtbRFID_Validating(object sender, CancelEventArgs e)
        {
            ValidatetxtbRFID();
        }

        private void ValidatetxtbRFID()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                string inputRFID = txtbRFID.Text.ToString();

                this.RFIDofReturnBook = (from x in context.RFIDs
                                         where x.RFID == inputRFID
                                         select x).FirstOrDefault();

                if (RFIDofReturnBook != null)
                {
                    this.returnBook = RFIDofReturnBook.Books;

                    lastTransaction = (from x in context.IssueTrans
                                       where x.TransactionID == RFIDofReturnBook.LastTransactionID
                                       select x).FirstOrDefault();

                    if (lastTransaction == null)
                    {
                        ClearTextboxData();
                        MessageBox.Show("No last transaction record.");
                    }
                    else if (lastTransaction.Status == "in")
                    {
                        ClearTextboxData();
                        MessageBox.Show("No active transaction record.");
                    }
                    else
                    {
                        borrower = lastTransaction.Members;
                        borrowerMemberType = borrower.MemberCategories;
                        borrowerFaculty = borrower.Faculties;

                        DisplayTextboxData();

                        errorProviderForRFID.SetError(txtbRFID, "");
                        toolStripStatusLabel1.Text = "1 record is found.";
                        btnSubmit.Enabled = true;
                    }
                }
                else
                {
                    errorProviderForRFID.SetError(txtbRFID, "Invalid RFID");
                    toolStripStatusLabel1.Text = "Invalid RFID";
                    ClearTextboxData();
                    btnSubmit.Enabled = false;
                }
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbRFID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidatetxtbRFID();
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if(lastTransaction != null)
            {
                txtbFine.Text = string.Format("{0:c}", CalculateFine());
            }
        }
    }
}
