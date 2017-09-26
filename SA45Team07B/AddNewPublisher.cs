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

        //On Loading
        private void AddNewPublisher_Load(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();
            var query = from x in context.Publishers select new { x.PublisherID, x.PublisherName, x.Country };
            dataGridViewPublishers.DataSource = query.ToList();
        }

        private void textBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        #region Validation of Add Publisher
        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate();
        }

        private void textBoxPublisherID_Validating(object sender, CancelEventArgs e)
        {
            SA45Team07B_LibraryEntities context1 = new SA45Team07B_LibraryEntities();
            var matchingRecord = context1.Publishers.Where(x => x.PublisherID == textBoxPublisherID.Text.Trim()).FirstOrDefault();
            if (matchingRecord != null)
            {
                errorProviderPublisherID.SetError(textBoxPublisherID, "Member already exists.");
            }
            else if (textBoxPublisherID.Text.Trim() == "")
            {
                errorProviderPublisherID.SetError(textBoxPublisherID, "Please enter Publisher ID. Field cannot be empty. Ignore if not adding new.");

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
            if (textBoxPublisherName.Text.Trim() == "")
            {
                errorProviderPublisherName.SetError(textBoxPublisherName, "Please enter Publisher Name. Field cannot be empty.");
 
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
            buttonAdd.Enabled = false;

            if (textBoxPublisherName.Text.Trim() == "")
            { 
                buttonAdd.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
            }
        }
        #endregion

        //Add for Add Publisher
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context2 = new SA45Team07B_LibraryEntities();
            Publisher pb = new Publisher();
            var matchingRecord = context2.Publishers.Where(x => x.PublisherID == textBoxPublisherID.Text.Trim()).FirstOrDefault();
            if (matchingRecord != null)
            {
                errorProviderPublisherID.SetError(textBoxPublisherID, "Member already exists.");
            }
            else
            {
                pb.PublisherID = textBoxPublisherID.Text.Trim();

                pb.PublisherName = textBoxPublisherName.Text.Trim();
                if (comboBoxCountry.SelectedItem != null && (comboBoxCountry.SelectedItem.ToString() != "Not Applicable"))
                {
                    pb.Country = comboBoxCountry.SelectedItem.ToString();
                }
                else
                {
                    pb.Country = "";
                }

                DialogResult dr = MessageBox.Show("Confirm add new publisher?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    context2.Publishers.Add(pb);
                    context2.SaveChanges();
                    MessageBox.Show(string.Format("Successfully added Publisher <<{0}>>.", pb.PublisherName)); 
                    SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();
                    var query = from x in context.Publishers select new { x.PublisherID, x.PublisherName, x.Country };
                    dataGridViewPublishers.DataSource = query.ToList();

                }
                else if (dr == DialogResult.No)
                {
                    DialogResult = 0;
                }
                else if (dr == DialogResult.Cancel)
                {
                    DialogResult = 0;
                }
            }
        }

        //Cancel for Add/Modify Publisher and Close
        void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
 
        //Click to send data to Modify Publisher fields
        private void dataGridViewPublishers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxModPublisherID.Text = dataGridViewPublishers.CurrentRow.Cells[0].Value.ToString();
            textBoxModPublisherName.Text = dataGridViewPublishers.CurrentRow.Cells[1].Value.ToString();
            comboBoxModCountry.SelectedItem = dataGridViewPublishers.CurrentRow.Cells[2].Value.ToString();
            buttonSaveChanges.Enabled = true;
            errorProviderModPublisherID.SetError(textBoxModPublisherID, "");
            toolStripStatusLabel1.Text = string.Format("Publisher <<{0}>> is selected.", textBoxModPublisherName.Text);
        }

        #region Validation of Modifying Publisher
        private void textBoxModPublisherID_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxModPublisherID.Text.Trim() == "")
            {
                errorProviderModPublisherID.SetError(textBoxModPublisherID, "Please select Publisher ID. Field cannot be empty.");
            }
          
            else
            {
                errorProviderModPublisherID.SetError(textBoxModPublisherID, "");
            }

        }
        private void textBoxModPublisherName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxModPublisherName.Text.Trim() == "")
            {
                errorProviderModPublisherName.SetError(textBoxModPublisherName, "Please enter Publisher's Name. Field cannot be empty.");
                buttonSaveChanges.Enabled = false;
            }
            else if (textBoxModPublisherName.Text.Length > 255)
            {
                errorProviderModPublisherName.SetError(textBoxModPublisherName, "Too many characters. Maximum number of characters = 255.");
            }
            else
            {
                errorProviderModPublisherName.SetError(textBoxModPublisherName, "");
            }
        }

        private void textBoxes2_Validated(object sender, EventArgs e)
        {
            if (errorProviderModPublisherName.GetError(textBoxModPublisherName).Length == 0)

            {
                buttonSaveChanges.Enabled = true;
            }
        }
        #endregion
        
        //Save Changes for Modify Publisher
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context2 = new SA45Team07B_LibraryEntities();
            Publisher pb = new Publisher();
            pb = context2.Publishers.Where(x => x.PublisherID == textBoxModPublisherID.Text).First();
            pb.PublisherName = textBoxModPublisherName.Text.Trim();
            if(comboBoxModCountry.SelectedItem !=null && (comboBoxModCountry.SelectedItem.ToString() != "Not Applicable"))
            {
                pb.Country = comboBoxModCountry.SelectedItem.ToString();
            }
            else
            {
                pb.Country = "";
            }

            DialogResult dr = MessageBox.Show("Confirm update?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                context2.SaveChanges();
                MessageBox.Show(string.Format("Successfully updated <<{0}>>.", pb.PublisherName));
                toolStripStatusLabel1.Text = "Publisher list updated.";
                SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();
                var query = from x in context.Publishers select new { x.PublisherID, x.PublisherName, x.Country };
                dataGridViewPublishers.DataSource = query.ToList();

            }
            else if (dr == DialogResult.No)
            {
                DialogResult = 0;
            }
            else if (dr == DialogResult.Cancel)
            {
                DialogResult = 0;
            }
        }
    }
}
