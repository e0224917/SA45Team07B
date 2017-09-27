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
    public partial class ModifyMember : SA45Team07B.BaseForm
    {
        private Member mem;

        public Member ModifiedMember
        {
            get { return mem; }
            set { mem = value; }
        }

        public ModifyMember()
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

        //Retrieve member info from another popup search
        private void buttonFind_Click(object sender, EventArgs e)
        {
            using (MemberPopUpSearch mps = new MemberPopUpSearch())
            {
                if (mps.ShowDialog() == DialogResult.OK)
                {
                    mem = mps.MemberFound;
                    textBoxMemberName.Text = mem.MemberName;
                    maskedTextBoxSchoolID.Text = mem.SchoolID;
                    comboBoxMemberType.SelectedItem = mem.MemberCategories.CategoryName.ToString();
                    comboBoxFacultyName.SelectedItem = mem.Faculties.FacultyName.ToString();
                    textBoxContactNumber.Text = mem.ContactNumber;
                    textBoxEmail.Text = mem.Email;
                }
            }
        }

        #region Validation of Modify Member
        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validate();
        }
        private void maskedTextBoxSchoolID_Validating(object sender, CancelEventArgs e)
        {
            if ((maskedTextBoxSchoolID.Text == "") && maskedTextBoxSchoolID.Focus())
            {
                errorProviderSchoolID.SetError(maskedTextBoxSchoolID, "Please select School ID.");

            }
            else
            {
                errorProviderSchoolID.SetError(maskedTextBoxSchoolID, "");
            }
        }

        private void textBoxMemberName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxMemberName.Text == "" && textBoxMemberName.Focus())
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

            List<Member> memberList2 = (from x in context2.Members
                                        where (x.MemberID != mem.MemberID)
                                        select x).ToList();

            var matchingRecord = memberList2.Where(x => x.Email == textBoxEmail.Text.Trim()).FirstOrDefault();
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
              && (errorProviderMemberName.GetError(textBoxMemberName).Length == 0)
              && (errorProviderContactNumber.GetError(textBoxContactNumber).Length == 0)
              && (errorProviderEmail.GetError(textBoxEmail).Length == 0)
              )
            {
                buttonSaveChanges.Enabled = true;
            }
            else
            {
                buttonSaveChanges.Enabled = false;
            }
        }
        #endregion
        
        //Save changes
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            SA45Team07B_LibraryEntities context2 = new SA45Team07B_LibraryEntities();
            Member memb = context2.Members.Where(x => x.SchoolID == maskedTextBoxSchoolID.Text).First();
            memb.MemberName = textBoxMemberName.Text.Trim();
            memb.MemberCategories = context2.MemberCategories.Where(x => x.CategoryName == comboBoxMemberType.SelectedItem.ToString()).FirstOrDefault();
            memb.Faculties = context2.Faculties.Where(x => x.FacultyName == comboBoxFacultyName.SelectedItem.ToString()).FirstOrDefault();
            memb.ContactNumber = textBoxContactNumber.Text.Trim();
            memb.Email = textBoxEmail.Text.ToLower();

            DialogResult dr = MessageBox.Show("Confirm update member?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                context2.SaveChanges();
                MessageBox.Show(string.Format("Successfully updated Member <<{0}>>.", memb.MemberName));
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
    
        //Cancel modify Member and close
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Getting data for Member Categories and Faculties
        private void ModifyMember_Load(object sender, EventArgs e)
        {
            
            comboBoxMemberType.DataSource = DataService.GetMemberCategories();
            comboBoxFacultyName.DataSource = DataService.GetFacultiesList();

            if (mem != null)
            {
                maskedTextBoxSchoolID.Text = mem.SchoolID;
                textBoxMemberName.Text = mem.MemberName;
                comboBoxMemberType.SelectedItem = mem.MemberCategories.CategoryName.ToString();

                comboBoxFacultyName.SelectedItem = mem.Faculties.FacultyName.ToString();
                textBoxContactNumber.Text = mem.ContactNumber;
                textBoxEmail.Text = mem.Email;
            }
        }
    }
}
