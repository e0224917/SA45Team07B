namespace SA45Team07B
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnBorrow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Transaction = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindBk = new System.Windows.Forms.Button();
            this.btnModifyBooks = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.btnModifyMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Transaction.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
            this.btnBorrow.Location = new System.Drawing.Point(97, 29);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(135, 58);
            this.btnBorrow.TabIndex = 10;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Transaction
            // 
            this.Transaction.BackColor = System.Drawing.Color.Transparent;
            this.Transaction.Controls.Add(this.btnReturn);
            this.Transaction.Controls.Add(this.btnBorrow);
            this.Transaction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.Location = new System.Drawing.Point(30, 92);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(549, 104);
            this.Transaction.TabIndex = 16;
            this.Transaction.TabStop = false;
            this.Transaction.Text = "Transactions";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(308, 29);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(135, 58);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnFindBk);
            this.groupBox2.Controls.Add(this.btnModifyBooks);
            this.groupBox2.Controls.Add(this.btnAddBooks);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 104);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books";
            // 
            // btnFindBk
            // 
            this.btnFindBk.BackColor = System.Drawing.Color.Transparent;
            this.btnFindBk.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnFindBk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFindBk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnFindBk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindBk.ForeColor = System.Drawing.Color.Black;
            this.btnFindBk.Image = ((System.Drawing.Image)(resources.GetObject("btnFindBk.Image")));
            this.btnFindBk.Location = new System.Drawing.Point(382, 29);
            this.btnFindBk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindBk.Name = "btnFindBk";
            this.btnFindBk.Size = new System.Drawing.Size(111, 58);
            this.btnFindBk.TabIndex = 15;
            this.btnFindBk.Text = "Find";
            this.btnFindBk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindBk.UseVisualStyleBackColor = false;
            this.btnFindBk.Click += new System.EventHandler(this.btnFindBk_Click);
            // 
            // btnModifyBooks
            // 
            this.btnModifyBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyBooks.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnModifyBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModifyBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnModifyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyBooks.ForeColor = System.Drawing.Color.Black;
            this.btnModifyBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyBooks.Image")));
            this.btnModifyBooks.Location = new System.Drawing.Point(218, 29);
            this.btnModifyBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifyBooks.Name = "btnModifyBooks";
            this.btnModifyBooks.Size = new System.Drawing.Size(111, 58);
            this.btnModifyBooks.TabIndex = 14;
            this.btnModifyBooks.Text = "Modify";
            this.btnModifyBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifyBooks.UseVisualStyleBackColor = false;
            this.btnModifyBooks.Click += new System.EventHandler(this.btnModifyBooks_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBooks.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnAddBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooks.ForeColor = System.Drawing.Color.Black;
            this.btnAddBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBooks.Image")));
            this.btnAddBooks.Location = new System.Drawing.Point(55, 29);
            this.btnAddBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(111, 58);
            this.btnAddBooks.TabIndex = 13;
            this.btnAddBooks.Text = "Add";
            this.btnAddBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBooks.UseVisualStyleBackColor = false;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnFindMember);
            this.groupBox3.Controls.Add(this.btnModifyMember);
            this.groupBox3.Controls.Add(this.btnAddMember);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 104);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Members";
            // 
            // btnFindMember
            // 
            this.btnFindMember.BackColor = System.Drawing.Color.Transparent;
            this.btnFindMember.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnFindMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFindMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnFindMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMember.ForeColor = System.Drawing.Color.Black;
            this.btnFindMember.Image = ((System.Drawing.Image)(resources.GetObject("btnFindMember.Image")));
            this.btnFindMember.Location = new System.Drawing.Point(382, 29);
            this.btnFindMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(111, 58);
            this.btnFindMember.TabIndex = 18;
            this.btnFindMember.Text = "Find";
            this.btnFindMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindMember.UseVisualStyleBackColor = false;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // btnModifyMember
            // 
            this.btnModifyMember.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyMember.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnModifyMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModifyMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnModifyMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMember.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMember.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMember.Image")));
            this.btnModifyMember.Location = new System.Drawing.Point(218, 29);
            this.btnModifyMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifyMember.Name = "btnModifyMember";
            this.btnModifyMember.Size = new System.Drawing.Size(111, 58);
            this.btnModifyMember.TabIndex = 17;
            this.btnModifyMember.Text = "Modify";
            this.btnModifyMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifyMember.UseVisualStyleBackColor = false;
            this.btnModifyMember.Click += new System.EventHandler(this.btnModifyMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.Black;
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.Location = new System.Drawing.Point(55, 29);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(111, 58);
            this.btnAddMember.TabIndex = 16;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.Peru;
            this.Welcome.Location = new System.Drawing.Point(786, 415);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(246, 40);
            this.Welcome.TabIndex = 18;
            this.Welcome.Text = "SA45 TEAM 07B";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1062, 537);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Transaction);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashBoard";
            this.Controls.SetChildIndex(this.Transaction, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.Welcome, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Transaction.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Transaction;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFindBk;
        private System.Windows.Forms.Button btnModifyBooks;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Button btnModifyMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label Welcome;
    }
}
