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
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtbMemberID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(71, 91);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(88, 21);
            this.lblMemberID.TabIndex = 10;
            this.lblMemberID.Text = "Member ID";
            // 
            // txtbMemberID
            // 
            this.txtbMemberID.Location = new System.Drawing.Point(165, 88);
            this.txtbMemberID.Name = "txtbMemberID";
            this.txtbMemberID.Size = new System.Drawing.Size(100, 29);
            this.txtbMemberID.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(270, 287);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(853, 424);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BorrowForm";
            this.Text = "Borrow - Library Management System SA45Team07B";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMemberID, 0);
            this.Controls.SetChildIndex(this.txtbMemberID, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtbMemberID;
        private System.Windows.Forms.Button btnSubmit;
    }
}
