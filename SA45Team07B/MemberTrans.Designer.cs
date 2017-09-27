namespace SA45Team07B
{
    partial class MemberTrans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbMemberInfo = new System.Windows.Forms.GroupBox();
            this.txtbContactNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbFinePerDay = new System.Windows.Forms.TextBox();
            this.lblFinePerDay = new System.Windows.Forms.Label();
            this.txtbLoanPeriod = new System.Windows.Forms.TextBox();
            this.lblLoanPeriod = new System.Windows.Forms.Label();
            this.txtbLoanEntitlement = new System.Windows.Forms.TextBox();
            this.lblLoanEntitlement = new System.Windows.Forms.Label();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtbFacultyName = new System.Windows.Forms.TextBox();
            this.txtbMemberType = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblSchoolID = new System.Windows.Forms.Label();
            this.txtbSchoolID = new System.Windows.Forms.TextBox();
            this.txtbMemberID = new System.Windows.Forms.TextBox();
            this.txtbMemberName = new System.Windows.Forms.TextBox();
            this.lblLoanedQty = new System.Windows.Forms.Label();
            this.txtbLoanedQty = new System.Windows.Forms.TextBox();
            this.lblOverdueQty = new System.Windows.Forms.Label();
            this.txtbOverdueQty = new System.Windows.Forms.TextBox();
            this.lblUnpaidFine = new System.Windows.Forms.Label();
            this.txtbUnpaidFine = new System.Windows.Forms.TextBox();
            this.dataGridViewTransactionRecords = new System.Windows.Forms.DataGridView();
            this.DateIssuedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateActualReturnedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTransactionRecord = new System.Windows.Forms.GroupBox();
            this.rbtnReturned = new System.Windows.Forms.RadioButton();
            this.rbtnOnLoan = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbRemarksOfSelectedTransaction = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProviderForMemberID = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionRecords)).BeginInit();
            this.gbTransactionRecord.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForMemberID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(676, 817);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Visible = false;
            // 
            // gbMemberInfo
            // 
            this.gbMemberInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbMemberInfo.Controls.Add(this.txtbContactNumber);
            this.gbMemberInfo.Controls.Add(this.label2);
            this.gbMemberInfo.Controls.Add(this.txtbEmail);
            this.gbMemberInfo.Controls.Add(this.lblEmail);
            this.gbMemberInfo.Controls.Add(this.txtbFinePerDay);
            this.gbMemberInfo.Controls.Add(this.lblFinePerDay);
            this.gbMemberInfo.Controls.Add(this.txtbLoanPeriod);
            this.gbMemberInfo.Controls.Add(this.lblLoanPeriod);
            this.gbMemberInfo.Controls.Add(this.txtbLoanEntitlement);
            this.gbMemberInfo.Controls.Add(this.lblLoanEntitlement);
            this.gbMemberInfo.Controls.Add(this.btnSearchMember);
            this.gbMemberInfo.Controls.Add(this.txtbFacultyName);
            this.gbMemberInfo.Controls.Add(this.txtbMemberType);
            this.gbMemberInfo.Controls.Add(this.lblFaculty);
            this.gbMemberInfo.Controls.Add(this.lblMemberType);
            this.gbMemberInfo.Controls.Add(this.lblMemberID);
            this.gbMemberInfo.Controls.Add(this.lblMemberName);
            this.gbMemberInfo.Controls.Add(this.lblSchoolID);
            this.gbMemberInfo.Controls.Add(this.txtbSchoolID);
            this.gbMemberInfo.Controls.Add(this.txtbMemberID);
            this.gbMemberInfo.Controls.Add(this.txtbMemberName);
            this.gbMemberInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMemberInfo.Location = new System.Drawing.Point(22, 76);
            this.gbMemberInfo.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.gbMemberInfo.Name = "gbMemberInfo";
            this.gbMemberInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbMemberInfo.Size = new System.Drawing.Size(842, 235);
            this.gbMemberInfo.TabIndex = 25;
            this.gbMemberInfo.TabStop = false;
            this.gbMemberInfo.Text = "Member Information";
            // 
            // txtbContactNumber
            // 
            this.txtbContactNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbContactNumber.Location = new System.Drawing.Point(614, 183);
            this.txtbContactNumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbContactNumber.Name = "txtbContactNumber";
            this.txtbContactNumber.ReadOnly = true;
            this.txtbContactNumber.Size = new System.Drawing.Size(195, 29);
            this.txtbContactNumber.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Contact Number:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(163, 183);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.ReadOnly = true;
            this.txtbEmail.Size = new System.Drawing.Size(275, 29);
            this.txtbEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(30, 186);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email:";
            // 
            // txtbFinePerDay
            // 
            this.txtbFinePerDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFinePerDay.Location = new System.Drawing.Point(614, 145);
            this.txtbFinePerDay.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbFinePerDay.Name = "txtbFinePerDay";
            this.txtbFinePerDay.ReadOnly = true;
            this.txtbFinePerDay.Size = new System.Drawing.Size(195, 29);
            this.txtbFinePerDay.TabIndex = 10;
            // 
            // lblFinePerDay
            // 
            this.lblFinePerDay.AutoSize = true;
            this.lblFinePerDay.BackColor = System.Drawing.Color.Transparent;
            this.lblFinePerDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinePerDay.Location = new System.Drawing.Point(471, 147);
            this.lblFinePerDay.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblFinePerDay.Name = "lblFinePerDay";
            this.lblFinePerDay.Size = new System.Drawing.Size(98, 21);
            this.lblFinePerDay.TabIndex = 35;
            this.lblFinePerDay.Text = "Fine per day:";
            // 
            // txtbLoanPeriod
            // 
            this.txtbLoanPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLoanPeriod.Location = new System.Drawing.Point(614, 107);
            this.txtbLoanPeriod.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbLoanPeriod.Name = "txtbLoanPeriod";
            this.txtbLoanPeriod.ReadOnly = true;
            this.txtbLoanPeriod.Size = new System.Drawing.Size(195, 29);
            this.txtbLoanPeriod.TabIndex = 9;
            // 
            // lblLoanPeriod
            // 
            this.lblLoanPeriod.AutoSize = true;
            this.lblLoanPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblLoanPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanPeriod.Location = new System.Drawing.Point(471, 110);
            this.lblLoanPeriod.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblLoanPeriod.Name = "lblLoanPeriod";
            this.lblLoanPeriod.Size = new System.Drawing.Size(95, 21);
            this.lblLoanPeriod.TabIndex = 33;
            this.lblLoanPeriod.Text = "Loan Period:";
            // 
            // txtbLoanEntitlement
            // 
            this.txtbLoanEntitlement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLoanEntitlement.Location = new System.Drawing.Point(614, 70);
            this.txtbLoanEntitlement.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbLoanEntitlement.Name = "txtbLoanEntitlement";
            this.txtbLoanEntitlement.ReadOnly = true;
            this.txtbLoanEntitlement.Size = new System.Drawing.Size(195, 29);
            this.txtbLoanEntitlement.TabIndex = 8;
            // 
            // lblLoanEntitlement
            // 
            this.lblLoanEntitlement.AutoSize = true;
            this.lblLoanEntitlement.BackColor = System.Drawing.Color.Transparent;
            this.lblLoanEntitlement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanEntitlement.Location = new System.Drawing.Point(471, 72);
            this.lblLoanEntitlement.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblLoanEntitlement.Name = "lblLoanEntitlement";
            this.lblLoanEntitlement.Size = new System.Drawing.Size(130, 21);
            this.lblLoanEntitlement.TabIndex = 31;
            this.lblLoanEntitlement.Text = "Loan Entitlement:";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.BackColor = System.Drawing.Color.White;
            this.btnSearchMember.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnSearchMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearchMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.ForeColor = System.Drawing.Color.Black;
            this.btnSearchMember.Location = new System.Drawing.Point(410, 32);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(28, 26);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = false;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtbFacultyName
            // 
            this.txtbFacultyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFacultyName.Location = new System.Drawing.Point(163, 145);
            this.txtbFacultyName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbFacultyName.Name = "txtbFacultyName";
            this.txtbFacultyName.ReadOnly = true;
            this.txtbFacultyName.Size = new System.Drawing.Size(275, 29);
            this.txtbFacultyName.TabIndex = 5;
            // 
            // txtbMemberType
            // 
            this.txtbMemberType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMemberType.Location = new System.Drawing.Point(614, 32);
            this.txtbMemberType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbMemberType.Name = "txtbMemberType";
            this.txtbMemberType.ReadOnly = true;
            this.txtbMemberType.Size = new System.Drawing.Size(195, 29);
            this.txtbMemberType.TabIndex = 7;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.BackColor = System.Drawing.Color.Transparent;
            this.lblFaculty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(30, 147);
            this.lblFaculty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(107, 21);
            this.lblFaculty.TabIndex = 26;
            this.lblFaculty.Text = "Faculty Name:";
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberType.Location = new System.Drawing.Point(471, 34);
            this.lblMemberType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(108, 21);
            this.lblMemberType.TabIndex = 23;
            this.lblMemberType.Text = "Member Type:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(30, 34);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(91, 21);
            this.lblMemberID.TabIndex = 15;
            this.lblMemberID.Text = "Member ID:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(30, 72);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(118, 21);
            this.lblMemberName.TabIndex = 16;
            this.lblMemberName.Text = "Member Name:";
            // 
            // lblSchoolID
            // 
            this.lblSchoolID.AutoSize = true;
            this.lblSchoolID.BackColor = System.Drawing.Color.Transparent;
            this.lblSchoolID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolID.Location = new System.Drawing.Point(30, 110);
            this.lblSchoolID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblSchoolID.Name = "lblSchoolID";
            this.lblSchoolID.Size = new System.Drawing.Size(79, 21);
            this.lblSchoolID.TabIndex = 17;
            this.lblSchoolID.Text = "School ID:";
            // 
            // txtbSchoolID
            // 
            this.txtbSchoolID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSchoolID.Location = new System.Drawing.Point(163, 107);
            this.txtbSchoolID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbSchoolID.Name = "txtbSchoolID";
            this.txtbSchoolID.ReadOnly = true;
            this.txtbSchoolID.Size = new System.Drawing.Size(275, 29);
            this.txtbSchoolID.TabIndex = 4;
            // 
            // txtbMemberID
            // 
            this.txtbMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMemberID.Location = new System.Drawing.Point(163, 32);
            this.txtbMemberID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbMemberID.Name = "txtbMemberID";
            this.txtbMemberID.Size = new System.Drawing.Size(230, 29);
            this.txtbMemberID.TabIndex = 1;
            this.txtbMemberID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbMemberID_KeyDown);
            this.txtbMemberID.Validating += new System.ComponentModel.CancelEventHandler(this.txtbMemberID_Validating);
            // 
            // txtbMemberName
            // 
            this.txtbMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMemberName.Location = new System.Drawing.Point(163, 70);
            this.txtbMemberName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbMemberName.Name = "txtbMemberName";
            this.txtbMemberName.ReadOnly = true;
            this.txtbMemberName.Size = new System.Drawing.Size(275, 29);
            this.txtbMemberName.TabIndex = 3;
            // 
            // lblLoanedQty
            // 
            this.lblLoanedQty.AutoSize = true;
            this.lblLoanedQty.BackColor = System.Drawing.Color.Transparent;
            this.lblLoanedQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanedQty.Location = new System.Drawing.Point(28, 358);
            this.lblLoanedQty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblLoanedQty.Name = "lblLoanedQty";
            this.lblLoanedQty.Size = new System.Drawing.Size(136, 21);
            this.lblLoanedQty.TabIndex = 27;
            this.lblLoanedQty.Text = "On Loan Quantity:";
            // 
            // txtbLoanedQty
            // 
            this.txtbLoanedQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLoanedQty.Location = new System.Drawing.Point(178, 355);
            this.txtbLoanedQty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbLoanedQty.Name = "txtbLoanedQty";
            this.txtbLoanedQty.ReadOnly = true;
            this.txtbLoanedQty.Size = new System.Drawing.Size(106, 29);
            this.txtbLoanedQty.TabIndex = 14;
            // 
            // lblOverdueQty
            // 
            this.lblOverdueQty.AutoSize = true;
            this.lblOverdueQty.BackColor = System.Drawing.Color.Transparent;
            this.lblOverdueQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueQty.Location = new System.Drawing.Point(311, 358);
            this.lblOverdueQty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblOverdueQty.Name = "lblOverdueQty";
            this.lblOverdueQty.Size = new System.Drawing.Size(137, 21);
            this.lblOverdueQty.TabIndex = 31;
            this.lblOverdueQty.Text = "Overdue Quantity:";
            // 
            // txtbOverdueQty
            // 
            this.txtbOverdueQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbOverdueQty.Location = new System.Drawing.Point(462, 355);
            this.txtbOverdueQty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbOverdueQty.Name = "txtbOverdueQty";
            this.txtbOverdueQty.ReadOnly = true;
            this.txtbOverdueQty.Size = new System.Drawing.Size(106, 29);
            this.txtbOverdueQty.TabIndex = 15;
            // 
            // lblUnpaidFine
            // 
            this.lblUnpaidFine.AutoSize = true;
            this.lblUnpaidFine.BackColor = System.Drawing.Color.Transparent;
            this.lblUnpaidFine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaidFine.Location = new System.Drawing.Point(589, 358);
            this.lblUnpaidFine.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblUnpaidFine.Name = "lblUnpaidFine";
            this.lblUnpaidFine.Size = new System.Drawing.Size(96, 21);
            this.lblUnpaidFine.TabIndex = 33;
            this.lblUnpaidFine.Text = "Unpaid Fine:";
            // 
            // txtbUnpaidFine
            // 
            this.txtbUnpaidFine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUnpaidFine.Location = new System.Drawing.Point(699, 355);
            this.txtbUnpaidFine.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbUnpaidFine.Name = "txtbUnpaidFine";
            this.txtbUnpaidFine.ReadOnly = true;
            this.txtbUnpaidFine.Size = new System.Drawing.Size(106, 29);
            this.txtbUnpaidFine.TabIndex = 16;
            // 
            // dataGridViewTransactionRecords
            // 
            this.dataGridViewTransactionRecords.AllowUserToAddRows = false;
            this.dataGridViewTransactionRecords.AllowUserToDeleteRows = false;
            this.dataGridViewTransactionRecords.AllowUserToOrderColumns = true;
            this.dataGridViewTransactionRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTransactionRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransactionRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewTransactionRecords.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransactionRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTransactionRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransactionRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTransactionRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactionRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateIssuedColumn,
            this.DateDueColumn,
            this.DateActualReturnedColumn,
            this.BookIDColumn,
            this.BookTitleColumn,
            this.RFIDColumn,
            this.TransactionIDColumn,
            this.StatusColumn,
            this.RemarksColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTransactionRecords.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTransactionRecords.EnableHeadersVisualStyles = false;
            this.dataGridViewTransactionRecords.GridColor = System.Drawing.Color.White;
            this.dataGridViewTransactionRecords.Location = new System.Drawing.Point(32, 59);
            this.dataGridViewTransactionRecords.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.dataGridViewTransactionRecords.MultiSelect = false;
            this.dataGridViewTransactionRecords.Name = "dataGridViewTransactionRecords";
            this.dataGridViewTransactionRecords.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransactionRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTransactionRecords.RowHeadersVisible = false;
            this.dataGridViewTransactionRecords.RowHeadersWidth = 5;
            this.dataGridViewTransactionRecords.RowTemplate.Height = 24;
            this.dataGridViewTransactionRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewTransactionRecords.Size = new System.Drawing.Size(773, 278);
            this.dataGridViewTransactionRecords.TabIndex = 35;
            this.dataGridViewTransactionRecords.DataSourceChanged += new System.EventHandler(this.dataGridViewTransactionRecords_DataSourceChanged);
            this.dataGridViewTransactionRecords.SelectionChanged += new System.EventHandler(this.dataGridViewTransactionRecords_SelectionChanged);
            // 
            // DateIssuedColumn
            // 
            this.DateIssuedColumn.DataPropertyName = "DateIssued";
            this.DateIssuedColumn.HeaderText = "Issue Date";
            this.DateIssuedColumn.Name = "DateIssuedColumn";
            this.DateIssuedColumn.ReadOnly = true;
            this.DateIssuedColumn.Width = 116;
            // 
            // DateDueColumn
            // 
            this.DateDueColumn.DataPropertyName = "DateDue";
            this.DateDueColumn.HeaderText = "Due Date";
            this.DateDueColumn.Name = "DateDueColumn";
            this.DateDueColumn.ReadOnly = true;
            this.DateDueColumn.Width = 110;
            // 
            // DateActualReturnedColumn
            // 
            this.DateActualReturnedColumn.DataPropertyName = "DateActualReturned";
            this.DateActualReturnedColumn.HeaderText = "Actual Returned Date";
            this.DateActualReturnedColumn.Name = "DateActualReturnedColumn";
            this.DateActualReturnedColumn.ReadOnly = true;
            this.DateActualReturnedColumn.Width = 156;
            // 
            // BookIDColumn
            // 
            this.BookIDColumn.DataPropertyName = "BookID";
            this.BookIDColumn.HeaderText = "Book ID";
            this.BookIDColumn.Name = "BookIDColumn";
            this.BookIDColumn.ReadOnly = true;
            this.BookIDColumn.Width = 101;
            // 
            // BookTitleColumn
            // 
            this.BookTitleColumn.DataPropertyName = "BookTitle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.BookTitleColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookTitleColumn.HeaderText = "Book Title";
            this.BookTitleColumn.Name = "BookTitleColumn";
            this.BookTitleColumn.ReadOnly = true;
            this.BookTitleColumn.Width = 114;
            // 
            // RFIDColumn
            // 
            this.RFIDColumn.DataPropertyName = "RFID";
            this.RFIDColumn.HeaderText = "RFID";
            this.RFIDColumn.Name = "RFIDColumn";
            this.RFIDColumn.ReadOnly = true;
            this.RFIDColumn.Width = 87;
            // 
            // TransactionIDColumn
            // 
            this.TransactionIDColumn.DataPropertyName = "TransactionID";
            this.TransactionIDColumn.HeaderText = "Transaction ID";
            this.TransactionIDColumn.Name = "TransactionIDColumn";
            this.TransactionIDColumn.ReadOnly = true;
            this.TransactionIDColumn.Width = 141;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DataPropertyName = "Status";
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 96;
            // 
            // RemarksColumn
            // 
            this.RemarksColumn.DataPropertyName = "Remarks";
            this.RemarksColumn.HeaderText = "Remarks";
            this.RemarksColumn.Name = "RemarksColumn";
            this.RemarksColumn.ReadOnly = true;
            this.RemarksColumn.Width = 115;
            // 
            // gbTransactionRecord
            // 
            this.gbTransactionRecord.BackColor = System.Drawing.Color.Transparent;
            this.gbTransactionRecord.Controls.Add(this.rbtnReturned);
            this.gbTransactionRecord.Controls.Add(this.lblUnpaidFine);
            this.gbTransactionRecord.Controls.Add(this.txtbUnpaidFine);
            this.gbTransactionRecord.Controls.Add(this.dataGridViewTransactionRecords);
            this.gbTransactionRecord.Controls.Add(this.rbtnOnLoan);
            this.gbTransactionRecord.Controls.Add(this.txtbOverdueQty);
            this.gbTransactionRecord.Controls.Add(this.lblOverdueQty);
            this.gbTransactionRecord.Controls.Add(this.lblLoanedQty);
            this.gbTransactionRecord.Controls.Add(this.txtbLoanedQty);
            this.gbTransactionRecord.Location = new System.Drawing.Point(22, 322);
            this.gbTransactionRecord.Margin = new System.Windows.Forms.Padding(2);
            this.gbTransactionRecord.Name = "gbTransactionRecord";
            this.gbTransactionRecord.Padding = new System.Windows.Forms.Padding(2);
            this.gbTransactionRecord.Size = new System.Drawing.Size(842, 404);
            this.gbTransactionRecord.TabIndex = 36;
            this.gbTransactionRecord.TabStop = false;
            this.gbTransactionRecord.Text = "Transaction Record";
            // 
            // rbtnReturned
            // 
            this.rbtnReturned.AutoSize = true;
            this.rbtnReturned.Location = new System.Drawing.Point(270, 24);
            this.rbtnReturned.Margin = new System.Windows.Forms.Padding(8);
            this.rbtnReturned.Name = "rbtnReturned";
            this.rbtnReturned.Size = new System.Drawing.Size(92, 25);
            this.rbtnReturned.TabIndex = 13;
            this.rbtnReturned.Text = "Returned";
            this.rbtnReturned.UseVisualStyleBackColor = true;
            this.rbtnReturned.CheckedChanged += new System.EventHandler(this.rbtnReturned_CheckedChanged);
            // 
            // rbtnOnLoan
            // 
            this.rbtnOnLoan.AutoSize = true;
            this.rbtnOnLoan.Checked = true;
            this.rbtnOnLoan.Location = new System.Drawing.Point(163, 24);
            this.rbtnOnLoan.Name = "rbtnOnLoan";
            this.rbtnOnLoan.Size = new System.Drawing.Size(87, 25);
            this.rbtnOnLoan.TabIndex = 12;
            this.rbtnOnLoan.TabStop = true;
            this.rbtnOnLoan.Text = "On Loan";
            this.rbtnOnLoan.UseVisualStyleBackColor = true;
            this.rbtnOnLoan.CheckedChanged += new System.EventHandler(this.rbtnOnLoan_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 936);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 26);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(280, 21);
            this.toolStripStatusLabel1.Text = "Input a Member ID or Press ESC to exit.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtbRemarksOfSelectedTransaction);
            this.groupBox1.Location = new System.Drawing.Point(22, 738);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 182);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remarks of selected transaction";
            // 
            // txtbRemarksOfSelectedTransaction
            // 
            this.txtbRemarksOfSelectedTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRemarksOfSelectedTransaction.Location = new System.Drawing.Point(32, 32);
            this.txtbRemarksOfSelectedTransaction.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbRemarksOfSelectedTransaction.MaxLength = 255;
            this.txtbRemarksOfSelectedTransaction.Multiline = true;
            this.txtbRemarksOfSelectedTransaction.Name = "txtbRemarksOfSelectedTransaction";
            this.txtbRemarksOfSelectedTransaction.Size = new System.Drawing.Size(613, 135);
            this.txtbRemarksOfSelectedTransaction.TabIndex = 17;
            this.txtbRemarksOfSelectedTransaction.TextChanged += new System.EventHandler(this.txtbRemarksOfSelectedTransaction_TextChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.White;
            this.btnSaveChanges.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(733, 772);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(94, 76);
            this.btnSaveChanges.TabIndex = 18;
            this.btnSaveChanges.Text = "Submit Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(733, 860);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 41);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProviderForMemberID
            // 
            this.errorProviderForMemberID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderForMemberID.ContainerControl = this;
            // 
            // MemberTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(884, 962);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbMemberInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbTransactionRecord);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MemberTrans";
            this.Text = "Member Transaction  - Library Management System SA45Team07B";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.gbTransactionRecord, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.gbMemberInfo, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.btnSaveChanges, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gbMemberInfo.ResumeLayout(false);
            this.gbMemberInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionRecords)).EndInit();
            this.gbTransactionRecord.ResumeLayout(false);
            this.gbTransactionRecord.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForMemberID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMemberInfo;
        private System.Windows.Forms.Label lblLoanedQty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblSchoolID;
        private System.Windows.Forms.TextBox txtbSchoolID;
        private System.Windows.Forms.TextBox txtbMemberID;
        private System.Windows.Forms.TextBox txtbMemberName;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtbLoanedQty;
        private System.Windows.Forms.TextBox txtbFacultyName;
        private System.Windows.Forms.TextBox txtbMemberType;
        private System.Windows.Forms.TextBox txtbFinePerDay;
        private System.Windows.Forms.Label lblFinePerDay;
        private System.Windows.Forms.TextBox txtbLoanPeriod;
        private System.Windows.Forms.Label lblLoanPeriod;
        private System.Windows.Forms.TextBox txtbLoanEntitlement;
        private System.Windows.Forms.Label lblLoanEntitlement;
        private System.Windows.Forms.Label lblOverdueQty;
        private System.Windows.Forms.TextBox txtbOverdueQty;
        private System.Windows.Forms.Label lblUnpaidFine;
        private System.Windows.Forms.TextBox txtbUnpaidFine;
        private System.Windows.Forms.DataGridView dataGridViewTransactionRecords;
        private System.Windows.Forms.GroupBox gbTransactionRecord;
        private System.Windows.Forms.RadioButton rbtnReturned;
        private System.Windows.Forms.RadioButton rbtnOnLoan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtbRemarksOfSelectedTransaction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIssuedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateActualReturnedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarksColumn;
        private System.Windows.Forms.TextBox txtbContactNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ErrorProvider errorProviderForMemberID;
    }
}
