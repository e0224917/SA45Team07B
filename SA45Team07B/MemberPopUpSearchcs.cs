using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Team07B
{
    /// <summary>
    /// using (MemberPopUpSearch mps = new MemberPopUpSearch())
    /// {
    ///     if (mps.ShowDialog() == DialogResult.OK
    ///     {
    ///         Member xxxx = mps.Member;
    ///     }
    /// }
    /// </summary>
    /// 
    public partial class MemberPopUpSearch : Form
    {
        private SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

        private Member member;

        public Member Member
        {
            get
            {
                return member;
            }
        }

        public MemberPopUpSearch()
        {
            InitializeComponent();
        }

        private void MemberPopUpSearch_Load(object sender, EventArgs e)
        {
            dataGridViewMemberList.DataSource = context.Members.ToList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // TODO - change 0 to MemberID after set the column name for datagirdview
            long memberID;

            if (Int64.TryParse(dataGridViewMemberList.CurrentRow.Cells[0].Value.ToString(), out memberID))
            {
                member = (from m in context.Members
                          where m.MemberID == memberID
                          select m).First();
            }

            //MessageBox.Show(Member.MemberName.ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
