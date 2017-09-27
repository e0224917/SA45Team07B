namespace SA45Team07B
{
    partial class ModifyMember
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
            this.labelMemberName = new System.Windows.Forms.Label();
            this.labelSchoolID = new System.Windows.Forms.Label();
            this.labelMemberType = new System.Windows.Forms.Label();
            this.labelFacultyName = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.maskedTextBoxSchoolID = new System.Windows.Forms.MaskedTextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.comboBoxMemberType = new System.Windows.Forms.ComboBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxFacultyName = new System.Windows.Forms.ComboBox();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.errorProviderMemberName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContactNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderSchoolID = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchoolID)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 912);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Visible = false;
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberName.Location = new System.Drawing.Point(40, 277);
            this.labelMemberName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(268, 48);
            this.labelMemberName.TabIndex = 11;
            this.labelMemberName.Text = "Member Name:";
            // 
            // labelSchoolID
            // 
            this.labelSchoolID.AutoSize = true;
            this.labelSchoolID.BackColor = System.Drawing.Color.Transparent;
            this.labelSchoolID.Location = new System.Drawing.Point(40, 199);
            this.labelSchoolID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSchoolID.Name = "labelSchoolID";
            this.labelSchoolID.Size = new System.Drawing.Size(180, 48);
            this.labelSchoolID.TabIndex = 12;
            this.labelSchoolID.Text = "School ID:";
            // 
            // labelMemberType
            // 
            this.labelMemberType.AutoSize = true;
            this.labelMemberType.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberType.Location = new System.Drawing.Point(40, 351);
            this.labelMemberType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemberType.Name = "labelMemberType";
            this.labelMemberType.Size = new System.Drawing.Size(247, 48);
            this.labelMemberType.TabIndex = 13;
            this.labelMemberType.Text = "Member Type:";
            // 
            // labelFacultyName
            // 
            this.labelFacultyName.AutoSize = true;
            this.labelFacultyName.BackColor = System.Drawing.Color.Transparent;
            this.labelFacultyName.Location = new System.Drawing.Point(40, 424);
            this.labelFacultyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFacultyName.Name = "labelFacultyName";
            this.labelFacultyName.Size = new System.Drawing.Size(243, 48);
            this.labelFacultyName.TabIndex = 14;
            this.labelFacultyName.Text = "Faculty Name:";
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelContactNumber.Location = new System.Drawing.Point(40, 501);
            this.labelContactNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(291, 48);
            this.labelContactNumber.TabIndex = 15;
            this.labelContactNumber.Text = "Contact Number:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Location = new System.Drawing.Point(40, 574);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(113, 48);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email:";
            // 
            // maskedTextBoxSchoolID
            // 
            this.maskedTextBoxSchoolID.Location = new System.Drawing.Point(356, 192);
            this.maskedTextBoxSchoolID.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxSchoolID.Mask = "A00000000";
            this.maskedTextBoxSchoolID.Name = "maskedTextBoxSchoolID";
            this.maskedTextBoxSchoolID.ReadOnly = true;
            this.maskedTextBoxSchoolID.Size = new System.Drawing.Size(400, 55);
            this.maskedTextBoxSchoolID.TabIndex = 17;
            this.maskedTextBoxSchoolID.TextChanged += new System.EventHandler(this.textBoxes_Validated);
            this.maskedTextBoxSchoolID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.maskedTextBoxSchoolID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.maskedTextBoxSchoolID.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxSchoolID_Validating);
            // 
            // buttonFind
            // 
            this.buttonFind.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Location = new System.Drawing.Point(775, 192);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(7);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(91, 55);
            this.buttonFind.TabIndex = 18;
            this.buttonFind.Text = "...";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            this.buttonFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.buttonFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(356, 270);
            this.textBoxMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(800, 55);
            this.textBoxMemberName.TabIndex = 19;
            this.textBoxMemberName.TextChanged += new System.EventHandler(this.textBoxes_Validated);
            this.textBoxMemberName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxMemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxMemberName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMemberName_Validating);
            // 
            // comboBoxMemberType
            // 
            this.comboBoxMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMemberType.FormattingEnabled = true;
            this.comboBoxMemberType.Location = new System.Drawing.Point(356, 343);
            this.comboBoxMemberType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMemberType.Name = "comboBoxMemberType";
            this.comboBoxMemberType.Size = new System.Drawing.Size(800, 56);
            this.comboBoxMemberType.TabIndex = 20;
            this.comboBoxMemberType.TextChanged += new System.EventHandler(this.textBoxes_Validated);
            this.comboBoxMemberType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.comboBoxMemberType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.White;
            this.buttonSaveChanges.Enabled = false;
            this.buttonSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChanges.Location = new System.Drawing.Point(356, 661);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(262, 91);
            this.buttonSaveChanges.TabIndex = 24;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(656, 661);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(262, 91);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxFacultyName
            // 
            this.comboBoxFacultyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultyName.FormattingEnabled = true;
            this.comboBoxFacultyName.Location = new System.Drawing.Point(356, 416);
            this.comboBoxFacultyName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFacultyName.Name = "comboBoxFacultyName";
            this.comboBoxFacultyName.Size = new System.Drawing.Size(800, 56);
            this.comboBoxFacultyName.TabIndex = 21;
            this.comboBoxFacultyName.TextChanged += new System.EventHandler(this.textBoxes_Validated);
            this.comboBoxFacultyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.comboBoxFacultyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(356, 494);
            this.textBoxContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(800, 55);
            this.textBoxContactNumber.TabIndex = 22;
            this.textBoxContactNumber.TextChanged += new System.EventHandler(this.textBoxes_Validated);
            this.textBoxContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxContactNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxContactNumber_Validating);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(356, 567);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(800, 55);
            this.textBoxEmail.TabIndex = 23;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxes_Validated);
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // errorProviderMemberName
            // 
            this.errorProviderMemberName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMemberName.ContainerControl = this;
            // 
            // errorProviderContactNumber
            // 
            this.errorProviderContactNumber.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderContactNumber.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmail.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(215, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(302, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(282, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(277, 424);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(146, 574);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = "*";
            // 
            // errorProviderSchoolID
            // 
            this.errorProviderSchoolID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSchoolID.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 843);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1917, 53);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(480, 48);
            this.toolStripStatusLabel1.Text = "Modify Member Information.";
            // 
            // ModifyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1917, 896);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxContactNumber);
            this.Controls.Add(this.comboBoxFacultyName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.comboBoxMemberType);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.maskedTextBoxSchoolID);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelContactNumber);
            this.Controls.Add(this.labelFacultyName);
            this.Controls.Add(this.labelMemberType);
            this.Controls.Add(this.labelSchoolID);
            this.Controls.Add(this.labelMemberName);
            this.Name = "ModifyMember";
            this.Text = "Modify Member Information";
            this.Load += new System.EventHandler(this.ModifyMember_Load);
            this.Controls.SetChildIndex(this.labelMemberName, 0);
            this.Controls.SetChildIndex(this.labelSchoolID, 0);
            this.Controls.SetChildIndex(this.labelMemberType, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelFacultyName, 0);
            this.Controls.SetChildIndex(this.labelContactNumber, 0);
            this.Controls.SetChildIndex(this.labelEmail, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxSchoolID, 0);
            this.Controls.SetChildIndex(this.buttonFind, 0);
            this.Controls.SetChildIndex(this.textBoxMemberName, 0);
            this.Controls.SetChildIndex(this.comboBoxMemberType, 0);
            this.Controls.SetChildIndex(this.buttonSaveChanges, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.comboBoxFacultyName, 0);
            this.Controls.SetChildIndex(this.textBoxContactNumber, 0);
            this.Controls.SetChildIndex(this.textBoxEmail, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchoolID)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.Label labelSchoolID;
        private System.Windows.Forms.Label labelMemberType;
        private System.Windows.Forms.Label labelFacultyName;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSchoolID;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.ComboBox comboBoxMemberType;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxFacultyName;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ErrorProvider errorProviderMemberName;
        private System.Windows.Forms.ErrorProvider errorProviderContactNumber;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderSchoolID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
