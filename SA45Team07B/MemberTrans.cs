using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class MemberTrans : SA45Team07B.BaseForm
    {
        private Member memberFound;
        private MemberCategories memberTypeOfMemberFound;
        private Faculty facultyOfMemberFound;
        private List<IssueTran> transactionRecords;

        public MemberTrans()
        {
            InitializeComponent();
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            using (MemberPopUpSearch mps = new MemberPopUpSearch())
            {
                if (mps.ShowDialog() == DialogResult.OK)
                {
                    memberFound = mps.MemberFound;
                    facultyOfMemberFound = mps.FacultyofMemberFound;
                    memberTypeOfMemberFound = mps.MemberTypeOfMemberFound;

                    DisplayTextBoxData();
                    DisplayDGVData();
                }
            }
        }

        private void DisplayTextBoxData()
        {
            using(SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                if (memberFound != null)
                {
                    txtbMemberID.Text = memberFound.MemberID.ToString();
                    txtbMemberName.Text = memberFound.MemberName;
                    txtbSchoolID.Text = memberFound.SchoolID;
                    txtbFacultyName.Text = facultyOfMemberFound.FacultyName;
                    txtbMemberType.Text = memberTypeOfMemberFound.CategoryName;
                    txtbLoanEntitlement.Text = memberTypeOfMemberFound.LoanEntitlement.ToString();
                    txtbLoanPeriod.Text = memberTypeOfMemberFound.LoanPeriod.ToString();
                    txtbFinePerDay.Text = memberTypeOfMemberFound.FinePerDay.ToString();
                }

            }
        }

        private void DisplayDGVData()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                if (memberFound != null)
                {
                    if (rbtnOnLoan.Checked == true)
                    {
                        transactionRecords = (from x in context.IssueTrans
                                              where x.MemberID == memberFound.MemberID && x.Status == "out"
                                              select x).ToList();
                    }
                    else if (rbtnReturned.Checked == true)
                    {
                        transactionRecords = (from x in context.IssueTrans
                                              where x.MemberID == memberFound.MemberID && x.Status == "in"
                                              select x).ToList();
                    }
                }

                dataGridViewTransactionRecords.DataSource = transactionRecords;
            }

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnOnLoan_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDGVData();
        }

        private void rbtnReturned_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDGVData();
        }

        private void dataGridViewTransactionRecords_SelectionChanged(object sender, EventArgs e)
        {
            txtbRemarksOfSelectedTransaction.Text = dataGridViewTransactionRecords.CurrentRow.Cells[0].Value.ToString();
            
        }
    }
}
