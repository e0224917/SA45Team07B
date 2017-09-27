namespace SA45Team07B
{
    partial class ReturnForm
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
            this.gbReturnTransaction = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtbFine = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtbRemarks = new System.Windows.Forms.TextBox();
            this.gbBookInfo = new System.Windows.Forms.GroupBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.lblDateIssue = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtbBookID = new System.Windows.Forms.TextBox();
            this.btnSearchRFID = new System.Windows.Forms.Button();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtbRFID = new System.Windows.Forms.TextBox();
            this.txtbBookTitle = new System.Windows.Forms.TextBox();
            this.gpBorrowerInfo = new System.Windows.Forms.GroupBox();
            this.txtbFaculty = new System.Windows.Forms.TextBox();
            this.txtbMemberType = new System.Windows.Forms.TextBox();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lblSchoolID = new System.Windows.Forms.Label();
            this.txtbSchoolID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtbMemberID = new System.Windows.Forms.TextBox();
            this.txtbMemberName = new System.Windows.Forms.TextBox();
            this.errorProviderForRFID = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbReturnTransaction.SuspendLayout();
            this.gbBookInfo.SuspendLayout();
            this.gpBorrowerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForRFID)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReturnTransaction
            // 
            this.gbReturnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.gbReturnTransaction.Controls.Add(this.Cancel);
            this.gbReturnTransaction.Controls.Add(this.lblFine);
            this.gbReturnTransaction.Controls.Add(this.txtbFine);
            this.gbReturnTransaction.Controls.Add(this.dtpReturnDate);
            this.gbReturnTransaction.Controls.Add(this.lblReturnDate);
            this.gbReturnTransaction.Controls.Add(this.lblRemarks);
            this.gbReturnTransaction.Controls.Add(this.btnSubmit);
            this.gbReturnTransaction.Controls.Add(this.txtbRemarks);
            this.gbReturnTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReturnTransaction.Location = new System.Drawing.Point(762, 87);
            this.gbReturnTransaction.Margin = new System.Windows.Forms.Padding(20);
            this.gbReturnTransaction.Name = "gbReturnTransaction";
            this.gbReturnTransaction.Padding = new System.Windows.Forms.Padding(2);
            this.gbReturnTransaction.Size = new System.Drawing.Size(353, 419);
            this.gbReturnTransaction.TabIndex = 25;
            this.gbReturnTransaction.TabStop = false;
            this.gbReturnTransaction.Text = "Return Transaction Detail";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(188, 358);
            this.Cancel.Margin = new System.Windows.Forms.Padding(6);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(92, 40);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.BackColor = System.Drawing.Color.Transparent;
            this.lblFine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(36, 106);
            this.lblFine.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(42, 21);
            this.lblFine.TabIndex = 35;
            this.lblFine.Text = "Fine:";
            // 
            // txtbFine
            // 
            this.txtbFine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFine.Location = new System.Drawing.Point(40, 133);
            this.txtbFine.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbFine.Name = "txtbFine";
            this.txtbFine.ReadOnly = true;
            this.txtbFine.Size = new System.Drawing.Size(275, 29);
            this.txtbFine.TabIndex = 14;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(40, 60);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(275, 29);
            this.dtpReturnDate.TabIndex = 2;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(36, 34);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(6);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(96, 21);
            this.lblReturnDate.TabIndex = 15;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(36, 182);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(6);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(74, 21);
            this.lblRemarks.TabIndex = 16;
            this.lblRemarks.Text = "Remarks:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(78, 358);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 40);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtbRemarks
            // 
            this.txtbRemarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRemarks.Location = new System.Drawing.Point(40, 210);
            this.txtbRemarks.Margin = new System.Windows.Forms.Padding(6);
            this.txtbRemarks.MaxLength = 255;
            this.txtbRemarks.Multiline = true;
            this.txtbRemarks.Name = "txtbRemarks";
            this.txtbRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbRemarks.Size = new System.Drawing.Size(275, 128);
            this.txtbRemarks.TabIndex = 3;
            // 
            // gbBookInfo
            // 
            this.gbBookInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbBookInfo.Controls.Add(this.dtpDueDate);
            this.gbBookInfo.Controls.Add(this.dtpIssueDate);
            this.gbBookInfo.Controls.Add(this.lblDateDue);
            this.gbBookInfo.Controls.Add(this.lblDateIssue);
            this.gbBookInfo.Controls.Add(this.lblBookID);
            this.gbBookInfo.Controls.Add(this.txtbBookID);
            this.gbBookInfo.Controls.Add(this.btnSearchRFID);
            this.gbBookInfo.Controls.Add(this.lblRFID);
            this.gbBookInfo.Controls.Add(this.lblBookTitle);
            this.gbBookInfo.Controls.Add(this.txtbRFID);
            this.gbBookInfo.Controls.Add(this.txtbBookTitle);
            this.gbBookInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookInfo.Location = new System.Drawing.Point(24, 87);
            this.gbBookInfo.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.gbBookInfo.Name = "gbBookInfo";
            this.gbBookInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbBookInfo.Size = new System.Drawing.Size(342, 419);
            this.gbBookInfo.TabIndex = 26;
            this.gbBookInfo.TabStop = false;
            this.gbBookInfo.Text = "Book Information";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(34, 362);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(275, 29);
            this.dtpDueDate.TabIndex = 21;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpIssueDate.Enabled = false;
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(34, 285);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(275, 29);
            this.dtpIssueDate.TabIndex = 18;
            // 
            // lblDateDue
            // 
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.BackColor = System.Drawing.Color.Transparent;
            this.lblDateDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDue.Location = new System.Drawing.Point(30, 334);
            this.lblDateDue.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(77, 21);
            this.lblDateDue.TabIndex = 20;
            this.lblDateDue.Text = "Due Date:";
            // 
            // lblDateIssue
            // 
            this.lblDateIssue.AutoSize = true;
            this.lblDateIssue.BackColor = System.Drawing.Color.Transparent;
            this.lblDateIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIssue.Location = new System.Drawing.Point(30, 257);
            this.lblDateIssue.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblDateIssue.Name = "lblDateIssue";
            this.lblDateIssue.Size = new System.Drawing.Size(84, 21);
            this.lblDateIssue.TabIndex = 19;
            this.lblDateIssue.Text = "Issue Date:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.Transparent;
            this.lblBookID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(30, 182);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(67, 21);
            this.lblBookID.TabIndex = 18;
            this.lblBookID.Text = "Book ID:";
            // 
            // txtbBookID
            // 
            this.txtbBookID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBookID.Location = new System.Drawing.Point(34, 210);
            this.txtbBookID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbBookID.Name = "txtbBookID";
            this.txtbBookID.ReadOnly = true;
            this.txtbBookID.Size = new System.Drawing.Size(275, 29);
            this.txtbBookID.TabIndex = 8;
            // 
            // btnSearchRFID
            // 
            this.btnSearchRFID.BackColor = System.Drawing.Color.White;
            this.btnSearchRFID.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnSearchRFID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearchRFID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSearchRFID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRFID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRFID.ForeColor = System.Drawing.Color.Black;
            this.btnSearchRFID.Location = new System.Drawing.Point(281, 60);
            this.btnSearchRFID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSearchRFID.Name = "btnSearchRFID";
            this.btnSearchRFID.Size = new System.Drawing.Size(28, 26);
            this.btnSearchRFID.TabIndex = 6;
            this.btnSearchRFID.Text = "...";
            this.btnSearchRFID.UseVisualStyleBackColor = false;
            this.btnSearchRFID.Click += new System.EventHandler(this.btnSearchRFID_Click);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.BackColor = System.Drawing.Color.Transparent;
            this.lblRFID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.Location = new System.Drawing.Point(30, 34);
            this.lblRFID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(46, 21);
            this.lblRFID.TabIndex = 15;
            this.lblRFID.Text = "RFID:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(30, 106);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(81, 21);
            this.lblBookTitle.TabIndex = 16;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // txtbRFID
            // 
            this.txtbRFID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRFID.Location = new System.Drawing.Point(34, 60);
            this.txtbRFID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbRFID.Name = "txtbRFID";
            this.txtbRFID.Size = new System.Drawing.Size(230, 29);
            this.txtbRFID.TabIndex = 1;
            this.txtbRFID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbRFID_KeyDown);
            this.txtbRFID.Validating += new System.ComponentModel.CancelEventHandler(this.txtbRFID_Validating);
            // 
            // txtbBookTitle
            // 
            this.txtbBookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBookTitle.Location = new System.Drawing.Point(34, 133);
            this.txtbBookTitle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbBookTitle.Name = "txtbBookTitle";
            this.txtbBookTitle.ReadOnly = true;
            this.txtbBookTitle.Size = new System.Drawing.Size(275, 29);
            this.txtbBookTitle.TabIndex = 7;
            // 
            // gpBorrowerInfo
            // 
            this.gpBorrowerInfo.BackColor = System.Drawing.Color.Transparent;
            this.gpBorrowerInfo.Controls.Add(this.txtbFaculty);
            this.gpBorrowerInfo.Controls.Add(this.txtbMemberType);
            this.gpBorrowerInfo.Controls.Add(this.lblFacultyName);
            this.gpBorrowerInfo.Controls.Add(this.lblMemberType);
            this.gpBorrowerInfo.Controls.Add(this.lblSchoolID);
            this.gpBorrowerInfo.Controls.Add(this.txtbSchoolID);
            this.gpBorrowerInfo.Controls.Add(this.lblMemberID);
            this.gpBorrowerInfo.Controls.Add(this.lblMemberName);
            this.gpBorrowerInfo.Controls.Add(this.txtbMemberID);
            this.gpBorrowerInfo.Controls.Add(this.txtbMemberName);
            this.gpBorrowerInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBorrowerInfo.Location = new System.Drawing.Point(392, 87);
            this.gpBorrowerInfo.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.gpBorrowerInfo.Name = "gpBorrowerInfo";
            this.gpBorrowerInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gpBorrowerInfo.Size = new System.Drawing.Size(342, 419);
            this.gpBorrowerInfo.TabIndex = 27;
            this.gpBorrowerInfo.TabStop = false;
            this.gpBorrowerInfo.Text = "Borrower Information";
            // 
            // txtbFaculty
            // 
            this.txtbFaculty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFaculty.Location = new System.Drawing.Point(34, 362);
            this.txtbFaculty.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbFaculty.Name = "txtbFaculty";
            this.txtbFaculty.ReadOnly = true;
            this.txtbFaculty.Size = new System.Drawing.Size(275, 29);
            this.txtbFaculty.TabIndex = 13;
            // 
            // txtbMemberType
            // 
            this.txtbMemberType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMemberType.Location = new System.Drawing.Point(34, 285);
            this.txtbMemberType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbMemberType.Name = "txtbMemberType";
            this.txtbMemberType.ReadOnly = true;
            this.txtbMemberType.Size = new System.Drawing.Size(275, 29);
            this.txtbMemberType.TabIndex = 12;
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.BackColor = System.Drawing.Color.Transparent;
            this.lblFacultyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyName.Location = new System.Drawing.Point(30, 334);
            this.lblFacultyName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(107, 21);
            this.lblFacultyName.TabIndex = 20;
            this.lblFacultyName.Text = "Faculty Name:";
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberType.Location = new System.Drawing.Point(30, 257);
            this.lblMemberType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(108, 21);
            this.lblMemberType.TabIndex = 19;
            this.lblMemberType.Text = "Member Type:";
            // 
            // lblSchoolID
            // 
            this.lblSchoolID.AutoSize = true;
            this.lblSchoolID.BackColor = System.Drawing.Color.Transparent;
            this.lblSchoolID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolID.Location = new System.Drawing.Point(30, 182);
            this.lblSchoolID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblSchoolID.Name = "lblSchoolID";
            this.lblSchoolID.Size = new System.Drawing.Size(76, 21);
            this.lblSchoolID.TabIndex = 18;
            this.lblSchoolID.Text = "School ID";
            // 
            // txtbSchoolID
            // 
            this.txtbSchoolID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSchoolID.Location = new System.Drawing.Point(34, 210);
            this.txtbSchoolID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbSchoolID.Name = "txtbSchoolID";
            this.txtbSchoolID.ReadOnly = true;
            this.txtbSchoolID.Size = new System.Drawing.Size(275, 29);
            this.txtbSchoolID.TabIndex = 11;
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
            this.lblMemberName.Location = new System.Drawing.Point(30, 106);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(118, 21);
            this.lblMemberName.TabIndex = 16;
            this.lblMemberName.Text = "Member Name:";
            // 
            // txtbMemberID
            // 
            this.txtbMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMemberID.Location = new System.Drawing.Point(34, 60);
            this.txtbMemberID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbMemberID.Name = "txtbMemberID";
            this.txtbMemberID.ReadOnly = true;
            this.txtbMemberID.Size = new System.Drawing.Size(275, 29);
            this.txtbMemberID.TabIndex = 9;
            // 
            // txtbMemberName
            // 
            this.txtbMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMemberName.Location = new System.Drawing.Point(34, 133);
            this.txtbMemberName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbMemberName.Name = "txtbMemberName";
            this.txtbMemberName.ReadOnly = true;
            this.txtbMemberName.Size = new System.Drawing.Size(275, 29);
            this.txtbMemberName.TabIndex = 10;
            // 
            // errorProviderForRFID
            // 
            this.errorProviderForRFID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderForRFID.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1141, 26);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(244, 21);
            this.toolStripStatusLabel1.Text = "Input an RFID or Press ESC to exit.";
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(1141, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gpBorrowerInfo);
            this.Controls.Add(this.gbBookInfo);
            this.Controls.Add(this.gbReturnTransaction);
            this.Name = "ReturnForm";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.gbReturnTransaction, 0);
            this.Controls.SetChildIndex(this.gbBookInfo, 0);
            this.Controls.SetChildIndex(this.gpBorrowerInfo, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.gbReturnTransaction.ResumeLayout(false);
            this.gbReturnTransaction.PerformLayout();
            this.gbBookInfo.ResumeLayout(false);
            this.gbBookInfo.PerformLayout();
            this.gpBorrowerInfo.ResumeLayout(false);
            this.gpBorrowerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForRFID)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReturnTransaction;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtbRemarks;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.GroupBox gbBookInfo;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.Label lblDateIssue;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtbBookID;
        private System.Windows.Forms.Button btnSearchRFID;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtbRFID;
        private System.Windows.Forms.TextBox txtbBookTitle;
        private System.Windows.Forms.GroupBox gpBorrowerInfo;
        private System.Windows.Forms.TextBox txtbFaculty;
        private System.Windows.Forms.TextBox txtbMemberType;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label lblSchoolID;
        private System.Windows.Forms.TextBox txtbSchoolID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtbMemberID;
        private System.Windows.Forms.TextBox txtbMemberName;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtbFine;
        private System.Windows.Forms.ErrorProvider errorProviderForRFID;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
