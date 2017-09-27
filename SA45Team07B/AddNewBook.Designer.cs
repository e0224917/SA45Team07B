namespace SA45Team07B
{
    partial class AddNewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewBook));
            this.txtbBkId = new System.Windows.Forms.TextBox();
            this.lblBkId = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBkTitle = new System.Windows.Forms.Label();
            this.txtbBkTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtbAuthor = new System.Windows.Forms.TextBox();
            this.lblCallNum = new System.Windows.Forms.Label();
            this.txtbCallNum = new System.Windows.Forms.TextBox();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEd = new System.Windows.Forms.Label();
            this.txtbEd = new System.Windows.Forms.TextBox();
            this.cbxSubjectName = new System.Windows.Forms.ComboBox();
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.lblCompul1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epAddBk = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtbYear = new System.Windows.Forms.MaskedTextBox();
            this.mtbISBN = new System.Windows.Forms.MaskedTextBox();
            this.lbxRFID = new System.Windows.Forms.ListBox();
            this.txtbRFID = new System.Windows.Forms.TextBox();
            this.btnAddRFID = new System.Windows.Forms.Button();
            this.btnDeleteRFID = new System.Windows.Forms.Button();
            this.gbxBasicInfo = new System.Windows.Forms.GroupBox();
            this.gbxRFID = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.epAddBk)).BeginInit();
            this.gbxBasicInfo.SuspendLayout();
            this.gbxRFID.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbBkId
            // 
            this.txtbBkId.Location = new System.Drawing.Point(254, 185);
            this.txtbBkId.Name = "txtbBkId";
            this.txtbBkId.ReadOnly = true;
            this.txtbBkId.Size = new System.Drawing.Size(164, 29);
            this.txtbBkId.TabIndex = 4;
            // 
            // lblBkId
            // 
            this.lblBkId.AutoSize = true;
            this.lblBkId.BackColor = System.Drawing.Color.Transparent;
            this.lblBkId.Location = new System.Drawing.Point(129, 188);
            this.lblBkId.Name = "lblBkId";
            this.lblBkId.Size = new System.Drawing.Size(63, 21);
            this.lblBkId.TabIndex = 10;
            this.lblBkId.Text = "BookID:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Location = new System.Drawing.Point(522, 59);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(47, 21);
            this.lblISBN.TabIndex = 12;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblBkTitle
            // 
            this.lblBkTitle.AutoSize = true;
            this.lblBkTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBkTitle.Location = new System.Drawing.Point(129, 236);
            this.lblBkTitle.Name = "lblBkTitle";
            this.lblBkTitle.Size = new System.Drawing.Size(81, 21);
            this.lblBkTitle.TabIndex = 14;
            this.lblBkTitle.Text = "Book Title:";
            // 
            // txtbBkTitle
            // 
            this.txtbBkTitle.Location = new System.Drawing.Point(253, 233);
            this.txtbBkTitle.Name = "txtbBkTitle";
            this.txtbBkTitle.Size = new System.Drawing.Size(853, 29);
            this.txtbBkTitle.TabIndex = 6;
            this.txtbBkTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtbBkTitle_Validating);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Location = new System.Drawing.Point(131, 284);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 21);
            this.lblAuthor.TabIndex = 16;
            this.lblAuthor.Text = "Author:";
            // 
            // txtbAuthor
            // 
            this.txtbAuthor.Location = new System.Drawing.Point(253, 281);
            this.txtbAuthor.Name = "txtbAuthor";
            this.txtbAuthor.Size = new System.Drawing.Size(853, 29);
            this.txtbAuthor.TabIndex = 7;
            // 
            // lblCallNum
            // 
            this.lblCallNum.AutoSize = true;
            this.lblCallNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCallNum.Location = new System.Drawing.Point(128, 381);
            this.lblCallNum.Name = "lblCallNum";
            this.lblCallNum.Size = new System.Drawing.Size(101, 21);
            this.lblCallNum.TabIndex = 18;
            this.lblCallNum.Text = "Call Number:";
            // 
            // txtbCallNum
            // 
            this.txtbCallNum.Location = new System.Drawing.Point(253, 378);
            this.txtbCallNum.Name = "txtbCallNum";
            this.txtbCallNum.Size = new System.Drawing.Size(267, 29);
            this.txtbCallNum.TabIndex = 10;
            this.txtbCallNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtbCallNum_Validating);
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblSubjectName.Location = new System.Drawing.Point(522, 203);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(110, 21);
            this.lblSubjectName.TabIndex = 20;
            this.lblSubjectName.Text = "Subject Name:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Location = new System.Drawing.Point(128, 333);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(78, 21);
            this.lblPublisher.TabIndex = 22;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.BackColor = System.Drawing.Color.Transparent;
            this.lblRFID.Location = new System.Drawing.Point(43, 58);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(46, 21);
            this.lblRFID.TabIndex = 24;
            this.lblRFID.Text = "RFID:";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(253, 427);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(85, 29);
            this.txtbPrice.TabIndex = 12;
            this.txtbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtbPrice_Validating);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(130, 428);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Text = "Price:";
            // 
            // lblEd
            // 
            this.lblEd.AutoSize = true;
            this.lblEd.BackColor = System.Drawing.Color.Transparent;
            this.lblEd.Location = new System.Drawing.Point(522, 253);
            this.lblEd.Name = "lblEd";
            this.lblEd.Size = new System.Drawing.Size(61, 21);
            this.lblEd.TabIndex = 28;
            this.lblEd.Text = "Edition:";
            // 
            // txtbEd
            // 
            this.txtbEd.Location = new System.Drawing.Point(654, 249);
            this.txtbEd.Name = "txtbEd";
            this.txtbEd.Size = new System.Drawing.Size(281, 29);
            this.txtbEd.TabIndex = 11;
            // 
            // cbxSubjectName
            // 
            this.cbxSubjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubjectName.DropDownWidth = 250;
            this.cbxSubjectName.FormattingEnabled = true;
            this.cbxSubjectName.Location = new System.Drawing.Point(745, 333);
            this.cbxSubjectName.Name = "cbxSubjectName";
            this.cbxSubjectName.Size = new System.Drawing.Size(281, 29);
            this.cbxSubjectName.TabIndex = 9;
            this.cbxSubjectName.Validating += new System.ComponentModel.CancelEventHandler(this.cbxSubjectName_Validating);
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(253, 330);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(267, 29);
            this.cbxPublisher.TabIndex = 8;
            this.cbxPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.cbxPublisher_Validating);
            // 
            // lblCompul1
            // 
            this.lblCompul1.AutoSize = true;
            this.lblCompul1.BackColor = System.Drawing.Color.Transparent;
            this.lblCompul1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompul1.ForeColor = System.Drawing.Color.Red;
            this.lblCompul1.Location = new System.Drawing.Point(234, 193);
            this.lblCompul1.Name = "lblCompul1";
            this.lblCompul1.Size = new System.Drawing.Size(12, 13);
            this.lblCompul1.TabIndex = 35;
            this.lblCompul1.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(233, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(575, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(726, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(233, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(235, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(235, 434);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "*";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Location = new System.Drawing.Point(522, 297);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(115, 21);
            this.lblYear.TabIndex = 44;
            this.lblYear.Text = "Published Year:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(727, 343);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "*";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(438, 671);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 31);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(681, 671);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 31);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epAddBk
            // 
            this.epAddBk.ContainerControl = this;
            // 
            // mtbYear
            // 
            this.mtbYear.Location = new System.Drawing.Point(654, 296);
            this.mtbYear.Mask = "0000";
            this.mtbYear.Name = "mtbYear";
            this.mtbYear.Size = new System.Drawing.Size(93, 29);
            this.mtbYear.TabIndex = 13;
            this.mtbYear.Validating += new System.ComponentModel.CancelEventHandler(this.mtbYear_Validating);
            // 
            // mtbISBN
            // 
            this.mtbISBN.Location = new System.Drawing.Point(649, 55);
            this.mtbISBN.Mask = "0000000000000";
            this.mtbISBN.Name = "mtbISBN";
            this.mtbISBN.RejectInputOnFirstFailure = true;
            this.mtbISBN.Size = new System.Drawing.Size(286, 29);
            this.mtbISBN.TabIndex = 5;
            this.mtbISBN.Validating += new System.ComponentModel.CancelEventHandler(this.mtbISBN_Validating);
            // 
            // lbxRFID
            // 
            this.lbxRFID.FormattingEnabled = true;
            this.lbxRFID.ItemHeight = 21;
            this.lbxRFID.Location = new System.Drawing.Point(625, 28);
            this.lbxRFID.Name = "lbxRFID";
            this.lbxRFID.Size = new System.Drawing.Size(309, 88);
            this.lbxRFID.TabIndex = 16;
            // 
            // txtbRFID
            // 
            this.txtbRFID.Location = new System.Drawing.Point(165, 52);
            this.txtbRFID.Name = "txtbRFID";
            this.txtbRFID.Size = new System.Drawing.Size(263, 29);
            this.txtbRFID.TabIndex = 14;
            // 
            // btnAddRFID
            // 
            this.btnAddRFID.Location = new System.Drawing.Point(484, 53);
            this.btnAddRFID.Name = "btnAddRFID";
            this.btnAddRFID.Size = new System.Drawing.Size(84, 28);
            this.btnAddRFID.TabIndex = 15;
            this.btnAddRFID.Text = "Add >>";
            this.btnAddRFID.UseVisualStyleBackColor = true;
            this.btnAddRFID.Click += new System.EventHandler(this.btnAddRFID_Click);
            // 
            // btnDeleteRFID
            // 
            this.btnDeleteRFID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRFID.BackgroundImage")));
            this.btnDeleteRFID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteRFID.Location = new System.Drawing.Point(958, 49);
            this.btnDeleteRFID.Name = "btnDeleteRFID";
            this.btnDeleteRFID.Size = new System.Drawing.Size(31, 32);
            this.btnDeleteRFID.TabIndex = 17;
            this.btnDeleteRFID.UseVisualStyleBackColor = true;
            this.btnDeleteRFID.Click += new System.EventHandler(this.btnDeleteRFID_Click);
            // 
            // gbxBasicInfo
            // 
            this.gbxBasicInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbxBasicInfo.Controls.Add(this.lblISBN);
            this.gbxBasicInfo.Controls.Add(this.mtbISBN);
            this.gbxBasicInfo.Controls.Add(this.lblSubjectName);
            this.gbxBasicInfo.Controls.Add(this.lblEd);
            this.gbxBasicInfo.Controls.Add(this.lblYear);
            this.gbxBasicInfo.Controls.Add(this.mtbYear);
            this.gbxBasicInfo.Controls.Add(this.txtbEd);
            this.gbxBasicInfo.Location = new System.Drawing.Point(91, 129);
            this.gbxBasicInfo.Name = "gbxBasicInfo";
            this.gbxBasicInfo.Size = new System.Drawing.Size(1045, 343);
            this.gbxBasicInfo.TabIndex = 58;
            this.gbxBasicInfo.TabStop = false;
            this.gbxBasicInfo.Text = "Add Book";
            // 
            // gbxRFID
            // 
            this.gbxRFID.BackColor = System.Drawing.Color.Transparent;
            this.gbxRFID.Controls.Add(this.lbxRFID);
            this.gbxRFID.Controls.Add(this.btnDeleteRFID);
            this.gbxRFID.Controls.Add(this.lblRFID);
            this.gbxRFID.Controls.Add(this.btnAddRFID);
            this.gbxRFID.Controls.Add(this.label13);
            this.gbxRFID.Controls.Add(this.txtbRFID);
            this.gbxRFID.Location = new System.Drawing.Point(92, 499);
            this.gbxRFID.Name = "gbxRFID";
            this.gbxRFID.Size = new System.Drawing.Size(1044, 135);
            this.gbxRFID.TabIndex = 59;
            this.gbxRFID.TabStop = false;
            this.gbxRFID.Text = "Add RFID";
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCompul1);
            this.Controls.Add(this.cbxPublisher);
            this.Controls.Add(this.cbxSubjectName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblCallNum);
            this.Controls.Add(this.txtbCallNum);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtbAuthor);
            this.Controls.Add(this.lblBkTitle);
            this.Controls.Add(this.txtbBkTitle);
            this.Controls.Add(this.lblBkId);
            this.Controls.Add(this.txtbBkId);
            this.Controls.Add(this.gbxBasicInfo);
            this.Controls.Add(this.gbxRFID);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "AddNewBook";
            this.Text = "Add New Book";
            this.Load += new System.EventHandler(this.AddNewBook_Load);
            this.Controls.SetChildIndex(this.gbxRFID, 0);
            this.Controls.SetChildIndex(this.gbxBasicInfo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtbBkId, 0);
            this.Controls.SetChildIndex(this.lblBkId, 0);
            this.Controls.SetChildIndex(this.txtbBkTitle, 0);
            this.Controls.SetChildIndex(this.lblBkTitle, 0);
            this.Controls.SetChildIndex(this.txtbAuthor, 0);
            this.Controls.SetChildIndex(this.lblAuthor, 0);
            this.Controls.SetChildIndex(this.txtbCallNum, 0);
            this.Controls.SetChildIndex(this.lblCallNum, 0);
            this.Controls.SetChildIndex(this.lblPublisher, 0);
            this.Controls.SetChildIndex(this.txtbPrice, 0);
            this.Controls.SetChildIndex(this.lblPrice, 0);
            this.Controls.SetChildIndex(this.cbxSubjectName, 0);
            this.Controls.SetChildIndex(this.cbxPublisher, 0);
            this.Controls.SetChildIndex(this.lblCompul1, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.epAddBk)).EndInit();
            this.gbxBasicInfo.ResumeLayout(false);
            this.gbxBasicInfo.PerformLayout();
            this.gbxRFID.ResumeLayout(false);
            this.gbxRFID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbBkId;
        private System.Windows.Forms.Label lblBkId;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblBkTitle;
        private System.Windows.Forms.TextBox txtbBkTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtbAuthor;
        private System.Windows.Forms.Label lblCallNum;
        private System.Windows.Forms.TextBox txtbCallNum;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEd;
        private System.Windows.Forms.TextBox txtbEd;
        private System.Windows.Forms.ComboBox cbxSubjectName;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.Label lblCompul1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epAddBk;
        private System.Windows.Forms.MaskedTextBox mtbYear;
        private System.Windows.Forms.MaskedTextBox mtbISBN;
        private System.Windows.Forms.ListBox lbxRFID;
        private System.Windows.Forms.Button btnAddRFID;
        private System.Windows.Forms.TextBox txtbRFID;
        private System.Windows.Forms.Button btnDeleteRFID;
        private System.Windows.Forms.GroupBox gbxBasicInfo;
        private System.Windows.Forms.GroupBox gbxRFID;
    }
}
