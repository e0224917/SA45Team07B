namespace SA45Team07B
{
    partial class BorrowForm
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
            this.lblMemberID = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMoreMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbBookStatus = new System.Windows.Forms.TextBox();
            this.lblBookStatus = new System.Windows.Forms.Label();
            this.txtbBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.btnMoreBook = new System.Windows.Forms.Button();
            this.txtbRFID = new System.Windows.Forms.TextBox();
            this.lblRFID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEntitlementDay = new System.Windows.Forms.Label();
            this.txtbEntitlement = new System.Windows.Forms.NumericUpDown();
            this.lblEntitlement = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtbStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtbMaxBorrowed = new System.Windows.Forms.TextBox();
            this.txtbTotalBorrowed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbMemberID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtbFaculty = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPeriodDay = new System.Windows.Forms.Label();
            this.txtbPeriod = new System.Windows.Forms.NumericUpDown();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.lblDateIssued = new System.Windows.Forms.Label();
            this.dpDateDue = new System.Windows.Forms.DateTimePicker();
            this.dpDateIssued = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbEntitlement)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbPeriod)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Visible = false;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(13, 119);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(208, 48);
            this.lblMemberID.TabIndex = 10;
            this.lblMemberID.Text = "Member ID:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(184, 709);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 69);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMoreMember
            // 
            this.btnMoreMember.BackColor = System.Drawing.Color.White;
            this.btnMoreMember.CausesValidation = false;
            this.btnMoreMember.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnMoreMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMoreMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreMember.Location = new System.Drawing.Point(442, 112);
            this.btnMoreMember.Margin = new System.Windows.Forms.Padding(7);
            this.btnMoreMember.Name = "btnMoreMember";
            this.btnMoreMember.Size = new System.Drawing.Size(64, 66);
            this.btnMoreMember.TabIndex = 16;
            this.btnMoreMember.Text = "...";
            this.btnMoreMember.UseVisualStyleBackColor = false;
            this.btnMoreMember.Click += new System.EventHandler(this.btnMoreMember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtbBookStatus);
            this.groupBox1.Controls.Add(this.lblBookStatus);
            this.groupBox1.Controls.Add(this.txtbBookTitle);
            this.groupBox1.Controls.Add(this.lblBookTitle);
            this.groupBox1.Controls.Add(this.btnMoreBook);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtbRFID);
            this.groupBox1.Controls.Add(this.lblRFID);
            this.groupBox1.Location = new System.Drawing.Point(1260, 208);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(538, 821);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // txtbBookStatus
            // 
            this.txtbBookStatus.Location = new System.Drawing.Point(13, 450);
            this.txtbBookStatus.Margin = new System.Windows.Forms.Padding(7);
            this.txtbBookStatus.Name = "txtbBookStatus";
            this.txtbBookStatus.ReadOnly = true;
            this.txtbBookStatus.Size = new System.Drawing.Size(195, 55);
            this.txtbBookStatus.TabIndex = 30;
            this.txtbBookStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBookStatus
            // 
            this.lblBookStatus.AutoSize = true;
            this.lblBookStatus.Location = new System.Drawing.Point(13, 395);
            this.lblBookStatus.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBookStatus.Name = "lblBookStatus";
            this.lblBookStatus.Size = new System.Drawing.Size(207, 48);
            this.lblBookStatus.TabIndex = 17;
            this.lblBookStatus.Text = "Availablility:";
            // 
            // txtbBookTitle
            // 
            this.txtbBookTitle.Location = new System.Drawing.Point(13, 295);
            this.txtbBookTitle.Margin = new System.Windows.Forms.Padding(7);
            this.txtbBookTitle.Name = "txtbBookTitle";
            this.txtbBookTitle.ReadOnly = true;
            this.txtbBookTitle.Size = new System.Drawing.Size(506, 55);
            this.txtbBookTitle.TabIndex = 29;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(13, 240);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(187, 48);
            this.lblBookTitle.TabIndex = 15;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // btnMoreBook
            // 
            this.btnMoreBook.BackColor = System.Drawing.Color.White;
            this.btnMoreBook.CausesValidation = false;
            this.btnMoreBook.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnMoreBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMoreBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreBook.Location = new System.Drawing.Point(460, 112);
            this.btnMoreBook.Margin = new System.Windows.Forms.Padding(7);
            this.btnMoreBook.Name = "btnMoreBook";
            this.btnMoreBook.Size = new System.Drawing.Size(64, 66);
            this.btnMoreBook.TabIndex = 28;
            this.btnMoreBook.Text = "...";
            this.btnMoreBook.UseVisualStyleBackColor = false;
            this.btnMoreBook.Click += new System.EventHandler(this.btnMoreBook_Click);
            // 
            // txtbRFID
            // 
            this.txtbRFID.Location = new System.Drawing.Point(122, 112);
            this.txtbRFID.Margin = new System.Windows.Forms.Padding(7);
            this.txtbRFID.MaxLength = 10;
            this.txtbRFID.Name = "txtbRFID";
            this.txtbRFID.Size = new System.Drawing.Size(324, 55);
            this.txtbRFID.TabIndex = 27;
            this.txtbRFID.TextChanged += new System.EventHandler(this.txtbRFID_TextChanged);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(13, 119);
            this.lblRFID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(103, 48);
            this.lblRFID.TabIndex = 0;
            this.lblRFID.Text = "RFID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblEntitlementDay);
            this.groupBox2.Controls.Add(this.txtbEntitlement);
            this.groupBox2.Controls.Add(this.lblEntitlement);
            this.groupBox2.Controls.Add(this.lblSlash);
            this.groupBox2.Controls.Add(this.txtbStatus);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.txtbMaxBorrowed);
            this.groupBox2.Controls.Add(this.txtbTotalBorrowed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(651, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox2.Size = new System.Drawing.Size(538, 329);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrowing Information";
            // 
            // lblEntitlementDay
            // 
            this.lblEntitlementDay.AutoSize = true;
            this.lblEntitlementDay.Location = new System.Drawing.Point(378, 240);
            this.lblEntitlementDay.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEntitlementDay.Name = "lblEntitlementDay";
            this.lblEntitlementDay.Size = new System.Drawing.Size(95, 48);
            this.lblEntitlementDay.TabIndex = 7;
            this.lblEntitlementDay.Text = "Days";
            // 
            // txtbEntitlement
            // 
            this.txtbEntitlement.Location = new System.Drawing.Point(271, 235);
            this.txtbEntitlement.Margin = new System.Windows.Forms.Padding(7);
            this.txtbEntitlement.Name = "txtbEntitlement";
            this.txtbEntitlement.ReadOnly = true;
            this.txtbEntitlement.Size = new System.Drawing.Size(93, 55);
            this.txtbEntitlement.TabIndex = 23;
            this.txtbEntitlement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEntitlement
            // 
            this.lblEntitlement.AutoSize = true;
            this.lblEntitlement.Location = new System.Drawing.Point(34, 237);
            this.lblEntitlement.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEntitlement.Name = "lblEntitlement";
            this.lblEntitlement.Size = new System.Drawing.Size(209, 48);
            this.lblEntitlement.TabIndex = 7;
            this.lblEntitlement.Text = "Entitlement:";
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Location = new System.Drawing.Point(358, 57);
            this.lblSlash.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(34, 48);
            this.lblSlash.TabIndex = 6;
            this.lblSlash.Text = "/";
            // 
            // txtbStatus
            // 
            this.txtbStatus.Location = new System.Drawing.Point(271, 144);
            this.txtbStatus.Margin = new System.Windows.Forms.Padding(7);
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.ReadOnly = true;
            this.txtbStatus.Size = new System.Drawing.Size(195, 55);
            this.txtbStatus.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(120, 151);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(123, 48);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // txtbMaxBorrowed
            // 
            this.txtbMaxBorrowed.Location = new System.Drawing.Point(407, 50);
            this.txtbMaxBorrowed.Margin = new System.Windows.Forms.Padding(7);
            this.txtbMaxBorrowed.Name = "txtbMaxBorrowed";
            this.txtbMaxBorrowed.ReadOnly = true;
            this.txtbMaxBorrowed.Size = new System.Drawing.Size(60, 55);
            this.txtbMaxBorrowed.TabIndex = 21;
            this.txtbMaxBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbTotalBorrowed
            // 
            this.txtbTotalBorrowed.Location = new System.Drawing.Point(271, 50);
            this.txtbTotalBorrowed.Margin = new System.Windows.Forms.Padding(7);
            this.txtbTotalBorrowed.Name = "txtbTotalBorrowed";
            this.txtbTotalBorrowed.ReadOnly = true;
            this.txtbTotalBorrowed.Size = new System.Drawing.Size(60, 55);
            this.txtbTotalBorrowed.TabIndex = 20;
            this.txtbTotalBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Borrowed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(13, 295);
            this.txtbName.Margin = new System.Windows.Forms.Padding(7);
            this.txtbName.Name = "txtbName";
            this.txtbName.ReadOnly = true;
            this.txtbName.Size = new System.Drawing.Size(506, 55);
            this.txtbName.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtbMemberID);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.txtbFaculty);
            this.groupBox3.Controls.Add(this.lblMemberID);
            this.groupBox3.Controls.Add(this.lblFaculty);
            this.groupBox3.Controls.Add(this.txtbName);
            this.groupBox3.Controls.Add(this.btnMoreMember);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(49, 208);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox3.Size = new System.Drawing.Size(538, 821);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Member Information";
            // 
            // txtbMemberID
            // 
            this.txtbMemberID.Location = new System.Drawing.Point(218, 112);
            this.txtbMemberID.Margin = new System.Windows.Forms.Padding(7);
            this.txtbMemberID.MaxLength = 5;
            this.txtbMemberID.Name = "txtbMemberID";
            this.txtbMemberID.Size = new System.Drawing.Size(210, 55);
            this.txtbMemberID.TabIndex = 15;
            this.txtbMemberID.TextChanged += new System.EventHandler(this.txtbMemberID_TextChanged);
            this.txtbMemberID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbMemberID_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(358, 709);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 69);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtbFaculty
            // 
            this.txtbFaculty.Location = new System.Drawing.Point(13, 432);
            this.txtbFaculty.Margin = new System.Windows.Forms.Padding(7);
            this.txtbFaculty.Name = "txtbFaculty";
            this.txtbFaculty.ReadOnly = true;
            this.txtbFaculty.Size = new System.Drawing.Size(506, 55);
            this.txtbFaculty.TabIndex = 18;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(13, 377);
            this.lblFaculty.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(138, 48);
            this.lblFaculty.TabIndex = 2;
            this.lblFaculty.Text = "Faculty:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lblPeriodDay);
            this.groupBox4.Controls.Add(this.txtbPeriod);
            this.groupBox4.Controls.Add(this.lblPeriod);
            this.groupBox4.Controls.Add(this.lblDateDue);
            this.groupBox4.Controls.Add(this.lblDateIssued);
            this.groupBox4.Controls.Add(this.dpDateDue);
            this.groupBox4.Controls.Add(this.dpDateIssued);
            this.groupBox4.Location = new System.Drawing.Point(651, 574);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox4.Size = new System.Drawing.Size(538, 455);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date Information";
            // 
            // lblPeriodDay
            // 
            this.lblPeriodDay.AutoSize = true;
            this.lblPeriodDay.Location = new System.Drawing.Point(257, 354);
            this.lblPeriodDay.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPeriodDay.Name = "lblPeriodDay";
            this.lblPeriodDay.Size = new System.Drawing.Size(95, 48);
            this.lblPeriodDay.TabIndex = 6;
            this.lblPeriodDay.Text = "Days";
            // 
            // txtbPeriod
            // 
            this.txtbPeriod.Location = new System.Drawing.Point(145, 352);
            this.txtbPeriod.Margin = new System.Windows.Forms.Padding(7);
            this.txtbPeriod.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtbPeriod.Name = "txtbPeriod";
            this.txtbPeriod.Size = new System.Drawing.Size(98, 55);
            this.txtbPeriod.TabIndex = 26;
            this.txtbPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbPeriod.ValueChanged += new System.EventHandler(this.txtbPeriod_ValueChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(13, 354);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(130, 48);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "Period:";
            // 
            // lblDateDue
            // 
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Location = new System.Drawing.Point(13, 187);
            this.lblDateDue.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(176, 48);
            this.lblDateDue.TabIndex = 3;
            this.lblDateDue.Text = "Due Date:";
            // 
            // lblDateIssued
            // 
            this.lblDateIssued.AutoSize = true;
            this.lblDateIssued.Location = new System.Drawing.Point(13, 57);
            this.lblDateIssued.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDateIssued.Name = "lblDateIssued";
            this.lblDateIssued.Size = new System.Drawing.Size(227, 48);
            this.lblDateIssued.TabIndex = 2;
            this.lblDateIssued.Text = "Borrow Date:";
            // 
            // dpDateDue
            // 
            this.dpDateDue.CustomFormat = "dd/MM/yyyy";
            this.dpDateDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDateDue.Location = new System.Drawing.Point(22, 247);
            this.dpDateDue.Margin = new System.Windows.Forms.Padding(7);
            this.dpDateDue.Name = "dpDateDue";
            this.dpDateDue.Size = new System.Drawing.Size(440, 55);
            this.dpDateDue.TabIndex = 25;
            this.dpDateDue.ValueChanged += new System.EventHandler(this.DateValueChanged);
            // 
            // dpDateIssued
            // 
            this.dpDateIssued.CustomFormat = "dd/MM/yyyy";
            this.dpDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDateIssued.Location = new System.Drawing.Point(22, 112);
            this.dpDateIssued.Margin = new System.Windows.Forms.Padding(7);
            this.dpDateIssued.Name = "dpDateIssued";
            this.dpDateIssued.Size = new System.Drawing.Size(440, 55);
            this.dpDateIssued.TabIndex = 24;
            this.dpDateIssued.Value = new System.DateTime(2017, 9, 26, 16, 52, 37, 0);
            this.dpDateIssued.ValueChanged += new System.EventHandler(this.DateValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1033);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1856, 53);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(710, 48);
            this.toolStripStatusLabel1.Text = "Input Member information to borrow book.";
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.ClientSize = new System.Drawing.Size(1856, 1086);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BorrowForm";
            this.Text = "Borrow Book";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbEntitlement)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbPeriod)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMoreMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Button btnMoreBook;
        private System.Windows.Forms.TextBox txtbRFID;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtbMaxBorrowed;
        private System.Windows.Forms.TextBox txtbTotalBorrowed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.TextBox txtbMemberID;
        private System.Windows.Forms.TextBox txtbBookStatus;
        private System.Windows.Forms.Label lblBookStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.Label lblDateIssued;
        private System.Windows.Forms.DateTimePicker dpDateDue;
        private System.Windows.Forms.DateTimePicker dpDateIssued;
        private System.Windows.Forms.Label lblEntitlementDay;
        private System.Windows.Forms.NumericUpDown txtbEntitlement;
        private System.Windows.Forms.Label lblEntitlement;
        private System.Windows.Forms.Label lblPeriodDay;
        private System.Windows.Forms.NumericUpDown txtbPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
