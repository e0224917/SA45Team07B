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
            this.errorProviderMemberName = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxMemberType = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxSchoolID = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFacultyName = new System.Windows.Forms.ComboBox();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSchoolID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContactNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderMemberType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFacultyName = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchoolID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacultyName)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.textBoxMemberID.Location = new System.Drawing.Point(400, 193);
            this.textBoxMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.ReadOnly = true;
            this.textBoxMemberID.Size = new System.Drawing.Size(800, 55);
            this.textBoxMemberID.TabIndex = 10;
            this.textBoxMemberID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            // 
            // labelMemberID
            // 
            this.labelMemberID.AutoSize = true;
            this.labelMemberID.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMemberID.Location = new System.Drawing.Point(71, 200);
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
            this.labelMemberName.Location = new System.Drawing.Point(71, 350);
            this.labelMemberName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(268, 48);
            this.labelMemberName.TabIndex = 14;
            this.labelMemberName.Text = "Member Name:";
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(400, 343);
            this.textBoxMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(800, 55);
            this.textBoxMemberName.TabIndex = 12;
            this.textBoxMemberName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxMemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxMemberName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMemberName_Validating);
            this.textBoxMemberName.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // labelMemberType
            // 
            this.labelMemberType.AutoSize = true;
            this.labelMemberType.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberType.Location = new System.Drawing.Point(71, 425);
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
            this.labelEmail.Location = new System.Drawing.Point(71, 650);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(113, 48);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email:";
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
            this.labelContactNumber.Location = new System.Drawing.Point(71, 575);
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
            this.labelSchoolID.Location = new System.Drawing.Point(71, 275);
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
            this.labelFacultyCode.Location = new System.Drawing.Point(71, 500);
            this.labelFacultyCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFacultyCode.Name = "labelFacultyCode";
            this.labelFacultyCode.Size = new System.Drawing.Size(243, 48);
            this.labelFacultyCode.TabIndex = 25;
            this.labelFacultyCode.Text = "Faculty Name:";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(400, 568);
            this.textBoxContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(800, 55);
            this.textBoxContactNumber.TabIndex = 15;
            this.textBoxContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxContactNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxContactNumber_Validating);
            this.textBoxContactNumber.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(400, 643);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(800, 55);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(400, 734);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(262, 91);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(700, 734);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(262, 91);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.comboBoxMemberType.Location = new System.Drawing.Point(400, 417);
            this.comboBoxMemberType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMemberType.Name = "comboBoxMemberType";
            this.comboBoxMemberType.Size = new System.Drawing.Size(800, 56);
            this.comboBoxMemberType.TabIndex = 13;
            this.comboBoxMemberType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.comboBoxMemberType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.comboBoxMemberType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxMemberType_Validating);
            // 
            // maskedTextBoxSchoolID
            // 
            this.maskedTextBoxSchoolID.Location = new System.Drawing.Point(400, 268);
            this.maskedTextBoxSchoolID.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxSchoolID.Mask = "000000000";
            this.maskedTextBoxSchoolID.Name = "maskedTextBoxSchoolID";
            this.maskedTextBoxSchoolID.Size = new System.Drawing.Size(800, 55);
            this.maskedTextBoxSchoolID.TabIndex = 11;
            this.maskedTextBoxSchoolID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBoxSchoolID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.maskedTextBoxSchoolID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
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
            this.comboBoxFacultyName.Location = new System.Drawing.Point(400, 492);
            this.comboBoxFacultyName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFacultyName.Name = "comboBoxFacultyName";
            this.comboBoxFacultyName.Size = new System.Drawing.Size(800, 56);
            this.comboBoxFacultyName.TabIndex = 14;
            this.comboBoxFacultyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.comboBoxFacultyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.comboBoxFacultyName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxFacultyName_Validating);
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(256, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(344, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "*";
            // 
            // labelStar
            // 
            this.labelStar.AutoSize = true;
            this.labelStar.BackColor = System.Drawing.Color.Transparent;
            this.labelStar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar.ForeColor = System.Drawing.Color.Red;
            this.labelStar.Location = new System.Drawing.Point(323, 425);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(25, 32);
            this.labelStar.TabIndex = 29;
            this.labelStar.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(319, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(189, 650);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = "*";
            // 
            // errorProviderMemberType
            // 
            this.errorProviderMemberType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMemberType.ContainerControl = this;
            // 
            // errorProviderFacultyName
            // 
            this.errorProviderFacultyName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFacultyName.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1068);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1472, 53);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(238, 48);
            this.toolStripStatusLabel1.Text = "Add Member.";
            // 
            // AddNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1472, 1121);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelStar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFacultyName);
            this.Controls.Add(this.maskedTextBoxSchoolID);
            this.Controls.Add(this.comboBoxMemberType);
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
            this.Controls.SetChildIndex(this.comboBoxMemberType, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxSchoolID, 0);
            this.Controls.SetChildIndex(this.comboBoxFacultyName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.labelStar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchoolID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacultyName)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ErrorProvider errorProviderMemberName;
        private System.Windows.Forms.ComboBox comboBoxMemberType;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSchoolID;
        private System.Windows.Forms.ComboBox comboBoxFacultyName;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderSchoolID;
        private System.Windows.Forms.ErrorProvider errorProviderContactNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderMemberType;
        private System.Windows.Forms.ErrorProvider errorProviderFacultyName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
