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
    public partial class AddNewMember : SA45Team07B.BaseForm
    {
        public AddNewMember()
        {
            InitializeComponent();
        }

        private void AddNewMember_Load(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();
            int k = Convert.ToInt32(context.Members.OrderByDescending(x => x.MemberID).Select(x => x.MemberID).First().ToString()) + 1;
            textBoxMemberID.Text = Convert.ToString(k);
        }

        private void textBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        #region Validation of Add Member
        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate();
        }

        private void maskedTextBoxSchoolID_Validating(object sender, CancelEventArgs e)
        {
            SA45Team07B_LibraryEntities context1 = new SA45Team07B_LibraryEntities();
            var matchingRecord = context1.Members.Where(x => x.SchoolID == maskedTextBoxSchoolID.Text).FirstOrDefault();
            if (matchingRecord != null)
            {
                errorProviderSchoolID.SetError(maskedTextBoxSchoolID, "Member already exists.");
            }
            else if (!maskedTextBoxSchoolID.MaskFull)
            {
                errorProviderSchoolID.SetError(maskedTextBoxSchoolID, "Number of characters should be 9.");
            }
            else
            {
                errorProviderSchoolID.SetError(maskedTextBoxSchoolID, "");
            }
        }

        private void textBoxMemberName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxMemberName.Text.Trim() == "")
            {
                errorProviderMemberName.SetError(textBoxMemberName, "Please enter Member's Name. Field cannot be empty.");

            }
            else if (textBoxMemberName.Text.Length > 50)
            {
                errorProviderMemberName.SetError(textBoxMemberName, "Too many characters. Maximum number of characters = 50.");
            }
            else
            {
                errorProviderMemberName.SetError(textBoxMemberName, "");
            }
        }

        private void comboBoxMemberType_Validating(object sender, CancelEventArgs e)

        {
            if (comboBoxMemberType.SelectedItem == null)
            {
                errorProviderMemberType.SetError(comboBoxMemberType, "Please select a Member Type.");

            }
            else
            {
                errorProviderMemberType.SetError(comboBoxMemberType, "");
            }
        }

        private void comboBoxFacultyName_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxFacultyName.SelectedItem == null)
            {
                errorProviderFacultyName.SetError(comboBoxFacultyName, "Please select a Faculty Name.");

            }
            else
            {
                errorProviderFacultyName.SetError(comboBoxFacultyName, "");
            }
        }

        private void textBoxContactNumber_Validating(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxContactNumber.Text, "[^0-9]"))
            {
                errorProviderContactNumber.SetError(textBoxContactNumber, "Please enter only numbers.");

            }
            else if (textBoxContactNumber.Text.Length > 20)
            {
                errorProviderContactNumber.SetError(textBoxContactNumber, "Maximum number of characters = 20.");

            }
            else
            {
                errorProviderContactNumber.SetError(textBoxContactNumber, "");
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            SA45Team07B_LibraryEntities context2 = new SA45Team07B_LibraryEntities();
            var matchingRecord = context2.Members.Where(x => x.Email == textBoxEmail.Text.Trim()).FirstOrDefault();
            if (matchingRecord != null)
            {
                errorProviderEmail.SetError(textBoxEmail, "Email already exists.");
            }
            else if (textBoxEmail.Text.Trim() == "")
            {
                errorProviderEmail.SetError(textBoxEmail, "Please enter email. Field cannot be empty.");
            }

            else if (textBoxEmail.Text.Length > 50)
            {
                errorProviderEmail.SetError(textBoxEmail, "Too many characters. Maximum number of characters = 50.");
            }
            else
            {
                errorProviderEmail.SetError(textBoxEmail, "");
            }
        }

        private void textBoxes_Validated(object sender, EventArgs e)
        {
            if (
              (comboBoxMemberType.SelectedItem != null)
               && (comboBoxFacultyName.SelectedItem != null)
               && (errorProviderSchoolID.GetError(maskedTextBoxSchoolID).Length == 0)
               && (errorProviderMemberName.GetError(textBoxMemberName).Length == 0)
               && (errorProviderContactNumber.GetError(textBoxContactNumber).Length == 0)
               && (errorProviderEmail.GetError(textBoxEmail).Length == 0)
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

        //Add for Add Member
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context2 = new SA45Team07B_LibraryEntities();

            Member newMember = new Member();
            newMember.SchoolID = maskedTextBoxSchoolID.Text.ToUpper();
            newMember.MemberName = textBoxMemberName.Text.Trim();

            MemberCategories cat = new MemberCategories();
            cat = context2.MemberCategories.Where(x => x.CategoryName == comboBoxMemberType.SelectedItem.ToString()).FirstOrDefault();
            newMember.MemberCategories = cat;

            Faculty fac = new Faculty();
            fac = context2.Faculties.Where(x => x.FacultyName == comboBoxFacultyName.SelectedItem.ToString()).FirstOrDefault();
            newMember.Faculties = fac;

            newMember.ContactNumber = textBoxContactNumber.Text.Trim();
            newMember.Email = textBoxEmail.Text.ToLower().Trim();
            newMember.Discontinued = "N";
            newMember.LoanedQty = 0;

            DialogResult dr = MessageBox.Show("Confirm add new member?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                context2.Members.Add(newMember);
                context2.SaveChanges();
                MessageBox.Show(string.Format("Successfully added <<{0}>>.", newMember.MemberName));
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
        }

        //Cancel for Add Member and close
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
