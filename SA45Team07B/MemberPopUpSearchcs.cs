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
    public partial class MemberPopUpSearch : Form
    {

        private Member memberFound;
        private Faculty facultyofMemberFound;
        private MemberCategories memberTypeOfMemberFound;

        private bool isFirstLoad;

        public Member MemberFound
        {
            get
            {
                return memberFound;
            }
        }

        public Faculty FacultyofMemberFound
        {
            get
            {
                return facultyofMemberFound;
            }
        }

        public MemberCategories MemberTypeOfMemberFound
        {
            get
            {
                return memberTypeOfMemberFound;
            }
        }

        public MemberPopUpSearch()
        {
            InitializeComponent();
        }

        private void MemberPopUpSearch_Load(object sender, EventArgs e)
        {
            // Lazy loading - load the first 25 rows first
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                var displayList = (from m in context.Members
                                   select new
                                   {
                                       m.MemberID,
                                       m.MemberName,
                                       m.MemberType,
                                       m.FacultyCode,
                                       m.SchoolID,
                                       m.ContactNumber,
                                       m.Email,
                                       m.LoanedQty
                                   }).Take(25).ToList();

                dataGridViewMemberList.DataSource = displayList.ToList();

                isFirstLoad = true;
            }
        }


        /// <summary>
        /// Apply criteria search and display the value to datagridview.
        /// </summary>
        private void SearchAndDisplayMember()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                List<Member> searchResult = new List<Member>();

                // Start with a list of all member
                searchResult = context.Members.ToList();

                // Result is refined after calling CriteriaSearch
                searchResult = CriteriaSeach(searchResult, txtbMemberName, "MemberName");
                searchResult = CriteriaSeach(searchResult, txtbSchoolID, "SchoolID");
                searchResult = CriteriaSeach(searchResult, txtbEmail, "Email");

                // Select desired columns
                var displayList = from m in searchResult
                                  select new { m.MemberID, m.MemberName, m.MemberType, m.FacultyCode, m.SchoolID, m.ContactNumber, m.Email, m.LoanedQty };

                // Bind datasource to displayList
                dataGridViewMemberList.DataSource = displayList.ToList();
            }
        }

        /// <summary>
        /// Specify property using its name and do query on list based on the text value of textbox.
        /// <param name="memberList"></param>
        /// <param name="textbox"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private List<Member> CriteriaSeach(List<Member> memberList, TextBox textbox, string propertyName)
        {
            if (textbox.Text != string.Empty)
            {
                memberList = (from x in memberList
                              where (x.GetType().GetProperty(propertyName).GetValue(x).ToString().ToLower().Contains(textbox.Text.ToString().ToLower().Trim()))
                              select x).ToList();
            }
            return memberList;
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
                    this.memberFound = (from m in context.Members
                                        where m.MemberID == memberID
                                        select m).First();

                    this.facultyofMemberFound = memberFound.Faculties;
                    this.memberTypeOfMemberFound = memberFound.MemberCategories;
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
                toolStripStatusLblSelectedMember.Text = "No record is found.";
            }
            else
            {
                btnOK.Enabled = true;

                string selectedName = dataGridViewMemberList.CurrentRow.Cells["MemberNameColumn"].Value.ToString();
                toolStripStatusLblSelectedMember.Text = $"{selectedName} is selected.";
            }
        }


        private void dataGridViewMemberList_Scroll(object sender, ScrollEventArgs e)
        {
            if(e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if(isFirstLoad)
                {
                    SearchAndDisplayMember();
                    // remove event handler
                    this.dataGridViewMemberList.Scroll -= new System.Windows.Forms.ScrollEventHandler(this.dataGridViewMemberList_Scroll);                 
                }
            }
        }
    }
}


