using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class AdjustStock : SA45Team07B.BaseModalForm
    {
        Book mBook;
        bool discontinued;
        string mRFID;

        public string RFID
        {
            get { return mRFID; }
        }

        public AdjustStock()
        {
            InitializeComponent();
            mBook = null;
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            if (ValidateRFID())
            {
                txtbBookTitle.Text = mBook.BookTitle;
                discontinued = DataService.GetRFIDDiscontinueStatus(txtRFID.Text);
                AllowEdit(true);
            }
            else
            {
                AllowEdit(false);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (!ValidateRFID()) return;

            if (discontinued == rbYes.Checked)
            {
                MessageBox.Show("No changes");
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                mRFID = txtRFID.Text;
                string reason = cboxReason.SelectedIndex == 2 ? txtbRemarks.Text : cboxReason.Text;
                DataService.MakeRFIDAdjusment(mRFID, discontinued, reason);
                MessageBox.Show("Update Success!");
                DialogResult = DialogResult.OK;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtRFID_Validating(object sender, CancelEventArgs e)
        {
            ValidateRFID();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cboxReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxReason.SelectedIndex == 2)
            {
                txtbRemarks.Enabled = true;
            }
            else
            {
                txtbRemarks.Enabled = false;
            }
        }

        private void btnMoreRFID_Click(object sender, EventArgs e)
        {
            BookPopUpSearch popup = new BookPopUpSearch();
            popup.ShowDialog();
            if (popup.DialogResult == DialogResult.OK)
            {
                txtRFID.Text = popup.RFIDFound.RFID;
            }
        }

        private bool ValidateRFID()
        {
            if (txtRFID.Text.Length < 9)
            {
                epRFID.SetError(txtRFID, "Wrong RFID");
                return false;
            }

            mBook = DataService.GetBookFromRFID(txtRFID.Text);

            if (mBook == null)
            {
                epRFID.SetError(txtRFID, "No record");
                return false;
            }

            epRFID.SetError(txtRFID, "");
            return true;
        }

        private void AllowEdit(Boolean allowed)
        {
            if (allowed)
            {
                rbYes.Enabled = true;
                rbNo.Enabled = true;
                cboxReason.Enabled = true;
                rbYes.Checked = discontinued;
                rbNo.Checked = !discontinued;
                btnSubmit.Enabled = true;
            }
            else
            {
                txtbBookTitle.Text = "";
                rbYes.Enabled = false;
                rbNo.Enabled = false;
                cboxReason.Enabled = false;
                txtbRemarks.Enabled = false;
                btnSubmit.Enabled = false;
            }
        }
    }
}
