using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace SA45Team07B
{
    public partial class AddNewPublisher : SA45Team07B.BaseForm
    {
        public AddNewPublisher()
        {
            InitializeComponent();
        }

        private void textBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        #region Validation
        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate();
        }
        private void textBoxPublisherID_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPublisherID.Text == "" || Regex.IsMatch(textBoxPublisherID.Text, @"\s"))
            {
                errorProviderPublisherID.SetError(textBoxPublisherID, "Please enter Publisher ID. Field cannot be empty.");

            }
            else if (textBoxPublisherID.Text.Length > 25)
            {
                errorProviderPublisherID.SetError(textBoxPublisherID, "Too many characters. Maximum number of characters = 25.");
            }
            else
            {
                errorProviderPublisherID.SetError(textBoxPublisherID, "");
            }
        }

        private void textBoxPublisherName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPublisherName.Text == "" || Regex.IsMatch(textBoxPublisherID.Text, @"\s"))
            {
                errorProviderPublisherName.SetError(textBoxPublisherName, "Please enter Publisher's Name. Field cannot be empty.");

            }
            else if (textBoxPublisherName.Text.Length > 255)
            {
                errorProviderPublisherName.SetError(textBoxPublisherName, "Too many characters. Maximum number of characters = 255.");
            }
            else
            {
                errorProviderPublisherName.SetError(textBoxPublisherName, "");
            }
        }

        private void textBoxes_Validated(object sender, EventArgs e)
        {
            if (
              
                (errorProviderPublisherID.GetError(textBoxPublisherID).Length == 0)
               && (errorProviderPublisherName.GetError(textBoxPublisherName).Length == 0)
         
               )
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }
        #endregion

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context2 = new SA45Team07B_LibraryEntities();

            Publisher pb = new Publisher();
            pb.PublisherID = textBoxPublisherID.Text;
            pb.PublisherName = textBoxPublisherName.Text;
            pb.Country = comboBoxCountry.Text;
         

            DialogResult dr = MessageBox.Show("Confirm add new publisher?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                context2.Publishers.Add(pb);
                context2.SaveChanges();
                MessageBox.Show("Successfully added.");
                Close();
                MemberPopUpSearch mps = new MemberPopUpSearch();
                mps.Show();

            }
            else if (dr == DialogResult.No)
            {
                DialogResult = 0;
            }
            else if (dr == DialogResult.Cancel)
            {
                DialogResult = 0;
            }
            else
            {

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            MemberPopUpSearch mpus = new MemberPopUpSearch();
            mpus.Show();
        }
    }
}


