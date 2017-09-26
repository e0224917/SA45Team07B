namespace SA45Team07B
{
    partial class AddNewMember
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
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
            this.labelMemberID = new System.Windows.Forms.Label();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.labelMemberType = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelSchoolID = new System.Windows.Forms.Label();
            this.labelFacultyCode = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProviderMemberName = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxMemberType = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxSchoolID = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFacultyName = new System.Windows.Forms.ComboBox();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSchoolID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContactNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchoolID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 1342);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Visible = false;
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.Location = new System.Drawing.Point(429, 183);
            this.textBoxMemberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.ReadOnly = true;
            this.textBoxMemberID.Size = new System.Drawing.Size(344, 55);
            this.textBoxMemberID.TabIndex = 10;
            // 
            // labelMemberID
            // 
            this.labelMemberID.AutoSize = true;
            this.labelMemberID.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMemberID.Location = new System.Drawing.Point(180, 190);
            this.labelMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemberID.Name = "labelMemberID";
            this.labelMemberID.Size = new System.Drawing.Size(208, 48);
            this.labelMemberID.TabIndex = 11;
            this.labelMemberID.Text = "Member ID:";
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberName.Location = new System.Drawing.Point(200, 341);
            this.labelMemberName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(268, 48);
            this.labelMemberName.TabIndex = 14;
            this.labelMemberName.Text = "Member Name:";
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(651, 334);
            this.textBoxMemberName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(542, 55);
            this.textBoxMemberName.TabIndex = 12;
            this.textBoxMemberName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMemberName_Validating);
            this.textBoxMemberName.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // labelMemberType
            // 
            this.labelMemberType.AutoSize = true;
            this.labelMemberType.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberType.Location = new System.Drawing.Point(273, 400);
            this.labelMemberType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemberType.Name = "labelMemberType";
            this.labelMemberType.Size = new System.Drawing.Size(247, 48);
            this.labelMemberType.TabIndex = 17;
            this.labelMemberType.Text = "Member Type:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Location = new System.Drawing.Point(236, 786);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(105, 48);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(796, 427);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 48);
            this.label8.TabIndex = 22;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelContactNumber.Location = new System.Drawing.Point(124, 651);
            this.labelContactNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(291, 48);
            this.labelContactNumber.TabIndex = 23;
            this.labelContactNumber.Text = "Contact Number:";
            // 
            // labelSchoolID
            // 
            this.labelSchoolID.AutoSize = true;
            this.labelSchoolID.BackColor = System.Drawing.Color.Transparent;
            this.labelSchoolID.Location = new System.Drawing.Point(200, 258);
            this.labelSchoolID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSchoolID.Name = "labelSchoolID";
            this.labelSchoolID.Size = new System.Drawing.Size(180, 48);
            this.labelSchoolID.TabIndex = 24;
            this.labelSchoolID.Text = "School ID:";
            // 
            // labelFacultyCode
            // 
            this.labelFacultyCode.AutoSize = true;
            this.labelFacultyCode.BackColor = System.Drawing.Color.Transparent;
            this.labelFacultyCode.Location = new System.Drawing.Point(89, 526);
            this.labelFacultyCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFacultyCode.Name = "labelFacultyCode";
            this.labelFacultyCode.Size = new System.Drawing.Size(243, 48);
            this.labelFacultyCode.TabIndex = 25;
            this.labelFacultyCode.Text = "Faculty Name:";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(444, 670);
            this.textBoxContactNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(542, 55);
            this.textBoxContactNumber.TabIndex = 15;
            this.textBoxContactNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxContactNumber_Validating);
            this.textBoxContactNumber.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(389, 779);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(875, 55);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(449, 965);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(327, 142);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(889, 965);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(327, 142);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1916, 42);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(382, 37);
            this.toolStripStatusLabel1.Text = "Welcome to our library system.";
            // 
            // errorProviderMemberName
            // 
            this.errorProviderMemberName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMemberName.ContainerControl = this;
            // 
            // comboBoxMemberType
            // 
            this.comboBoxMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMemberType.FormattingEnabled = true;
            this.comboBoxMemberType.Items.AddRange(new object[] {
            "Undergraduate Student",
            "Graduate Student",
            "Academic Staff",
            "Admin Staff"});
            this.comboBoxMemberType.Location = new System.Drawing.Point(656, 421);
            this.comboBoxMemberType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMemberType.Name = "comboBoxMemberType";
            this.comboBoxMemberType.Size = new System.Drawing.Size(537, 56);
            this.comboBoxMemberType.TabIndex = 13;
            // 
            // maskedTextBoxSchoolID
            // 
            this.maskedTextBoxSchoolID.Location = new System.Drawing.Point(438, 258);
            this.maskedTextBoxSchoolID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBoxSchoolID.Mask = "A00000000";
            this.maskedTextBoxSchoolID.Name = "maskedTextBoxSchoolID";
            this.maskedTextBoxSchoolID.Size = new System.Drawing.Size(502, 55);
            this.maskedTextBoxSchoolID.TabIndex = 11;
            this.maskedTextBoxSchoolID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBoxSchoolID.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxSchoolID_Validating);
            this.maskedTextBoxSchoolID.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // comboBoxFacultyName
            // 
            this.comboBoxFacultyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultyName.FormattingEnabled = true;
            this.comboBoxFacultyName.Items.AddRange(new object[] {
            "Arts and Social Sciences",
            "Business and Accountancy",
            "Computing",
            "Engineering",
            "Law",
            "Medicine",
            "Science",
            "Systems Science"});
            this.comboBoxFacultyName.Location = new System.Drawing.Point(449, 526);
            this.comboBoxFacultyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFacultyName.Name = "comboBoxFacultyName";
            this.comboBoxFacultyName.Size = new System.Drawing.Size(413, 56);
            this.comboBoxFacultyName.TabIndex = 14;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderSchoolID
            // 
            this.errorProviderSchoolID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSchoolID.ContainerControl = this;
            // 
            // errorProviderContactNumber
            // 
            this.errorProviderContactNumber.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderContactNumber.ContainerControl = this;
            // 
            // AddNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.ClientSize = new System.Drawing.Size(1916, 1392);
            this.Controls.Add(this.comboBoxFacultyName);
            this.Controls.Add(this.maskedTextBoxSchoolID);
            this.Controls.Add(this.comboBoxMemberType);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxContactNumber);
            this.Controls.Add(this.labelFacultyCode);
            this.Controls.Add(this.labelSchoolID);
            this.Controls.Add(this.labelContactNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelMemberType);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.labelMemberName);
            this.Controls.Add(this.labelMemberID);
            this.Controls.Add(this.textBoxMemberID);
            this.Name = "AddNewMember";
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.AddNewMember_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxMemberID, 0);
            this.Controls.SetChildIndex(this.labelMemberID, 0);
            this.Controls.SetChildIndex(this.labelMemberName, 0);
            this.Controls.SetChildIndex(this.textBoxMemberName, 0);
            this.Controls.SetChildIndex(this.labelMemberType, 0);
            this.Controls.SetChildIndex(this.labelEmail, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.labelContactNumber, 0);
            this.Controls.SetChildIndex(this.labelSchoolID, 0);
            this.Controls.SetChildIndex(this.labelFacultyCode, 0);
            this.Controls.SetChildIndex(this.textBoxContactNumber, 0);
            this.Controls.SetChildIndex(this.textBoxEmail, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.comboBoxMemberType, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxSchoolID, 0);
            this.Controls.SetChildIndex(this.comboBoxFacultyName, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchoolID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.Label labelMemberID;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Label labelMemberType;
        private System.Windows.Forms.Label labelFacultyCode;
        private System.Windows.Forms.Label labelSchoolID;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProviderMemberName;
        private System.Windows.Forms.ComboBox comboBoxMemberType;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSchoolID;
        private System.Windows.Forms.ComboBox comboBoxFacultyName;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderSchoolID;
        private System.Windows.Forms.ErrorProvider errorProviderContactNumber;
    }
}
