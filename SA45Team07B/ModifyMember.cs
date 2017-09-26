using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
                    //mem = mps.Member;
                    //textBoxMemberName.Text = m.MemberName;
                    //maskedTextBoxSchoolID.Text = m.SchoolID;
                    //comboBoxMemberType.DataSource = ;

                }
            }
         
        }
    }
}
