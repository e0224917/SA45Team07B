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
    public partial class AdjustStock : SA45Team07B.BaseForm
    {
        Book mBook;
        bool discontinued;

        public AdjustStock()
        {
            InitializeComponent();
            mBook = null;
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            if (txtRFID.Text.Length == 10)
            {

                mBook = DataService.GetBookFromRFID(txtRFID.Text);

                if (ValidateRFID())
                {
                    txtbBookTitle.Text = mBook.BookTitle;
                    discontinued = DataService.GetRFIDStatus(txtRFID.Text);
                    rbYes.Checked = discontinued;
                    rbNo.Checked = !discontinued;
                }
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
                DataService.MakeRFIDAdjusment(txtRFID.Text, discontinued, txtbRemarks.Text);
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

        private bool ValidateRFID()
        {
            if (txtRFID.Text.Length < 10)
            {
                epRFID.SetError(txtRFID, "Wrong RFID");
                return false;
            }
            else if (mBook == null)
            {
                epRFID.SetError(txtRFID, "No record");
                return false;
            }
            epRFID.SetError(txtRFID, "");
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
