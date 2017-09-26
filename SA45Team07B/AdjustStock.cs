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
        static string[] REMOVE_REASON_LIST = new string[] { "Lost", "Damaged", "Other" };
        static string[] RESTORE_REASON_LIST = new string[] { "Found", "Replace", "Other" };

        Book adjustBook;
        bool discontinued;
        string adjustRFID;

        public string RFID
        {
            get { return adjustRFID; }
        }

        public AdjustStock()
        {
            InitializeComponent();
        }

        private void AdjustStock_Load(object sender, EventArgs e)
        {
            adjustBook = null;
            cboxReason.DataSource = REMOVE_REASON_LIST;
        }

        private void btnMoreRFID_Click(object sender, EventArgs e)
        {
            BookPopUpSearch popup = new BookPopUpSearch();
            popup.ShowDialog();
            if (popup.DialogResult == DialogResult.OK)
            {
                txtbRFID.Text = popup.RFIDFound.RFID;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (!ValidateRFID()) return;

            if (discontinued == rbRemove.Checked)
            {
                MessageBox.Show("No changes");
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                adjustRFID = txtbRFID.Text;
                string reason = cboxReason.SelectedIndex == 2 ? txtbRemarks.Text : cboxReason.Text;
                DataService.MakeRFIDAdjusment(adjustRFID, discontinued, reason);
                MessageBox.Show("Update Success!");
                DialogResult = DialogResult.OK;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void rbRemove_CheckedChanged(object sender, EventArgs e)
        {
            ValidateRFID();
            cboxReason.DataSource = rbRemove.Checked ? REMOVE_REASON_LIST : RESTORE_REASON_LIST;
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            if (ValidateRFID())
            {
                txtbBookTitle.Text = adjustBook.BookTitle;
            }
        }

        private void txtRFID_Validating(object sender, CancelEventArgs e)
        {
            ValidateRFID();
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

        private bool ValidateRFID()
        {
            AllowEdit(false);

            if (txtbRFID.Text == "")
            {
                epRFID.SetError(txtbRFID, "Empty field");
                return false;
            }

            if (txtbRFID.Text.Length < 9)
            {
                epRFID.SetError(txtbRFID, "Wrong RFID format");
                return false;
            }

            adjustBook = DataService.GetBook(txtbRFID.Text);
            if (adjustBook == null)
            {
                epRFID.SetError(txtbRFID, "No record found");
                return false;
            }

            discontinued = DataService.GetRFIDDiscontinueStatus(txtbRFID.Text);
            // if book status and action type not match
            if (discontinued == rbRemove.Checked)
            {
                epRFID.SetError(txtbRFID, string.Format("Already {0}", rbRemove.Checked ? "removed" : "restored"));
                return false;
            }

            epRFID.SetError(txtbRFID, "");
            AllowEdit(true);
            return true;
        }

        private void AllowEdit(Boolean allowed)
        {
            if (allowed)
            {
                cboxReason.Enabled = true;
                btnSubmit.Enabled = true;
            }
            else
            {
                txtbBookTitle.Clear();
                cboxReason.Enabled = false;
                txtbRemarks.Enabled = false;
                btnSubmit.Enabled = false;
            }
        }


    }
}
