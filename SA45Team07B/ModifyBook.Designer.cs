namespace SA45Team07B
{
    partial class ModifyBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyBook));
            this.btnAddRFID = new System.Windows.Forms.Button();
            this.txtbRFID = new System.Windows.Forms.TextBox();
            this.lbxRFID = new System.Windows.Forms.ListBox();
            this.mtbISBN = new System.Windows.Forms.MaskedTextBox();
            this.mtbYear = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCompul1 = new System.Windows.Forms.Label();
            this.lblEd = new System.Windows.Forms.Label();
            this.txtbEd = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
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
            this.epModifyBk = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.cbxSubjectName = new System.Windows.Forms.ComboBox();
            this.gbxBasicInfo = new System.Windows.Forms.GroupBox();
            this.gbxRFID = new System.Windows.Forms.GroupBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDeleteRFID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epModifyBk)).BeginInit();
            this.gbxBasicInfo.SuspendLayout();
            this.gbxRFID.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRFID
            // 
            this.btnAddRFID.Location = new System.Drawing.Point(509, 56);
            this.btnAddRFID.Name = "btnAddRFID";
            this.btnAddRFID.Size = new System.Drawing.Size(84, 28);
            this.btnAddRFID.TabIndex = 14;
            this.btnAddRFID.Text = "Add >>";
            this.btnAddRFID.UseVisualStyleBackColor = true;
            this.btnAddRFID.Click += new System.EventHandler(this.btnAddRFID_Click);
            // 
            // txtbRFID
            // 
            this.txtbRFID.Location = new System.Drawing.Point(171, 57);
            this.txtbRFID.Name = "txtbRFID";
            this.txtbRFID.Size = new System.Drawing.Size(289, 29);
            this.txtbRFID.TabIndex = 13;
            // 
            // lbxRFID
            // 
            this.lbxRFID.FormattingEnabled = true;
            this.lbxRFID.ItemHeight = 21;
            this.lbxRFID.Location = new System.Drawing.Point(639, 28);
            this.lbxRFID.Name = "lbxRFID";
            this.lbxRFID.Size = new System.Drawing.Size(309, 88);
            this.lbxRFID.TabIndex = 15;
            // 
            // mtbISBN
            // 
            this.mtbISBN.Location = new System.Drawing.Point(663, 55);
            this.mtbISBN.Mask = "0000000000000";
            this.mtbISBN.Name = "mtbISBN";
            this.mtbISBN.RejectInputOnFirstFailure = true;
            this.mtbISBN.Size = new System.Drawing.Size(297, 29);
            this.mtbISBN.TabIndex = 4;
            this.mtbISBN.Validating += new System.ComponentModel.CancelEventHandler(this.mtbISBN_Validating);
            // 
            // mtbYear
            // 
            this.mtbYear.Location = new System.Drawing.Point(664, 284);
            this.mtbYear.Mask = "0000";
            this.mtbYear.Name = "mtbYear";
            this.mtbYear.Size = new System.Drawing.Size(100, 29);
            this.mtbYear.TabIndex = 12;
            this.mtbYear.Validating += new System.ComponentModel.CancelEventHandler(this.mtbYear_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(681, 671);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(438, 671);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 31);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Save Changes";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(736, 334);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 13);
            this.label19.TabIndex = 83;
            this.label19.Text = "*";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Location = new System.Drawing.Point(529, 287);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(115, 21);
            this.lblYear.TabIndex = 82;
            this.lblYear.Text = "Published Year:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(154, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 81;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(154, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 80;
            this.label16.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(582, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(243, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 77;
            this.label15.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(242, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "*";
            // 
            // lblCompul1
            // 
            this.lblCompul1.AutoSize = true;
            this.lblCompul1.BackColor = System.Drawing.Color.Transparent;
            this.lblCompul1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompul1.ForeColor = System.Drawing.Color.Red;
            this.lblCompul1.Location = new System.Drawing.Point(150, 64);
            this.lblCompul1.Name = "lblCompul1";
            this.lblCompul1.Size = new System.Drawing.Size(12, 13);
            this.lblCompul1.TabIndex = 75;
            this.lblCompul1.Text = "*";
            // 
            // lblEd
            // 
            this.lblEd.AutoSize = true;
            this.lblEd.BackColor = System.Drawing.Color.Transparent;
            this.lblEd.Location = new System.Drawing.Point(529, 245);
            this.lblEd.Name = "lblEd";
            this.lblEd.Size = new System.Drawing.Size(61, 21);
            this.lblEd.TabIndex = 72;
            this.lblEd.Text = "Edition:";
            // 
            // txtbEd
            // 
            this.txtbEd.Location = new System.Drawing.Point(663, 237);
            this.txtbEd.Name = "txtbEd";
            this.txtbEd.Size = new System.Drawing.Size(297, 29);
            this.txtbEd.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(41, 291);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 70;
            this.lblPrice.Text = "Price:";
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.BackColor = System.Drawing.Color.Transparent;
            this.lblRFID.Location = new System.Drawing.Point(41, 60);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(46, 21);
            this.lblRFID.TabIndex = 69;
            this.lblRFID.Text = "RFID:";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(172, 288);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(80, 29);
            this.txtbPrice.TabIndex = 11;
            this.txtbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtbPrice_Validating);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Location = new System.Drawing.Point(41, 199);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(78, 21);
            this.lblPublisher.TabIndex = 67;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblSubjectName.Location = new System.Drawing.Point(620, 328);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(110, 21);
            this.lblSubjectName.TabIndex = 66;
            this.lblSubjectName.Text = "Subject Name:";
            // 
            // lblCallNum
            // 
            this.lblCallNum.AutoSize = true;
            this.lblCallNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCallNum.Location = new System.Drawing.Point(41, 245);
            this.lblCallNum.Name = "lblCallNum";
            this.lblCallNum.Size = new System.Drawing.Size(101, 21);
            this.lblCallNum.TabIndex = 65;
            this.lblCallNum.Text = "Call Number:";
            // 
            // txtbCallNum
            // 
            this.txtbCallNum.Location = new System.Drawing.Point(172, 242);
            this.txtbCallNum.Name = "txtbCallNum";
            this.txtbCallNum.Size = new System.Drawing.Size(289, 29);
            this.txtbCallNum.TabIndex = 9;
            this.txtbCallNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtbCallNum_Validating);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Location = new System.Drawing.Point(40, 150);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 21);
            this.lblAuthor.TabIndex = 63;
            this.lblAuthor.Text = "Author:";
            // 
            // txtbAuthor
            // 
            this.txtbAuthor.Location = new System.Drawing.Point(171, 147);
            this.txtbAuthor.Name = "txtbAuthor";
            this.txtbAuthor.Size = new System.Drawing.Size(821, 29);
            this.txtbAuthor.TabIndex = 6;
            // 
            // lblBkTitle
            // 
            this.lblBkTitle.AutoSize = true;
            this.lblBkTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBkTitle.Location = new System.Drawing.Point(38, 105);
            this.lblBkTitle.Name = "lblBkTitle";
            this.lblBkTitle.Size = new System.Drawing.Size(81, 21);
            this.lblBkTitle.TabIndex = 61;
            this.lblBkTitle.Text = "Book Title:";
            // 
            // txtbBkTitle
            // 
            this.txtbBkTitle.Location = new System.Drawing.Point(171, 102);
            this.txtbBkTitle.Name = "txtbBkTitle";
            this.txtbBkTitle.Size = new System.Drawing.Size(821, 29);
            this.txtbBkTitle.TabIndex = 5;
            this.txtbBkTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtbBkTitle_Validating);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Location = new System.Drawing.Point(529, 59);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(47, 21);
            this.lblISBN.TabIndex = 59;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblBkId
            // 
            this.lblBkId.AutoSize = true;
            this.lblBkId.BackColor = System.Drawing.Color.Transparent;
            this.lblBkId.Location = new System.Drawing.Point(129, 188);
            this.lblBkId.Name = "lblBkId";
            this.lblBkId.Size = new System.Drawing.Size(63, 21);
            this.lblBkId.TabIndex = 58;
            this.lblBkId.Text = "BookID:";
            // 
            // txtbBkId
            // 
            this.txtbBkId.Location = new System.Drawing.Point(171, 55);
            this.txtbBkId.Name = "txtbBkId";
            this.txtbBkId.ReadOnly = true;
            this.txtbBkId.Size = new System.Drawing.Size(183, 29);
            this.txtbBkId.TabIndex = 2;
            // 
            // btnFindBk
            // 
            this.btnFindBk.BackColor = System.Drawing.Color.White;
            this.btnFindBk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindBk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBk.Location = new System.Drawing.Point(377, 56);
            this.btnFindBk.Name = "btnFindBk";
            this.btnFindBk.Size = new System.Drawing.Size(31, 27);
            this.btnFindBk.TabIndex = 3;
            this.btnFindBk.Text = "...";
            this.btnFindBk.UseVisualStyleBackColor = false;
            this.btnFindBk.Click += new System.EventHandler(this.btnFindBk_Click);
            // 
            // epModifyBk
            // 
            this.epModifyBk.ContainerControl = this;
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(171, 194);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(290, 29);
            this.cbxPublisher.TabIndex = 7;
            // 
            // cbxSubjectName
            // 
            this.cbxSubjectName.FormattingEnabled = true;
            this.cbxSubjectName.Location = new System.Drawing.Point(663, 191);
            this.cbxSubjectName.Name = "cbxSubjectName";
            this.cbxSubjectName.Size = new System.Drawing.Size(297, 29);
            this.cbxSubjectName.TabIndex = 8;
            // 
            // gbxBasicInfo
            // 
            this.gbxBasicInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbxBasicInfo.Controls.Add(this.cbxSubjectName);
            this.gbxBasicInfo.Controls.Add(this.mtbISBN);
            this.gbxBasicInfo.Controls.Add(this.cbxPublisher);
            this.gbxBasicInfo.Controls.Add(this.lblISBN);
            this.gbxBasicInfo.Controls.Add(this.mtbYear);
            this.gbxBasicInfo.Controls.Add(this.label14);
            this.gbxBasicInfo.Controls.Add(this.btnFindBk);
            this.gbxBasicInfo.Controls.Add(this.txtbBkId);
            this.gbxBasicInfo.Controls.Add(this.lblCompul1);
            this.gbxBasicInfo.Controls.Add(this.lblBkTitle);
            this.gbxBasicInfo.Controls.Add(this.lblAuthor);
            this.gbxBasicInfo.Controls.Add(this.lblYear);
            this.gbxBasicInfo.Controls.Add(this.txtbEd);
            this.gbxBasicInfo.Controls.Add(this.lblPublisher);
            this.gbxBasicInfo.Controls.Add(this.label17);
            this.gbxBasicInfo.Controls.Add(this.txtbAuthor);
            this.gbxBasicInfo.Controls.Add(this.label16);
            this.gbxBasicInfo.Controls.Add(this.lblEd);
            this.gbxBasicInfo.Controls.Add(this.txtbBkTitle);
            this.gbxBasicInfo.Controls.Add(this.lblCallNum);
            this.gbxBasicInfo.Controls.Add(this.lblPrice);
            this.gbxBasicInfo.Controls.Add(this.txtbCallNum);
            this.gbxBasicInfo.Controls.Add(this.txtbPrice);
            this.gbxBasicInfo.Location = new System.Drawing.Point(91, 129);
            this.gbxBasicInfo.Name = "gbxBasicInfo";
            this.gbxBasicInfo.Size = new System.Drawing.Size(1045, 343);
            this.gbxBasicInfo.TabIndex = 95;
            this.gbxBasicInfo.TabStop = false;
            this.gbxBasicInfo.Text = "Book Details";
            // 
            // gbxRFID
            // 
            this.gbxRFID.BackColor = System.Drawing.Color.Transparent;
            this.gbxRFID.Controls.Add(this.btnUndo);
            this.gbxRFID.Controls.Add(this.txtbRFID);
            this.gbxRFID.Controls.Add(this.lblRFID);
            this.gbxRFID.Controls.Add(this.lbxRFID);
            this.gbxRFID.Controls.Add(this.btnAddRFID);
            this.gbxRFID.Location = new System.Drawing.Point(92, 499);
            this.gbxRFID.Name = "gbxRFID";
            this.gbxRFID.Size = new System.Drawing.Size(1044, 135);
            this.gbxRFID.TabIndex = 96;
            this.gbxRFID.TabStop = false;
            this.gbxRFID.Text = "RFID";
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.BackgroundImage")));
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUndo.Location = new System.Drawing.Point(973, 54);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(31, 32);
            this.btnUndo.TabIndex = 70;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDeleteRFID
            // 
            this.btnDeleteRFID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteRFID.Location = new System.Drawing.Point(973, 54);
            this.btnDeleteRFID.Name = "btnDeleteRFID";
            this.btnDeleteRFID.Size = new System.Drawing.Size(31, 32);
            this.btnDeleteRFID.TabIndex = 70;
            this.btnDeleteRFID.UseVisualStyleBackColor = true;
            // 
            // ModifyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.lblBkId);
            this.Controls.Add(this.gbxBasicInfo);
            this.Controls.Add(this.gbxRFID);
            this.Name = "ModifyBook";
            this.Text = "Modify Books";
            this.Controls.SetChildIndex(this.gbxRFID, 0);
            this.Controls.SetChildIndex(this.gbxBasicInfo, 0);
            this.Controls.SetChildIndex(this.lblBkId, 0);
            this.Controls.SetChildIndex(this.lblSubjectName, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.epModifyBk)).EndInit();
            this.gbxBasicInfo.ResumeLayout(false);
            this.gbxBasicInfo.PerformLayout();
            this.gbxRFID.ResumeLayout(false);
            this.gbxRFID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddRFID;
        private System.Windows.Forms.TextBox txtbRFID;
        private System.Windows.Forms.ListBox lbxRFID;
        private System.Windows.Forms.MaskedTextBox mtbISBN;
        private System.Windows.Forms.MaskedTextBox mtbYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCompul1;
        private System.Windows.Forms.Label lblEd;
        private System.Windows.Forms.TextBox txtbEd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRFID;
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
        private System.Windows.Forms.ErrorProvider epModifyBk;
        private System.Windows.Forms.ComboBox cbxSubjectName;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.GroupBox gbxBasicInfo;
        private System.Windows.Forms.GroupBox gbxRFID;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDeleteRFID;
    }
}
