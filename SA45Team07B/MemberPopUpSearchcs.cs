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

        private Member memberFound;

        public Member MemberFound
        {
            get
            {
                return memberFound;
            }
        }

        public MemberPopUpSearch()
        {
            InitializeComponent();
        }

        private void SearchAndDisplayMember()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                List<Member> searchResult = new List<Member>();
                searchResult = context.Members.ToList();

                searchResult = CriteriaSeach(searchResult, txtbMemberName, "MemberName");
                searchResult = CriteriaSeach(searchResult, txtbSchoolID, "SchoolID");
                searchResult = CriteriaSeach(searchResult, txtbEmail, "Email");

                var query = from m in searchResult
                            select new { m.MemberID, m.MemberName, m.MemberType, m.FacultyCode, m.SchoolID, m.ContactNumber, m.Email, m.LoanedQty };

                dataGridViewMemberList.DataSource = query.ToList();
            }
        }

        private List<Member> CriteriaSeach(List<Member> list, TextBox tb, string propertyName)
        {
            if (tb.Text != string.Empty)
            {
                list = (from x in list
                        where (x.GetType().GetProperty(propertyName).GetValue(x).ToString().ToLower().Contains(tb.Text.ToString().ToLower().Trim()))
                        select x).ToList();
            }
            return list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAndDisplayMember();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbMemberName.Text = string.Empty;
            txtbSchoolID.Text = string.Empty;
            txtbEmail.Text = string.Empty;
            SearchAndDisplayMember();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            long memberID;

                using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
                {
                    if (Int64.TryParse(dataGridViewMemberList.CurrentRow.Cells["MemberIDColumn"].Value.ToString(), out memberID))
                    {
                        memberFound = (from m in context.Members
                                  where m.MemberID == memberID
                                  select m).First();
                    }
                    else
                    {
                        // should no happen
                        throw new Exception("No member is selected");
                    }
                }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridViewMemberList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMemberList.SelectedRows.Count == 0)
            {
                btnOK.Enabled = false;
                btnOK.BackColor = Color.LightGray;
                toolStripStatusLblSelectedMember.Text = "No record is found.";
            }
            else
            {
                btnOK.Enabled = true;
                btnOK.BackColor = Color.White;

                string selectedName = dataGridViewMemberList.CurrentRow.Cells["MemberNameColumn"].Value.ToString();

                toolStripStatusLblSelectedMember.Text = $"{selectedName} is selected.";
            }
        }
    }
}


