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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(6, 52);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(88, 21);
            this.lblMemberID.TabIndex = 10;
            this.lblMemberID.Text = "Member ID";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(83, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMoreMember
            // 
            this.btnMoreMember.CausesValidation = false;
            this.btnMoreMember.Location = new System.Drawing.Point(207, 49);
            this.btnMoreMember.Name = "btnMoreMember";
            this.btnMoreMember.Size = new System.Drawing.Size(29, 29);
            this.btnMoreMember.TabIndex = 13;
            this.btnMoreMember.Text = "...";
            this.btnMoreMember.UseVisualStyleBackColor = true;
            this.btnMoreMember.Click += new System.EventHandler(this.btnMoreMember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbBookStatus);
            this.groupBox1.Controls.Add(this.lblBookStatus);
            this.groupBox1.Controls.Add(this.txtbBookTitle);
            this.groupBox1.Controls.Add(this.lblBookTitle);
            this.groupBox1.Controls.Add(this.btnMoreBook);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtbRFID);
            this.groupBox1.Controls.Add(this.lblRFID);
            this.groupBox1.Location = new System.Drawing.Point(567, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 287);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book ID";
            // 
            // txtbBookStatus
            // 
            this.txtbBookStatus.Enabled = false;
            this.txtbBookStatus.Location = new System.Drawing.Point(83, 162);
            this.txtbBookStatus.Name = "txtbBookStatus";
            this.txtbBookStatus.Size = new System.Drawing.Size(90, 29);
            this.txtbBookStatus.TabIndex = 18;
            // 
            // lblBookStatus
            // 
            this.lblBookStatus.AutoSize = true;
            this.lblBookStatus.Location = new System.Drawing.Point(6, 167);
            this.lblBookStatus.Name = "lblBookStatus";
            this.lblBookStatus.Size = new System.Drawing.Size(73, 21);
            this.lblBookStatus.TabIndex = 17;
            this.lblBookStatus.Text = "Available";
            // 
            // txtbBookTitle
            // 
            this.txtbBookTitle.Enabled = false;
            this.txtbBookTitle.Location = new System.Drawing.Point(6, 129);
            this.txtbBookTitle.Name = "txtbBookTitle";
            this.txtbBookTitle.Size = new System.Drawing.Size(230, 29);
            this.txtbBookTitle.TabIndex = 16;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(79, 105);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(75, 21);
            this.lblBookTitle.TabIndex = 15;
            this.lblBookTitle.Text = "Book title";
            // 
            // btnMoreBook
            // 
            this.btnMoreBook.CausesValidation = false;
            this.btnMoreBook.Location = new System.Drawing.Point(207, 49);
            this.btnMoreBook.Name = "btnMoreBook";
            this.btnMoreBook.Size = new System.Drawing.Size(29, 29);
            this.btnMoreBook.TabIndex = 14;
            this.btnMoreBook.Text = "...";
            this.btnMoreBook.UseVisualStyleBackColor = true;
            this.btnMoreBook.Click += new System.EventHandler(this.btnMoreBook_Click);
            // 
            // txtbRFID
            // 
            this.txtbRFID.Location = new System.Drawing.Point(62, 49);
            this.txtbRFID.MaxLength = 10;
            this.txtbRFID.Name = "txtbRFID";
            this.txtbRFID.Size = new System.Drawing.Size(105, 29);
            this.txtbRFID.TabIndex = 2;
            this.txtbRFID.TextChanged += new System.EventHandler(this.txtbRFID_TextChanged);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(6, 52);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(43, 21);
            this.lblRFID.TabIndex = 0;
            this.lblRFID.Text = "RFID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSlash);
            this.groupBox2.Controls.Add(this.txtbStatus);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.txtbMaxBorrowed);
            this.groupBox2.Controls.Add(this.txtbTotalBorrowed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(293, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 287);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrower Info";
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Location = new System.Drawing.Point(161, 49);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(16, 21);
            this.lblSlash.TabIndex = 6;
            this.lblSlash.Text = "/";
            // 
            // txtbStatus
            // 
            this.txtbStatus.Enabled = false;
            this.txtbStatus.Location = new System.Drawing.Point(122, 87);
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.Size = new System.Drawing.Size(90, 29);
            this.txtbStatus.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 21);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // txtbMaxBorrowed
            // 
            this.txtbMaxBorrowed.Enabled = false;
            this.txtbMaxBorrowed.Location = new System.Drawing.Point(183, 46);
            this.txtbMaxBorrowed.Name = "txtbMaxBorrowed";
            this.txtbMaxBorrowed.Size = new System.Drawing.Size(29, 29);
            this.txtbMaxBorrowed.TabIndex = 2;
            // 
            // txtbTotalBorrowed
            // 
            this.txtbTotalBorrowed.Enabled = false;
            this.txtbTotalBorrowed.Location = new System.Drawing.Point(126, 46);
            this.txtbTotalBorrowed.Name = "txtbTotalBorrowed";
            this.txtbTotalBorrowed.Size = new System.Drawing.Size(29, 29);
            this.txtbTotalBorrowed.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total borrowed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // txtbName
            // 
            this.txtbName.Enabled = false;
            this.txtbName.Location = new System.Drawing.Point(6, 129);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(230, 29);
            this.txtbName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbMemberID);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.txtbFaculty);
            this.groupBox3.Controls.Add(this.lblMemberID);
            this.groupBox3.Controls.Add(this.lblFaculty);
            this.groupBox3.Controls.Add(this.txtbName);
            this.groupBox3.Controls.Add(this.btnMoreMember);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(22, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 287);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borrower ID";
            // 
            // txtbMemberID
            // 
            this.txtbMemberID.Location = new System.Drawing.Point(106, 49);
            this.txtbMemberID.MaxLength = 5;
            this.txtbMemberID.Name = "txtbMemberID";
            this.txtbMemberID.Size = new System.Drawing.Size(54, 29);
            this.txtbMemberID.TabIndex = 15;
            this.txtbMemberID.TextChanged += new System.EventHandler(this.txtbMemberID_TextChanged);
            this.txtbMemberID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbMemberID_KeyPress);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(161, 236);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtbFaculty
            // 
            this.txtbFaculty.Enabled = false;
            this.txtbFaculty.Location = new System.Drawing.Point(6, 189);
            this.txtbFaculty.Name = "txtbFaculty";
            this.txtbFaculty.Size = new System.Drawing.Size(230, 29);
            this.txtbFaculty.TabIndex = 3;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(102, 165);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(58, 21);
            this.lblFaculty.TabIndex = 2;
            this.lblFaculty.Text = "Faculty";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(835, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowForm";
            this.Text = "Borrow - Library Management System SA45Team07B";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
    }
}
