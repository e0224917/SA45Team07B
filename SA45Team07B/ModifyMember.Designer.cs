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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 913);
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberName.Location = new System.Drawing.Point(62, 276);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(268, 48);
            this.labelMemberName.TabIndex = 11;
            this.labelMemberName.Text = "Member Name:";
            // 
            // labelSchoolID
            // 
            this.labelSchoolID.AutoSize = true;
            this.labelSchoolID.BackColor = System.Drawing.Color.Transparent;
            this.labelSchoolID.Location = new System.Drawing.Point(150, 200);
            this.labelSchoolID.Name = "labelSchoolID";
            this.labelSchoolID.Size = new System.Drawing.Size(180, 48);
            this.labelSchoolID.TabIndex = 12;
            this.labelSchoolID.Text = "School ID:";
            // 
            // labelMemberType
            // 
            this.labelMemberType.AutoSize = true;
            this.labelMemberType.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberType.Location = new System.Drawing.Point(47, 342);
            this.labelMemberType.Name = "labelMemberType";
            this.labelMemberType.Size = new System.Drawing.Size(247, 48);
            this.labelMemberType.TabIndex = 13;
            this.labelMemberType.Text = "Member Type:";
            // 
            // labelFacultyName
            // 
            this.labelFacultyName.AutoSize = true;
            this.labelFacultyName.BackColor = System.Drawing.Color.Transparent;
            this.labelFacultyName.Location = new System.Drawing.Point(51, 431);
            this.labelFacultyName.Name = "labelFacultyName";
            this.labelFacultyName.Size = new System.Drawing.Size(243, 48);
            this.labelFacultyName.TabIndex = 14;
            this.labelFacultyName.Text = "Faculty Name:";
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelContactNumber.Location = new System.Drawing.Point(26, 509);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(301, 48);
            this.labelContactNumber.TabIndex = 15;
            this.labelContactNumber.Text = "Contact Number: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Location = new System.Drawing.Point(171, 631);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(123, 48);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email: ";
            // 
            // maskedTextBoxSchoolID
            // 
            this.maskedTextBoxSchoolID.Location = new System.Drawing.Point(351, 193);
            this.maskedTextBoxSchoolID.Mask = "A00000000";
            this.maskedTextBoxSchoolID.Name = "maskedTextBoxSchoolID";
            this.maskedTextBoxSchoolID.Size = new System.Drawing.Size(387, 55);
            this.maskedTextBoxSchoolID.TabIndex = 17;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(757, 190);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 58);
            this.buttonFind.TabIndex = 18;
            this.buttonFind.Text = "...";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(351, 269);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(386, 55);
            this.textBoxMemberName.TabIndex = 18;
            // 
            // comboBoxMemberType
            // 
            this.comboBoxMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMemberType.FormattingEnabled = true;
            this.comboBoxMemberType.Location = new System.Drawing.Point(353, 342);
            this.comboBoxMemberType.Name = "comboBoxMemberType";
            this.comboBoxMemberType.Size = new System.Drawing.Size(386, 56);
            this.comboBoxMemberType.TabIndex = 19;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.White;
            this.buttonSaveChanges.Enabled = false;
            this.buttonSaveChanges.Location = new System.Drawing.Point(353, 756);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(262, 91);
            this.buttonSaveChanges.TabIndex = 23;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(642, 756);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(262, 91);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
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
            this.comboBoxFacultyName.Location = new System.Drawing.Point(354, 423);
            this.comboBoxFacultyName.Name = "comboBoxFacultyName";
            this.comboBoxFacultyName.Size = new System.Drawing.Size(386, 56);
            this.comboBoxFacultyName.TabIndex = 20;
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(354, 531);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(399, 55);
            this.textBoxContactNumber.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(353, 631);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(519, 55);
            this.textBoxEmail.TabIndex = 22;
            // 
            // ModifyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.ClientSize = new System.Drawing.Size(1506, 978);
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
    }
}
