namespace SA45Team07B
{
    partial class AdjustStock
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
            this.lblRFID = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtbBookTitle = new System.Windows.Forms.TextBox();
            this.txtbRemarks = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblDiscontinue = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epRFID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epRFID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.BackColor = System.Drawing.Color.Transparent;
            this.lblRFID.Location = new System.Drawing.Point(133, 146);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(43, 21);
            this.lblRFID.TabIndex = 10;
            this.lblRFID.Text = "RFID";
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(231, 143);
            this.txtRFID.MaxLength = 10;
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(100, 29);
            this.txtRFID.TabIndex = 11;
            this.txtRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            this.txtRFID.Validating += new System.ComponentModel.CancelEventHandler(this.txtRFID_Validating);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Location = new System.Drawing.Point(133, 185);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(78, 21);
            this.lblBookTitle.TabIndex = 12;
            this.lblBookTitle.Text = "Book Title";
            // 
            // txtbBookTitle
            // 
            this.txtbBookTitle.Location = new System.Drawing.Point(231, 182);
            this.txtbBookTitle.Name = "txtbBookTitle";
            this.txtbBookTitle.ReadOnly = true;
            this.txtbBookTitle.Size = new System.Drawing.Size(321, 29);
            this.txtbBookTitle.TabIndex = 13;
            // 
            // txtbRemarks
            // 
            this.txtbRemarks.Location = new System.Drawing.Point(231, 262);
            this.txtbRemarks.MaxLength = 255;
            this.txtbRemarks.Multiline = true;
            this.txtbRemarks.Name = "txtbRemarks";
            this.txtbRemarks.Size = new System.Drawing.Size(440, 230);
            this.txtbRemarks.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Location = new System.Drawing.Point(133, 262);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 21);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Notes";
            // 
            // lblDiscontinue
            // 
            this.lblDiscontinue.AutoSize = true;
            this.lblDiscontinue.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscontinue.Location = new System.Drawing.Point(133, 220);
            this.lblDiscontinue.Name = "lblDiscontinue";
            this.lblDiscontinue.Size = new System.Drawing.Size(99, 21);
            this.lblDiscontinue.TabIndex = 16;
            this.lblDiscontinue.Text = "Discontinue?";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.BackColor = System.Drawing.Color.Transparent;
            this.rbYes.Location = new System.Drawing.Point(231, 220);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(51, 25);
            this.rbYes.TabIndex = 17;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.Color.Transparent;
            this.rbNo.Location = new System.Drawing.Point(288, 220);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(49, 25);
            this.rbNo.TabIndex = 18;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(231, 525);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 34);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(332, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epRFID
            // 
            this.epRFID.ContainerControl = this;
            // 
            // AdjustStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1436, 823);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.lblDiscontinue);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtbRemarks);
            this.Controls.Add(this.txtbBookTitle);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.lblRFID);
            this.Name = "AdjustStock";
            this.Controls.SetChildIndex(this.lblRFID, 0);
            this.Controls.SetChildIndex(this.txtRFID, 0);
            this.Controls.SetChildIndex(this.lblBookTitle, 0);
            this.Controls.SetChildIndex(this.txtbBookTitle, 0);
            this.Controls.SetChildIndex(this.txtbRemarks, 0);
            this.Controls.SetChildIndex(this.lblNotes, 0);
            this.Controls.SetChildIndex(this.lblDiscontinue, 0);
            this.Controls.SetChildIndex(this.rbYes, 0);
            this.Controls.SetChildIndex(this.rbNo, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.epRFID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtbBookTitle;
        private System.Windows.Forms.TextBox txtbRemarks;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblDiscontinue;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epRFID;
    }
}
