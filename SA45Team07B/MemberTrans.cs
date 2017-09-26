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
        private List<IssueTran> onLoanTransactionRecords;
        private List<IssueTran> returnedTransactionRecords;
        private IssueTran selectedTransaction = null;

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
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
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
                        onLoanTransactionRecords = (from x in context.IssueTrans
                                                    where x.MemberID == memberFound.MemberID && x.Status == "out"
                                                    select x).ToList();

                        var displayList = (from x in onLoanTransactionRecords
                                           orderby x.DateIssued ascending
                                           select new
                                           {
                                               x.DateIssued,
                                               x.DateDue,
                                               x.DateActualReturned,
                                               x.RFIDs.BookID,
                                               x.RFIDs.Books.BookTitle,
                                               x.RFIDs.RFID,
                                               x.TransactionID,
                                               x.Status,
                                               x.Remarks
                                           }).ToList();

                        dataGridViewTransactionRecords.DataSource = displayList;

                        CalculateFine();

                    }
                    else if (rbtnReturned.Checked == true)
                    {
                        returnedTransactionRecords = (from x in context.IssueTrans
                                                      where x.MemberID == memberFound.MemberID && x.Status == "in"
                                                      select x).ToList();


                        var displayList = (from x in returnedTransactionRecords
                                           orderby x.DateIssued ascending
                                           select new
                                           {
                                               x.DateIssued,
                                               x.DateDue,
                                               x.DateActualReturned,
                                               x.RFIDs.BookID,
                                               x.RFIDs.Books.BookTitle,
                                               x.RFIDs.RFID,
                                               x.TransactionID,
                                               x.Status,
                                               x.Remarks
                                           }).ToList();

                        dataGridViewTransactionRecords.DataSource = displayList;

                        txtbLoanedQty.Text = string.Empty;
                        txtbOverdueQty.Text = string.Empty;
                        txtbUnpaidFine.Text = string.Empty;

                    }
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // TODO - to save remarks change
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
            int numberOfRecords = dataGridViewTransactionRecords.RowCount;

            if (numberOfRecords > 0)
            {
                if (dataGridViewTransactionRecords.CurrentRow.Cells["RemarksColumn"].Value != null)
                {
                    txtbRemarksOfSelectedTransaction.Text = dataGridViewTransactionRecords.CurrentRow.Cells["RemarksColumn"].Value.ToString();
                }
                else
                {
                    txtbRemarksOfSelectedTransaction.Text = string.Empty;
                }
            }
            else
            {
                txtbRemarksOfSelectedTransaction.Text = string.Empty;
            }
        }

        private void dataGridViewTransactionRecords_DataSourceChanged(object sender, EventArgs e)
        {
            int numberOfRecords = dataGridViewTransactionRecords.RowCount;

            if (numberOfRecords > 0)
            {
                if (dataGridViewTransactionRecords.CurrentRow.Cells["RemarksColumn"].Value != null)
                {
                    txtbRemarksOfSelectedTransaction.Text = dataGridViewTransactionRecords.CurrentRow.Cells["RemarksColumn"].Value.ToString();
                }
                else
                {
                    txtbRemarksOfSelectedTransaction.Text = string.Empty;
                }

                toolStripStatusLblRecordFound.Text = $"{numberOfRecords} record(s) is found";
            }
            else
            {
                toolStripStatusLblRecordFound.Text = "No record is found.";

                txtbRemarksOfSelectedTransaction.Text = string.Empty;
            }
        }

        private void FindSelectedTransaction()
        {
            if (dataGridViewTransactionRecords.RowCount != 0)
            {
                long transactionID = Int64.Parse(dataGridViewTransactionRecords.CurrentRow.Cells["TransactionIDColumn"].Value.ToString());

                using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
                {
                    selectedTransaction = (from x in context.IssueTrans
                                           where x.TransactionID == transactionID
                                           select x).First();
                }
            }
        }

        private void CalculateFine()
        {
            int onLoanQty = 0;
            int overdueQty = 0;
            decimal fine = 0.0M;

            if (dataGridViewTransactionRecords.RowCount != 0)
            {
                foreach (DataGridViewRow row in dataGridViewTransactionRecords.Rows)
                {
                    onLoanQty++;

                    try
                    {
                        DateTime dueDate = (DateTime)row.Cells["DateDueColumn"].Value;
                        double dayDiff = (DateTime.Today - dueDate).TotalDays;

                        if (dayDiff > 0)
                        {
                            overdueQty++;
                            fine += (decimal)dayDiff * memberTypeOfMemberFound.FinePerDay;
                            row.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Invalid due date format");
                    }
                }

                txtbLoanedQty.Text = onLoanQty.ToString();
                txtbOverdueQty.Text = overdueQty.ToString();
                txtbUnpaidFine.Text = String.Format("{0:c}", fine);

                if (fine > 0)
                {
                    txtbUnpaidFine.BackColor = SystemColors.Control;
                    txtbUnpaidFine.ForeColor = Color.Red;
                }
                else
                {
                    txtbUnpaidFine.BackColor = SystemColors.Control;
                    txtbUnpaidFine.ForeColor = SystemColors.WindowText;
                }


            }
        }
    }
}
