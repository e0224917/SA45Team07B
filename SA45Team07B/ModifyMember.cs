using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SA45Team07B
{
    public partial class ModifyMember : SA45Team07B.BaseForm
    {
        private Member mem;
        public ModifyMember()
        {
            InitializeComponent();
        }

        private void ModifyMember_Load(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            using (MemberPopUpSearch mps = new MemberPopUpSearch())
            {
                if (mps.ShowDialog() == DialogResult.OK)
                {
                    mem = mps.MemberFound;
                    textBoxMemberName.Text = mem.MemberName;
                    maskedTextBoxSchoolID.Text = mem.SchoolID;
                    SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();
                    var query = from x in context.MemberCategories
                                select x.CategoryName;              
                    comboBoxMemberType.DataSource = query.ToList();
                    comboBoxMemberType.SelectedItem = mem.MemberCategories.CategoryName.ToString();


                    var query2 = from y in context.Faculties
                                 select y.FacultyName;
                    comboBoxFacultyName.DataSource = query2.ToList();
                    comboBoxFacultyName.SelectedItem = mem.Faculties.FacultyName.ToString();
                    textBoxContactNumber.Text = mem.ContactNumber;
                    textBoxEmail.Text = mem.Email;
                   
                    //var query2 = from x in context.
                }
            }
         
        }
    }
}
