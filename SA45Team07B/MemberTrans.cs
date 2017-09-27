using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Transactions;
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

        private bool? submitsuccessful;

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
                    txtbMemberID.Text = mps.MemberFound.MemberID.ToString();

                    ValidatetxtbMemberID();
                    DisplayTextboxData();
                    DisplayDGVData();
                }
                else
                {
                    memberFound = null;
                }
            }
        }

        private void DisplayTextboxData()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                if (memberFound != null)
                {
                    txtbMemberID.Text = memberFound.MemberID.ToString();
                    txtbMemberName.Text = memberFound.MemberName;
                    txtbSchoolID.Text = memberFound.SchoolID;
                    txtbFacultyName.Text = facultyOfMemberFound.FacultyName;
                    txtbEmail.Text = memberFound.Email.ToString();
                    txtbMemberType.Text = memberTypeOfMemberFound.CategoryName;
                    txtbLoanEntitlement.Text = memberTypeOfMemberFound.LoanEntitlement.ToString();
                    txtbLoanPeriod.Text = memberTypeOfMemberFound.LoanPeriod.ToString();
                    txtbFinePerDay.Text = memberTypeOfMemberFound.FinePerDay.ToString();
                    txtbContactNumber.Text = memberFound.ContactNumber.ToString();
                }
            }
        }


        private void ValidatetxtbMemberID()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                string inputID = txtbMemberID.Text.ToString();

                this.memberFound = (from x in context.Members
                                    where x.MemberID.ToString() == inputID
                                    select x).FirstOrDefault();

                if (memberFound != null)
                {
                    facultyOfMemberFound = memberFound.Faculties;
                    memberTypeOfMemberFound = memberFound.MemberCategories;

                    DisplayTextboxData();
                    DisplayDGVData();

                    errorProviderForMemberID.SetError(txtbMemberID, "");

                }
                else
                {
                    errorProviderForMemberID.SetError(txtbMemberID, "Invalid Member ID");

                    toolStripStatusLabel1.Text = "Invalid Member ID";

                    ClearTextboxData();
                    DisplayDGVData();

                    btnSaveChanges.Enabled = false;
                }
            }
        }

        private void ClearTextboxData()
        {
            txtbMemberID.Text = string.Empty;
            txtbMemberName.Text = string.Empty;
            txtbSchoolID.Text = string.Empty;
            txtbFacultyName.Text = string.Empty;
            txtbEmail.Text = string.Empty;
            txtbMemberType.Text = string.Empty;
            txtbLoanEntitlement.Text = string.Empty;
            txtbLoanPeriod.Text = string.Empty;
            txtbFinePerDay.Text = string.Empty;
            txtbContactNumber.Text = string.Empty;

            txtbLoanedQty.Text = string.Empty;
            txtbOverdueQty.Text = string.Empty;
            txtbUnpaidFine.Text = string.Empty;

            txtbRemarksOfSelectedTransaction.Text = string.Empty;
        }

        private void DisplayDGVData()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                List<TransactionInformationToDisplay> displayList = new List<TransactionInformationToDisplay>();

                if (memberFound != null)
                {
                    if (rbtnOnLoan.Checked == true)
                    {
                        onLoanTransactionRecords = (from x in context.IssueTrans
                                                    where x.MemberID == memberFound.MemberID && x.Status == "out"
                                                    select x).ToList();

                        displayList = (from x in onLoanTransactionRecords
                                       orderby x.DateIssued ascending
                                       select new TransactionInformationToDisplay
                                       {
                                           DateIssued = x.DateIssued,
                                           DateDue = x.DateDue,
                                           DateActualReturned = x.DateActualReturned,
                                           BookID = x.RFIDs.BookID,
                                           BookTitle = x.RFIDs.Books.BookTitle,
                                           RFID = x.RFIDs.RFID,
                                           TransactionID = x.TransactionID,
                                           Status = x.Status,
                                           Remarks = x.Remarks
                                       }).ToList();

                        dataGridViewTransactionRecords.DataSource = displayList;


                    }
                    else if (rbtnReturned.Checked == true)
                    {
                        returnedTransactionRecords = (from x in context.IssueTrans
                                                      where x.MemberID == memberFound.MemberID && x.Status == "in"
                                                      select x).ToList();


                        displayList = (from x in returnedTransactionRecords
                                       orderby x.DateIssued ascending
                                       select new TransactionInformationToDisplay
                                       {
                                           DateIssued = x.DateIssued,
                                           DateDue = x.DateDue,
                                           DateActualReturned = x.DateActualReturned,
                                           BookID = x.RFIDs.BookID,
                                           BookTitle = x.RFIDs.Books.BookTitle,
                                           RFID = x.RFIDs.RFID,
                                           TransactionID = x.TransactionID,
                                           Status = x.Status,
                                           Remarks = x.Remarks
                                       }).ToList();

                        dataGridViewTransactionRecords.DataSource = displayList;

                        txtbLoanedQty.Text = string.Empty;
                        txtbOverdueQty.Text = string.Empty;
                        txtbUnpaidFine.Text = string.Empty;

                    }


                CalculateFine();


                }
                else
                {
                    displayList.Clear();
                    dataGridViewTransactionRecords.DataSource = displayList;
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            IssueTran selectedTransaction = null;

            if (dataGridViewTransactionRecords.RowCount != 0)
            {
                long transactionID = Int64.Parse(dataGridViewTransactionRecords.CurrentRow.Cells["TransactionIDColumn"].Value.ToString());

                using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
                {
                    selectedTransaction = (from x in context.IssueTrans
                                           where x.TransactionID == transactionID
                                           select x).First();

                    if (selectedTransaction != null)
                    {
                        using (TransactionScope ts = new TransactionScope())
                        {
                            if (txtbRemarksOfSelectedTransaction.Text.Length > 255)
                            {
                                // should no happen as the textbox max length is 255
                                MessageBox.Show("Remarks exceed maximum length.");
                            }
                            else
                            {
                                selectedTransaction.Remarks = txtbRemarksOfSelectedTransaction.Text.ToString();
                                int i = context.SaveChanges();
                                ts.Complete();

                                if (i > 0)
                                {
                                    submitsuccessful = true;
                                }
                                else
                                {
                                    submitsuccessful = false;
                                }
                            }
                        }
                    }
                }
            }

            DisplayDGVData();
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

                if (submitsuccessful == true)
                {
                    toolStripStatusLabel1.Text = "Remarks has been submitted.";
                    submitsuccessful = null;
                }
                else if(submitsuccessful == false)
                {
                    toolStripStatusLabel1.Text = "No change.";
                    submitsuccessful = null;
                }
                else
                {
                    toolStripStatusLabel1.Text = $"{numberOfRecords} record(s) is found";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "No record is found.";

                txtbRemarksOfSelectedTransaction.Text = string.Empty;
            }
        }


        private void CalculateFine()
        {
            int onLoanQty = 0;
            int overdueQty = 0;
            decimal fine = 0.0M;

            if (rbtnOnLoan.Checked == true)
            {
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
                else
                {
                    txtbLoanedQty.Text = string.Empty;
                    txtbOverdueQty.Text = string.Empty;
                    txtbUnpaidFine.Text = string.Empty;

                }
            }
            else
            {
                txtbLoanedQty.Text = string.Empty;
                txtbOverdueQty.Text = string.Empty;
                txtbUnpaidFine.Text = string.Empty;
            }
        }

        private void txtbMemberID_Validating(object sender, CancelEventArgs e)
        {
            ValidatetxtbMemberID();
        }

        private void txtbMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidatetxtbMemberID();
            }
        }

        private void txtbRemarksOfSelectedTransaction_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void txtbMemberID_TextChanged(object sender, EventArgs e)
        {
            ValidatetxtbMemberID();
        }
    }



    public class TransactionInformationToDisplay
    {
        public DateTime DateIssued { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime? DateActualReturned { get; set; }
        public long BookID { get; set; }
        public string BookTitle { get; set; }
        public string RFID { get; set; }
        public long TransactionID { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }

}
