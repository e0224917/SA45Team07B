namespace SA45Team07B
{
    partial class BookInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAddBk = new System.Windows.Forms.Label();
            this.mtbISBN = new System.Windows.Forms.MaskedTextBox();
            this.mtbYear = new System.Windows.Forms.MaskedTextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEd = new System.Windows.Forms.Label();
            this.txtbEd = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblCallNum = new System.Windows.Forms.Label();
            this.txtbCallNum = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtbAuthor = new System.Windows.Forms.TextBox();
            this.lblBkTitle = new System.Windows.Forms.Label();
            this.txtbBkTitle = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBkId = new System.Windows.Forms.Label();
            this.txtbBkId = new System.Windows.Forms.TextBox();
            this.btnFindBk = new System.Windows.Forms.Button();
            this.txtbPublisher = new System.Windows.Forms.TextBox();
            this.txtbSubjectName = new System.Windows.Forms.TextBox();
            this.lblAvail = new System.Windows.Forms.Label();
            this.dgvAvail = new System.Windows.Forms.DataGridView();
            this.RFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddBk
            // 
            this.lblAddBk.AutoSize = true;
            this.lblAddBk.BackColor = System.Drawing.Color.Transparent;
            this.lblAddBk.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBk.Location = new System.Drawing.Point(518, 98);
            this.lblAddBk.Name = "lblAddBk";
            this.lblAddBk.Size = new System.Drawing.Size(163, 25);
            this.lblAddBk.TabIndex = 85;
            this.lblAddBk.Text = "View Book Detail";
            // 
            // mtbISBN
            // 
            this.mtbISBN.Location = new System.Drawing.Point(257, 183);
            this.mtbISBN.Mask = "0000000000000";
            this.mtbISBN.Name = "mtbISBN";
            this.mtbISBN.ReadOnly = true;
            this.mtbISBN.RejectInputOnFirstFailure = true;
            this.mtbISBN.Size = new System.Drawing.Size(182, 29);
            this.mtbISBN.TabIndex = 84;
            // 
            // mtbYear
            // 
            this.mtbYear.Location = new System.Drawing.Point(750, 426);
            this.mtbYear.Mask = "0000";
            this.mtbYear.Name = "mtbYear";
            this.mtbYear.ReadOnly = true;
            this.mtbYear.Size = new System.Drawing.Size(100, 29);
            this.mtbYear.TabIndex = 83;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Location = new System.Drawing.Point(613, 431);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(115, 21);
            this.lblYear.TabIndex = 81;
            this.lblYear.Text = "Published Year:";
            // 
            // lblEd
            // 
            this.lblEd.AutoSize = true;
            this.lblEd.BackColor = System.Drawing.Color.Transparent;
            this.lblEd.Location = new System.Drawing.Point(667, 385);
            this.lblEd.Name = "lblEd";
            this.lblEd.Size = new System.Drawing.Size(61, 21);
            this.lblEd.TabIndex = 72;
            this.lblEd.Text = "Edition:";
            // 
            // txtbEd
            // 
            this.txtbEd.Location = new System.Drawing.Point(750, 379);
            this.txtbEd.Name = "txtbEd";
            this.txtbEd.ReadOnly = true;
            this.txtbEd.Size = new System.Drawing.Size(176, 29);
            this.txtbEd.TabIndex = 71;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(187, 431);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 70;
            this.lblPrice.Text = "Price:";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(258, 431);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.ReadOnly = true;
            this.txtbPrice.Size = new System.Drawing.Size(66, 29);
            this.txtbPrice.TabIndex = 69;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Location = new System.Drawing.Point(156, 333);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(78, 21);
            this.lblPublisher.TabIndex = 68;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblSubjectName.Location = new System.Drawing.Point(615, 334);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(110, 21);
            this.lblSubjectName.TabIndex = 67;
            this.lblSubjectName.Text = "Subject Name:";
            // 
            // lblCallNum
            // 
            this.lblCallNum.AutoSize = true;
            this.lblCallNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCallNum.Location = new System.Drawing.Point(133, 385);
            this.lblCallNum.Name = "lblCallNum";
            this.lblCallNum.Size = new System.Drawing.Size(101, 21);
            this.lblCallNum.TabIndex = 66;
            this.lblCallNum.Text = "Call Number:";
            // 
            // txtbCallNum
            // 
            this.txtbCallNum.Location = new System.Drawing.Point(258, 382);
            this.txtbCallNum.Name = "txtbCallNum";
            this.txtbCallNum.ReadOnly = true;
            this.txtbCallNum.Size = new System.Drawing.Size(215, 29);
            this.txtbCallNum.TabIndex = 65;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Location = new System.Drawing.Point(173, 285);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 21);
            this.lblAuthor.TabIndex = 64;
            this.lblAuthor.Text = "Author:";
            // 
            // txtbAuthor
            // 
            this.txtbAuthor.Location = new System.Drawing.Point(257, 282);
            this.txtbAuthor.Name = "txtbAuthor";
            this.txtbAuthor.ReadOnly = true;
            this.txtbAuthor.Size = new System.Drawing.Size(853, 29);
            this.txtbAuthor.TabIndex = 63;
            // 
            // lblBkTitle
            // 
            this.lblBkTitle.AutoSize = true;
            this.lblBkTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBkTitle.Location = new System.Drawing.Point(153, 233);
            this.lblBkTitle.Name = "lblBkTitle";
            this.lblBkTitle.Size = new System.Drawing.Size(81, 21);
            this.lblBkTitle.TabIndex = 62;
            this.lblBkTitle.Text = "Book Title:";
            // 
            // txtbBkTitle
            // 
            this.txtbBkTitle.Location = new System.Drawing.Point(257, 230);
            this.txtbBkTitle.Name = "txtbBkTitle";
            this.txtbBkTitle.ReadOnly = true;
            this.txtbBkTitle.Size = new System.Drawing.Size(853, 29);
            this.txtbBkTitle.TabIndex = 61;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Location = new System.Drawing.Point(184, 188);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(47, 21);
            this.lblISBN.TabIndex = 60;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblBkId
            // 
            this.lblBkId.AutoSize = true;
            this.lblBkId.BackColor = System.Drawing.Color.Transparent;
            this.lblBkId.Location = new System.Drawing.Point(171, 143);
            this.lblBkId.Name = "lblBkId";
            this.lblBkId.Size = new System.Drawing.Size(63, 21);
            this.lblBkId.TabIndex = 59;
            this.lblBkId.Text = "BookID:";
            // 
            // txtbBkId
            // 
            this.txtbBkId.Location = new System.Drawing.Point(258, 139);
            this.txtbBkId.Name = "txtbBkId";
            this.txtbBkId.ReadOnly = true;
            this.txtbBkId.Size = new System.Drawing.Size(112, 29);
            this.txtbBkId.TabIndex = 58;
            // 
            // btnFindBk
            // 
            this.btnFindBk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindBk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBk.Location = new System.Drawing.Point(392, 140);
            this.btnFindBk.Name = "btnFindBk";
            this.btnFindBk.Size = new System.Drawing.Size(31, 27);
            this.btnFindBk.TabIndex = 94;
            this.btnFindBk.Text = "...";
            this.btnFindBk.UseVisualStyleBackColor = true;
            this.btnFindBk.Click += new System.EventHandler(this.btnFindBk_Click);
            // 
            // txtbPublisher
            // 
            this.txtbPublisher.Location = new System.Drawing.Point(258, 331);
            this.txtbPublisher.Name = "txtbPublisher";
            this.txtbPublisher.ReadOnly = true;
            this.txtbPublisher.Size = new System.Drawing.Size(215, 29);
            this.txtbPublisher.TabIndex = 95;
            // 
            // txtbSubjectName
            // 
            this.txtbSubjectName.Location = new System.Drawing.Point(750, 330);
            this.txtbSubjectName.Name = "txtbSubjectName";
            this.txtbSubjectName.ReadOnly = true;
            this.txtbSubjectName.Size = new System.Drawing.Size(215, 29);
            this.txtbSubjectName.TabIndex = 96;
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.BackColor = System.Drawing.Color.Transparent;
            this.lblAvail.Location = new System.Drawing.Point(145, 498);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(89, 21);
            this.lblAvail.TabIndex = 97;
            this.lblAvail.Text = "Availability:";
            // 
            // dgvAvail
            // 
            this.dgvAvail.AllowUserToAddRows = false;
            this.dgvAvail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAvail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvail.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFID,
            this.Availability,
            this.DateBorrowed,
            this.DueDate,
            this.BorrowedBy});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvail.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAvail.GridColor = System.Drawing.Color.White;
            this.dgvAvail.Location = new System.Drawing.Point(260, 485);
            this.dgvAvail.Name = "dgvAvail";
            this.dgvAvail.ReadOnly = true;
            this.dgvAvail.RowHeadersWidth = 5;
            this.dgvAvail.RowTemplate.Height = 23;
            this.dgvAvail.Size = new System.Drawing.Size(714, 174);
            this.dgvAvail.TabIndex = 98;
            // 
            // RFID
            // 
            this.RFID.DataPropertyName = "RFID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RFID.DefaultCellStyle = dataGridViewCellStyle3;
            this.RFID.HeaderText = "RFID";
            this.RFID.Name = "RFID";
            this.RFID.ReadOnly = true;
            this.RFID.Width = 120;
            // 
            // Availability
            // 
            this.Availability.DataPropertyName = "Availability";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Availability.DefaultCellStyle = dataGridViewCellStyle4;
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            this.Availability.Width = 120;
            // 
            // DateBorrowed
            // 
            this.DateBorrowed.DataPropertyName = "DateBorrowed";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateBorrowed.DefaultCellStyle = dataGridViewCellStyle5;
            this.DateBorrowed.HeaderText = "Date Borrowed";
            this.DateBorrowed.Name = "DateBorrowed";
            this.DateBorrowed.ReadOnly = true;
            this.DateBorrowed.Width = 150;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DueDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 150;
            // 
            // BorrowedBy
            // 
            this.BorrowedBy.DataPropertyName = "BorrowedBy";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BorrowedBy.DefaultCellStyle = dataGridViewCellStyle7;
            this.BorrowedBy.HeaderText = "Last Borrowed by";
            this.BorrowedBy.Name = "BorrowedBy";
            this.BorrowedBy.ReadOnly = true;
            this.BorrowedBy.Width = 160;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(532, 702);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 39);
            this.btnClose.TabIndex = 99;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAvail);
            this.Controls.Add(this.lblAvail);
            this.Controls.Add(this.txtbSubjectName);
            this.Controls.Add(this.txtbPublisher);
            this.Controls.Add(this.btnFindBk);
            this.Controls.Add(this.lblAddBk);
            this.Controls.Add(this.mtbISBN);
            this.Controls.Add(this.mtbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblEd);
            this.Controls.Add(this.txtbEd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.lblCallNum);
            this.Controls.Add(this.txtbCallNum);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtbAuthor);
            this.Controls.Add(this.lblBkTitle);
            this.Controls.Add(this.txtbBkTitle);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblBkId);
            this.Controls.Add(this.txtbBkId);
            this.Name = "BookInfo";
            this.Text = "View Book Detail - Library Management System SA45Team07B";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtbBkId, 0);
            this.Controls.SetChildIndex(this.lblBkId, 0);
            this.Controls.SetChildIndex(this.lblISBN, 0);
            this.Controls.SetChildIndex(this.txtbBkTitle, 0);
            this.Controls.SetChildIndex(this.lblBkTitle, 0);
            this.Controls.SetChildIndex(this.txtbAuthor, 0);
            this.Controls.SetChildIndex(this.lblAuthor, 0);
            this.Controls.SetChildIndex(this.txtbCallNum, 0);
            this.Controls.SetChildIndex(this.lblCallNum, 0);
            this.Controls.SetChildIndex(this.lblSubjectName, 0);
            this.Controls.SetChildIndex(this.lblPublisher, 0);
            this.Controls.SetChildIndex(this.txtbPrice, 0);
            this.Controls.SetChildIndex(this.lblPrice, 0);
            this.Controls.SetChildIndex(this.txtbEd, 0);
            this.Controls.SetChildIndex(this.lblEd, 0);
            this.Controls.SetChildIndex(this.lblYear, 0);
            this.Controls.SetChildIndex(this.mtbYear, 0);
            this.Controls.SetChildIndex(this.mtbISBN, 0);
            this.Controls.SetChildIndex(this.lblAddBk, 0);
            this.Controls.SetChildIndex(this.btnFindBk, 0);
            this.Controls.SetChildIndex(this.txtbPublisher, 0);
            this.Controls.SetChildIndex(this.txtbSubjectName, 0);
            this.Controls.SetChildIndex(this.lblAvail, 0);
            this.Controls.SetChildIndex(this.dgvAvail, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBk;
        private System.Windows.Forms.MaskedTextBox mtbISBN;
        private System.Windows.Forms.MaskedTextBox mtbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblEd;
        private System.Windows.Forms.TextBox txtbEd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblCallNum;
        private System.Windows.Forms.TextBox txtbCallNum;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtbAuthor;
        private System.Windows.Forms.Label lblBkTitle;
        private System.Windows.Forms.TextBox txtbBkTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblBkId;
        private System.Windows.Forms.TextBox txtbBkId;
        private System.Windows.Forms.Button btnFindBk;
        private System.Windows.Forms.TextBox txtbPublisher;
        private System.Windows.Forms.TextBox txtbSubjectName;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.DataGridView dgvAvail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedBy;
        private System.Windows.Forms.Button btnClose;
    }
}
