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

        int loanedQy;
        int maxBorrowed;
        bool isBookAvailable;

        public BorrowForm()
        {
            InitializeComponent();
            borrower = null;
            borrowRFIDTag = null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (borrower.Discontinued == "y")
            {
                MessageBox.Show("Error", "This member is not allowed to borrow");
                return;
            }

            if (loanedQy == maxBorrowed)
            {
                MessageBox.Show("Error", "This member has reached the loan limit");
                return;
            }

            if (!isBookAvailable)
            {
                MessageBox.Show("Error", "This RFID is not available");
                return;
            }

            bool success = DataService.CreateBorrowTransaction(borrowRFIDTag.RFID, borrower.MemberID);
            if (success)
            {
                MessageBox.Show("Transaction successed!");
                txtbRFID.Clear();
                txtbBookTitle.Clear();
                txtbBookStatus.Clear();
                btnSubmit.Enabled = false;

                loanedQy += 1;
                txtbTotalBorrowed.Text = loanedQy.ToString();
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
            BookPopUpSearch bookPopup = new BookPopUpSearch();
            bookPopup.ShowDialog();
            if (bookPopup.DialogResult == DialogResult.OK)
            {
                txtbRFID.Text = bookPopup.RFIDFound.RFID;
            }
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

            return true;

        }

        private void txtbMemberID_TextChanged(object sender, EventArgs e)
        {
            if (ValidateMemberID())
            {
                loanedQy = borrower.LoanedQty;
                maxBorrowed = borrower.MemberCategories.LoanEntitlement;

                txtbName.Text = borrower.MemberName;
                txtbFaculty.Text = borrower.Faculties.FacultyName;
                txtbTotalBorrowed.Text = loanedQy.ToString();
                txtbMaxBorrowed.Text = maxBorrowed.ToString();
                txtbTotalBorrowed.ForeColor = loanedQy == maxBorrowed ? Color.Red : Color.Black;
                txtbStatus.Text = borrower.Discontinued == "N" ? "Activated" : "Deactivated";
                btnEdit.Enabled = true;
            }
            else
            {
                txtbName.Clear();
                txtbFaculty.Clear();
                txtbTotalBorrowed.Clear();
                txtbMaxBorrowed.Clear();
                txtbStatus.Clear();
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

    }
}
