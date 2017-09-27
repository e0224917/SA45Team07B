namespace SA45Team07B
{
    partial class MemberPopUpSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSelectMember = new System.Windows.Forms.Label();
            this.dataGridViewMemberList = new System.Windows.Forms.DataGridView();
            this.MemberIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanedQtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSchoolID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbMemberName = new System.Windows.Forms.TextBox();
            this.txtbSchoolID = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripStatusLblSelectedMember = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMember
            // 
            this.lblSelectMember.AutoSize = true;
            this.lblSelectMember.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMember.Location = new System.Drawing.Point(34, 181);
            this.lblSelectMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectMember.Name = "lblSelectMember";
            this.lblSelectMember.Size = new System.Drawing.Size(188, 21);
            this.lblSelectMember.TabIndex = 1;
            this.lblSelectMember.Text = "Select a member from list";
            // 
            // dataGridViewMemberList
            // 
            this.dataGridViewMemberList.AllowUserToAddRows = false;
            this.dataGridViewMemberList.AllowUserToDeleteRows = false;
            this.dataGridViewMemberList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewMemberList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewMemberList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMemberList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMemberList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMemberList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberIDColumn,
            this.MemberNameColumn,
            this.SchoolIDColumn,
            this.MemberTypeColumn,
            this.FacultyCodeColumn,
            this.ContactNumberColumn,
            this.EmailAddressColumn,
            this.LoanedQtyColumn});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMemberList.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMemberList.EnableHeadersVisualStyles = false;
            this.dataGridViewMemberList.GridColor = System.Drawing.Color.White;
            this.dataGridViewMemberList.Location = new System.Drawing.Point(27, 210);
            this.dataGridViewMemberList.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridViewMemberList.MultiSelect = false;
            this.dataGridViewMemberList.Name = "dataGridViewMemberList";
            this.dataGridViewMemberList.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMemberList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewMemberList.RowHeadersVisible = false;
            this.dataGridViewMemberList.RowHeadersWidth = 5;
            this.dataGridViewMemberList.RowTemplate.Height = 24;
            this.dataGridViewMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMemberList.Size = new System.Drawing.Size(699, 412);
            this.dataGridViewMemberList.TabIndex = 8;
            this.dataGridViewMemberList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewMemberList_Scroll);
            this.dataGridViewMemberList.SelectionChanged += new System.EventHandler(this.dataGridViewMemberList_SelectionChanged);
            this.dataGridViewMemberList.DoubleClick += new System.EventHandler(this.btnOK_Click);
            // 
            // MemberIDColumn
            // 
            this.MemberIDColumn.DataPropertyName = "MemberID";
            this.MemberIDColumn.HeaderText = "ID";
            this.MemberIDColumn.Name = "MemberIDColumn";
            this.MemberIDColumn.ReadOnly = true;
            this.MemberIDColumn.Width = 69;
            // 
            // MemberNameColumn
            // 
            this.MemberNameColumn.DataPropertyName = "MemberName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MemberNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.MemberNameColumn.HeaderText = "Name";
            this.MemberNameColumn.Name = "MemberNameColumn";
            this.MemberNameColumn.ReadOnly = true;
            this.MemberNameColumn.Width = 96;
            // 
            // SchoolIDColumn
            // 
            this.SchoolIDColumn.DataPropertyName = "SchoolID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SchoolIDColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.SchoolIDColumn.HeaderText = "School ID";
            this.SchoolIDColumn.Name = "SchoolIDColumn";
            this.SchoolIDColumn.ReadOnly = true;
            this.SchoolIDColumn.Width = 120;
            // 
            // MemberTypeColumn
            // 
            this.MemberTypeColumn.DataPropertyName = "MemberType";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MemberTypeColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.MemberTypeColumn.HeaderText = "Category";
            this.MemberTypeColumn.Name = "MemberTypeColumn";
            this.MemberTypeColumn.ReadOnly = true;
            this.MemberTypeColumn.Width = 117;
            // 
            // FacultyCodeColumn
            // 
            this.FacultyCodeColumn.DataPropertyName = "FacultyCode";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FacultyCodeColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.FacultyCodeColumn.HeaderText = "Faculty";
            this.FacultyCodeColumn.Name = "FacultyCodeColumn";
            this.FacultyCodeColumn.ReadOnly = true;
            this.FacultyCodeColumn.Width = 102;
            // 
            // ContactNumberColumn
            // 
            this.ContactNumberColumn.DataPropertyName = "ContactNumber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ContactNumberColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ContactNumberColumn.HeaderText = "Contact No.";
            this.ContactNumberColumn.Name = "ContactNumberColumn";
            this.ContactNumberColumn.ReadOnly = true;
            this.ContactNumberColumn.Width = 135;
            // 
            // EmailAddressColumn
            // 
            this.EmailAddressColumn.DataPropertyName = "Email";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EmailAddressColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.EmailAddressColumn.HeaderText = "Email";
            this.EmailAddressColumn.Name = "EmailAddressColumn";
            this.EmailAddressColumn.ReadOnly = true;
            this.EmailAddressColumn.Width = 92;
            // 
            // LoanedQtyColumn
            // 
            this.LoanedQtyColumn.DataPropertyName = "LoanedQty";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LoanedQtyColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.LoanedQtyColumn.HeaderText = "Loaned Quantity";
            this.LoanedQtyColumn.Name = "LoanedQtyColumn";
            this.LoanedQtyColumn.ReadOnly = true;
            this.LoanedQtyColumn.Width = 169;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(288, 644);
            this.btnOK.Margin = new System.Windows.Forms.Padding(10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 40);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(400, 644);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 21);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Member Name:";
            // 
            // lblSchoolID
            // 
            this.lblSchoolID.AutoSize = true;
            this.lblSchoolID.BackColor = System.Drawing.Color.Transparent;
            this.lblSchoolID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolID.Location = new System.Drawing.Point(36, 75);
            this.lblSchoolID.Margin = new System.Windows.Forms.Padding(6);
            this.lblSchoolID.Name = "lblSchoolID";
            this.lblSchoolID.Size = new System.Drawing.Size(79, 21);
            this.lblSchoolID.TabIndex = 16;
            this.lblSchoolID.Text = "School ID:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(36, 115);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtbMemberName
            // 
            this.txtbMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMemberName.Location = new System.Drawing.Point(166, 32);
            this.txtbMemberName.Margin = new System.Windows.Forms.Padding(6);
            this.txtbMemberName.Name = "txtbMemberName";
            this.txtbMemberName.Size = new System.Drawing.Size(326, 29);
            this.txtbMemberName.TabIndex = 1;
            // 
            // txtbSchoolID
            // 
            this.txtbSchoolID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSchoolID.Location = new System.Drawing.Point(166, 72);
            this.txtbSchoolID.Margin = new System.Windows.Forms.Padding(6);
            this.txtbSchoolID.Name = "txtbSchoolID";
            this.txtbSchoolID.Size = new System.Drawing.Size(326, 29);
            this.txtbSchoolID.TabIndex = 2;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(166, 112);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(326, 29);
            this.txtbEmail.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(550, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(550, 91);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblSchoolID);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtbEmail);
            this.groupBox1.Controls.Add(this.txtbMemberName);
            this.groupBox1.Controls.Add(this.txtbSchoolID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(698, 157);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // toolStripStatusLblSelectedMember
            // 
            this.toolStripStatusLblSelectedMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLblSelectedMember.Name = "toolStripStatusLblSelectedMember";
            this.toolStripStatusLblSelectedMember.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLblSelectedMember.Size = new System.Drawing.Size(266, 21);
            this.toolStripStatusLblSelectedMember.Text = "Select a member or Press ESC to exit.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblSelectedMember});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(754, 26);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MemberPopUpSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SA45Team07B.Properties.Resources.greybackground3_modi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(754, 731);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridViewMemberList);
            this.Controls.Add(this.lblSelectMember);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemberPopUpSearch";
            this.Text = "Member Search";
            this.Load += new System.EventHandler(this.MemberPopUpSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMember;
        private System.Windows.Forms.DataGridView dataGridViewMemberList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSchoolID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbMemberName;
        private System.Windows.Forms.TextBox txtbSchoolID;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanedQtyColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblSelectedMember;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}