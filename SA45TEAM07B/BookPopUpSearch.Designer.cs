namespace SA45Team07B
{
    partial class BookPopUpSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDiscontinued = new System.Windows.Forms.RadioButton();
            this.rbtnAvailable = new System.Windows.Forms.RadioButton();
            this.rbtnOnLoan = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.lblAvailibility = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtbAuthor = new System.Windows.Forms.TextBox();
            this.txtbBookTitle = new System.Windows.Forms.TextBox();
            this.txtbISBN = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblSelectedBook = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewBookList = new System.Windows.Forms.DataGridView();
            this.BookIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishedYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscontinuedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(947, 1586);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 90);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnOK.Location = new System.Drawing.Point(688, 1586);
            this.btnOK.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(207, 90);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSelectBook
            // 
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBook.Location = new System.Drawing.Point(43, 605);
            this.lblSelectBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(383, 48);
            this.lblSelectBook.TabIndex = 15;
            this.lblSelectBook.Text = "Select a book from list:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtnDiscontinued);
            this.groupBox1.Controls.Add(this.rbtnAvailable);
            this.groupBox1.Controls.Add(this.rbtnOnLoan);
            this.groupBox1.Controls.Add(this.rbtnAll);
            this.groupBox1.Controls.Add(this.cbSubject);
            this.groupBox1.Controls.Add(this.lblAvailibility);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblISBN);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.txtbAuthor);
            this.groupBox1.Controls.Add(this.txtbBookTitle);
            this.groupBox1.Controls.Add(this.txtbISBN);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(45, 45, 45, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1737, 542);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // rbtnDiscontinued
            // 
            this.rbtnDiscontinued.AutoSize = true;
            this.rbtnDiscontinued.Location = new System.Drawing.Point(1022, 441);
            this.rbtnDiscontinued.Margin = new System.Windows.Forms.Padding(36, 14, 14, 14);
            this.rbtnDiscontinued.Name = "rbtnDiscontinued";
            this.rbtnDiscontinued.Size = new System.Drawing.Size(259, 52);
            this.rbtnDiscontinued.TabIndex = 8;
            this.rbtnDiscontinued.Text = "Discontinued";
            this.rbtnDiscontinued.UseVisualStyleBackColor = true;
            this.rbtnDiscontinued.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtnAvailable
            // 
            this.rbtnAvailable.AutoSize = true;
            this.rbtnAvailable.Location = new System.Drawing.Point(536, 441);
            this.rbtnAvailable.Margin = new System.Windows.Forms.Padding(36, 14, 14, 14);
            this.rbtnAvailable.Name = "rbtnAvailable";
            this.rbtnAvailable.Size = new System.Drawing.Size(193, 52);
            this.rbtnAvailable.TabIndex = 6;
            this.rbtnAvailable.Text = "Available";
            this.rbtnAvailable.UseVisualStyleBackColor = true;
            this.rbtnAvailable.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtnOnLoan
            // 
            this.rbtnOnLoan.AutoSize = true;
            this.rbtnOnLoan.Location = new System.Drawing.Point(788, 441);
            this.rbtnOnLoan.Margin = new System.Windows.Forms.Padding(36, 14, 14, 14);
            this.rbtnOnLoan.Name = "rbtnOnLoan";
            this.rbtnOnLoan.Size = new System.Drawing.Size(176, 52);
            this.rbtnOnLoan.TabIndex = 7;
            this.rbtnOnLoan.Text = "On loan";
            this.rbtnOnLoan.UseVisualStyleBackColor = true;
            this.rbtnOnLoan.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(382, 441);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(92, 52);
            this.rbtnAll.TabIndex = 5;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.White;
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.IntegralHeight = false;
            this.cbSubject.Location = new System.Drawing.Point(374, 346);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(902, 56);
            this.cbSubject.TabIndex = 4;
            this.cbSubject.SelectedValueChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAvailibility
            // 
            this.lblAvailibility.AutoSize = true;
            this.lblAvailibility.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailibility.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailibility.Location = new System.Drawing.Point(81, 441);
            this.lblAvailibility.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.lblAvailibility.Name = "lblAvailibility";
            this.lblAvailibility.Size = new System.Drawing.Size(198, 48);
            this.lblAvailibility.TabIndex = 25;
            this.lblAvailibility.Text = "Availability:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(81, 351);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(145, 48);
            this.lblSubject.TabIndex = 23;
            this.lblSubject.Text = "Subject:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(81, 76);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 48);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Book Title:";
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
            this.btnClear.Location = new System.Drawing.Point(1402, 236);
            this.btnClear.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(207, 90);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(81, 166);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(105, 48);
            this.lblISBN.TabIndex = 16;
            this.lblISBN.Text = "ISBN:";
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
            this.btnSearch.Location = new System.Drawing.Point(1402, 117);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(207, 90);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(81, 256);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(137, 48);
            this.lblAuthor.TabIndex = 17;
            this.lblAuthor.Text = "Author:";
            // 
            // txtbAuthor
            // 
            this.txtbAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAuthor.Location = new System.Drawing.Point(374, 252);
            this.txtbAuthor.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.txtbAuthor.Name = "txtbAuthor";
            this.txtbAuthor.Size = new System.Drawing.Size(902, 55);
            this.txtbAuthor.TabIndex = 3;
            // 
            // txtbBookTitle
            // 
            this.txtbBookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBookTitle.Location = new System.Drawing.Point(374, 72);
            this.txtbBookTitle.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.txtbBookTitle.Name = "txtbBookTitle";
            this.txtbBookTitle.Size = new System.Drawing.Size(902, 55);
            this.txtbBookTitle.TabIndex = 1;
            // 
            // txtbISBN
            // 
            this.txtbISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbISBN.Location = new System.Drawing.Point(374, 162);
            this.txtbISBN.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.txtbISBN.Name = "txtbISBN";
            this.txtbISBN.Size = new System.Drawing.Size(902, 55);
            this.txtbISBN.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblSelectedBook});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1682);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 25, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1811, 53);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLblSelectedBook
            // 
            this.toolStripStatusLblSelectedBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLblSelectedBook.Name = "toolStripStatusLblSelectedBook";
            this.toolStripStatusLblSelectedBook.Size = new System.Drawing.Size(557, 48);
            this.toolStripStatusLblSelectedBook.Text = "Select a book or Press ESC to exit.";
            // 
            // dataGridViewBookList
            // 
            this.dataGridViewBookList.AllowUserToAddRows = false;
            this.dataGridViewBookList.AllowUserToDeleteRows = false;
            this.dataGridViewBookList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewBookList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewBookList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBookList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookIDColumn,
            this.BookTitleColumn,
            this.RFIDColumn,
            this.AvailabilityColumn,
            this.EditionColumn,
            this.AuthorColumn,
            this.ISBNColumn,
            this.CallNumberColumn,
            this.SubjectNameColumn,
            this.PublisherNameColumn,
            this.PublishedYearColumn,
            this.PriceColumn,
            this.DiscontinuedColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewBookList.EnableHeadersVisualStyles = false;
            this.dataGridViewBookList.GridColor = System.Drawing.Color.White;
            this.dataGridViewBookList.Location = new System.Drawing.Point(32, 666);
            this.dataGridViewBookList.Margin = new System.Windows.Forms.Padding(45, 45, 45, 45);
            this.dataGridViewBookList.MultiSelect = false;
            this.dataGridViewBookList.Name = "dataGridViewBookList";
            this.dataGridViewBookList.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewBookList.RowHeadersVisible = false;
            this.dataGridViewBookList.RowHeadersWidth = 5;
            this.dataGridViewBookList.RowTemplate.Height = 24;
            this.dataGridViewBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookList.Size = new System.Drawing.Size(1739, 882);
            this.dataGridViewBookList.TabIndex = 13;
            this.dataGridViewBookList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewBookList_Scroll);
            this.dataGridViewBookList.SelectionChanged += new System.EventHandler(this.dataGridViewMemberList_SelectionChanged);
            this.dataGridViewBookList.DoubleClick += new System.EventHandler(this.btnOK_Click);
            // 
            // BookIDColumn
            // 
            this.BookIDColumn.DataPropertyName = "BookID";
            this.BookIDColumn.HeaderText = "ID";
            this.BookIDColumn.Name = "BookIDColumn";
            this.BookIDColumn.ReadOnly = true;
            this.BookIDColumn.Width = 123;
            // 
            // BookTitleColumn
            // 
            this.BookTitleColumn.DataPropertyName = "BookTitle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.BookTitleColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookTitleColumn.HeaderText = "Title";
            this.BookTitleColumn.Name = "BookTitleColumn";
            this.BookTitleColumn.ReadOnly = true;
            this.BookTitleColumn.Width = 156;
            // 
            // RFIDColumn
            // 
            this.RFIDColumn.DataPropertyName = "RFID";
            this.RFIDColumn.HeaderText = "RFID";
            this.RFIDColumn.Name = "RFIDColumn";
            this.RFIDColumn.ReadOnly = true;
            this.RFIDColumn.Width = 163;
            // 
            // AvailabilityColumn
            // 
            this.AvailabilityColumn.DataPropertyName = "Availability";
            this.AvailabilityColumn.HeaderText = "Availability";
            this.AvailabilityColumn.Name = "AvailabilityColumn";
            this.AvailabilityColumn.ReadOnly = true;
            this.AvailabilityColumn.Width = 258;
            // 
            // EditionColumn
            // 
            this.EditionColumn.DataPropertyName = "Edition";
            this.EditionColumn.HeaderText = "Edition";
            this.EditionColumn.Name = "EditionColumn";
            this.EditionColumn.ReadOnly = true;
            this.EditionColumn.Width = 198;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.DataPropertyName = "Author";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AuthorColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.AuthorColumn.HeaderText = "Author";
            this.AuthorColumn.Name = "AuthorColumn";
            this.AuthorColumn.ReadOnly = true;
            this.AuthorColumn.Width = 197;
            // 
            // ISBNColumn
            // 
            this.ISBNColumn.DataPropertyName = "ISBN";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ISBNColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ISBNColumn.HeaderText = "ISBN";
            this.ISBNColumn.Name = "ISBNColumn";
            this.ISBNColumn.ReadOnly = true;
            this.ISBNColumn.Width = 165;
            // 
            // CallNumberColumn
            // 
            this.CallNumberColumn.DataPropertyName = "CallNumber";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CallNumberColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.CallNumberColumn.HeaderText = "Call No.";
            this.CallNumberColumn.Name = "CallNumberColumn";
            this.CallNumberColumn.ReadOnly = true;
            this.CallNumberColumn.Width = 212;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.DataPropertyName = "SubjectName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubjectNameColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.SubjectNameColumn.HeaderText = "Subject";
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            this.SubjectNameColumn.Width = 205;
            // 
            // PublisherNameColumn
            // 
            this.PublisherNameColumn.DataPropertyName = "PublisherName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PublisherNameColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.PublisherNameColumn.HeaderText = "Publisher";
            this.PublisherNameColumn.Name = "PublisherNameColumn";
            this.PublisherNameColumn.ReadOnly = true;
            this.PublisherNameColumn.Width = 234;
            // 
            // PublishedYearColumn
            // 
            this.PublishedYearColumn.DataPropertyName = "PublishedYear";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PublishedYearColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.PublishedYearColumn.HeaderText = "Published Year";
            this.PublishedYearColumn.Name = "PublishedYearColumn";
            this.PublishedYearColumn.ReadOnly = true;
            this.PublishedYearColumn.Width = 319;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = "0.00";
            this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 166;
            // 
            // DiscontinuedColumn
            // 
            this.DiscontinuedColumn.DataPropertyName = "Discontinued";
            this.DiscontinuedColumn.HeaderText = "Discontinued";
            this.DiscontinuedColumn.Name = "DiscontinuedColumn";
            this.DiscontinuedColumn.ReadOnly = true;
            this.DiscontinuedColumn.Width = 296;
            // 
            // BookPopUpSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SA45Team07B.Properties.Resources.greybackground3_modi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1811, 1735);
            this.Controls.Add(this.dataGridViewBookList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSelectBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookPopUpSearch";
            this.Text = "Book Search";
            this.Load += new System.EventHandler(this.BookPopUpSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSelectBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtbAuthor;
        private System.Windows.Forms.TextBox txtbBookTitle;
        private System.Windows.Forms.TextBox txtbISBN;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblAvailibility;
        private System.Windows.Forms.RadioButton rbtnAvailable;
        private System.Windows.Forms.RadioButton rbtnOnLoan;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblSelectedBook;
        private System.Windows.Forms.DataGridView dataGridViewBookList;
        private System.Windows.Forms.RadioButton rbtnDiscontinued;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailabilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishedYearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscontinuedColumn;
    }
}