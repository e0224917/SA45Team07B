using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class BorrowForm : SA45Team07B.BaseForm
    {
        Member borrower;
        RFIDTag borrowRFIDTag;

        int loanedQty;
        int maxBorrowed;
        bool isBookAvailable;

        public BorrowForm()
        {
            InitializeComponent();

        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            dpDateIssued.Value = DateTime.Today;
            dpDateDue.Value = DateTime.Today;
            borrower = null;
            borrowRFIDTag = null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (borrower.Discontinued == "y")
            {
                MessageBox.Show("This member is not allowed to borrow.", "Error");
                return;
            }

            if (loanedQty == maxBorrowed)
            {
                MessageBox.Show("This member has reached the loan limit.", "Error");
                return;
            }

            if (!isBookAvailable)
            {
                MessageBox.Show("This RFID is not available.", "Error");
                return;
            }

            if (dpDateDue.Value.CompareTo(dpDateIssued.Value) < 1)
            {
                MessageBox.Show("Due date must be later than borrow date.", "Error");
                return;
            }

            Dictionary<string, string> queries = new Dictionary<string, string>();
            queries.Add("RFID", borrowRFIDTag.RFID);
            queries.Add("MemberID", borrower.MemberID.ToString());
            queries.Add("DateIssued", dpDateIssued.Value.ToString());
            queries.Add("DateDue", dpDateDue.Value.ToString());

            bool success = DataService.CreateBorrowTransaction(queries);

            if (success)
            {
                MessageBox.Show("Transaction successful!");
                txtbRFID.Clear();
                txtbBookTitle.Clear();
                txtbBookStatus.Clear();
                btnSubmit.Enabled = false;
                

                loanedQty += 1;
                txtbTotalBorrowed.Text = loanedQty.ToString();
            }
            else
            {
                MessageBox.Show("Error", "Transaction failed. Please try again.");
            }

        }

        private void btnMoreMember_Click(object sender, EventArgs e)
        {
            MemberPopUpSearch popup = new MemberPopUpSearch();
            popup.ShowDialog();
            if (popup.DialogResult == DialogResult.OK)
            {
                txtbMemberID.Text = popup.MemberFound.MemberID.ToString();
            }
        }

        private void btnMoreBook_Click(object sender, EventArgs e)
        {
            BookPopUpSearch bookPopup = new BookPopUpSearch("available");
            bookPopup.ShowDialog();
            if (bookPopup.DialogResult == DialogResult.OK)
            {
                txtbRFID.Text = bookPopup.RFIDFound.RFID;
            }
        }



        private void txtbMemberID_TextChanged(object sender, EventArgs e)
        {
            if (ValidateMemberID())
            {
                loanedQty = borrower.LoanedQty;
                maxBorrowed = borrower.MemberCategories.LoanEntitlement;

                txtbName.Text = borrower.MemberName;
                txtbFaculty.Text = borrower.Faculties.FacultyName;

                txtbTotalBorrowed.Text = loanedQty.ToString();
                txtbMaxBorrowed.Text = maxBorrowed.ToString();
                txtbTotalBorrowed.BackColor = loanedQty == maxBorrowed ? Color.Red : Color.White;
                txtbStatus.Text = borrower.Discontinued == "N" ? "Activated" : "Deactivated";
                txtbEntitlement.Value = borrower.MemberCategories.LoanPeriod;

                dpDateDue.Value = dpDateIssued.Value.AddDays(borrower.MemberCategories.LoanPeriod);
                txtbPeriod.Value = borrower.MemberCategories.LoanPeriod;

                btnEdit.Enabled = true;
            }
            else
            {
                txtbName.Clear();
                txtbFaculty.Clear();

                txtbTotalBorrowed.Clear();
                txtbMaxBorrowed.Clear();
                txtbTotalBorrowed.BackColor = SystemColors.Control; 
                txtbStatus.Clear();
                txtbEntitlement.ResetText();

                dpDateIssued.ResetText();
                dpDateDue.ResetText();
                txtbPeriod.ResetText();

                btnEdit.Enabled = false;
            }
        }

        private void txtbMemberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbRFID_TextChanged(object sender, EventArgs e)
        {
            if (ValidateRFID())
            {
                isBookAvailable = borrowRFIDTag.Availability == "y" && borrowRFIDTag.Discontinued == "n";

                txtbBookTitle.Text = borrowRFIDTag.Books.BookTitle;
                txtbBookStatus.Text = isBookAvailable ? "Yes" : "No";
                btnSubmit.Enabled = isBookAvailable ? true : false;
            }
            else
            {
                txtbBookTitle.Clear();
                txtbBookStatus.Clear();
                btnSubmit.Enabled = false;
            }
        }

        private void DateValueChanged(object sender, EventArgs e)
        {
            if (ValidateDate())
            {
                txtbPeriod.Value = (dpDateDue.Value - dpDateIssued.Value).Days;
            }
        }

        private void txtbPeriod_ValueChanged(object sender, EventArgs e)
        {
            dpDateDue.Value = dpDateIssued.Value.AddDays((double)txtbPeriod.Value);
        }

        private bool ValidateMemberID()
        {
            if (txtbMemberID.Text == "")
            {
                errorProvider.SetError(txtbMemberID, "Empty field");
                return false;
            }

            borrower = DataService.GetMember(long.Parse(txtbMemberID.Text));

            if (borrower == null)
            {
                errorProvider.SetError(txtbMemberID, "No record found");
                return false;
            }

            errorProvider.SetError(txtbMemberID, "");
            return true;
        }

        private bool ValidateRFID()
        {
            if (txtbRFID.Text == "")
            {
                errorProvider.SetError(txtbRFID, "Empty field");
                return false;
            }

            if (txtbRFID.Text.Length < 9)
            {
                errorProvider.SetError(txtbRFID, "Wrong RFID format");
                return false;
            }

            borrowRFIDTag = DataService.GetRFIDTag(txtbRFID.Text);

            if (borrowRFIDTag == null)
            {
                errorProvider.SetError(txtbRFID, "No record found");
                return false;
            }

            errorProvider.SetError(txtbRFID, "");
            return true;

        }

        private bool ValidateDate()
        {
            if (dpDateDue.Value.CompareTo(dpDateIssued.Value) < 1)
            {
                errorProvider.SetError(dpDateDue, "Must be later than borrow date");
                return false;
            }

            errorProvider.SetError(dpDateDue, "");
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ModifyMember form = new ModifyMember();
            form.ModifiedMember = borrower;
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                borrower = form.ModifiedMember;
                txtbName.Text = borrower.MemberName;
                txtbFaculty.Text = borrower.Faculties.FacultyName;
            }
        }
    }
}
