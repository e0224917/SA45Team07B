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
            this.cboxReason = new System.Windows.Forms.ComboBox();
            this.btnMoreRFID = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.epRFID)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.BackColor = System.Drawing.Color.Transparent;
            this.lblRFID.Location = new System.Drawing.Point(15, 25);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(43, 21);
            this.lblRFID.TabIndex = 10;
            this.lblRFID.Text = "RFID";
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(113, 22);
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
            this.lblBookTitle.Location = new System.Drawing.Point(15, 66);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(78, 21);
            this.lblBookTitle.TabIndex = 12;
            this.lblBookTitle.Text = "Book Title";
            // 
            // txtbBookTitle
            // 
            this.txtbBookTitle.Location = new System.Drawing.Point(113, 63);
            this.txtbBookTitle.Name = "txtbBookTitle";
            this.txtbBookTitle.ReadOnly = true;
            this.txtbBookTitle.Size = new System.Drawing.Size(238, 29);
            this.txtbBookTitle.TabIndex = 13;
            // 
            // txtbRemarks
            // 
            this.txtbRemarks.Enabled = false;
            this.txtbRemarks.Location = new System.Drawing.Point(113, 171);
            this.txtbRemarks.MaxLength = 255;
            this.txtbRemarks.Multiline = true;
            this.txtbRemarks.Name = "txtbRemarks";
            this.txtbRemarks.Size = new System.Drawing.Size(238, 86);
            this.txtbRemarks.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Location = new System.Drawing.Point(15, 137);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(61, 21);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Reason";
            // 
            // lblDiscontinue
            // 
            this.lblDiscontinue.AutoSize = true;
            this.lblDiscontinue.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscontinue.Location = new System.Drawing.Point(15, 104);
            this.lblDiscontinue.Name = "lblDiscontinue";
            this.lblDiscontinue.Size = new System.Drawing.Size(99, 21);
            this.lblDiscontinue.TabIndex = 16;
            this.lblDiscontinue.Text = "Discontinue?";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.BackColor = System.Drawing.Color.Transparent;
            this.rbYes.Enabled = false;
            this.rbYes.Location = new System.Drawing.Point(113, 104);
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
            this.rbNo.Enabled = false;
            this.rbNo.Location = new System.Drawing.Point(170, 104);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(49, 25);
            this.rbNo.TabIndex = 18;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(98, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 34);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 296);
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
            // cboxReason
            // 
            this.cboxReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxReason.Enabled = false;
            this.cboxReason.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxReason.FormattingEnabled = true;
            this.cboxReason.Items.AddRange(new object[] {
            "Lost",
            "Damaged",
            "Other"});
            this.cboxReason.Location = new System.Drawing.Point(113, 136);
            this.cboxReason.Name = "cboxReason";
            this.cboxReason.Size = new System.Drawing.Size(100, 29);
            this.cboxReason.TabIndex = 21;
            this.cboxReason.SelectedIndexChanged += new System.EventHandler(this.cboxReason_SelectedIndexChanged);
            // 
            // btnMoreRFID
            // 
            this.btnMoreRFID.CausesValidation = false;
            this.btnMoreRFID.Location = new System.Drawing.Point(322, 22);
            this.btnMoreRFID.Name = "btnMoreRFID";
            this.btnMoreRFID.Size = new System.Drawing.Size(29, 29);
            this.btnMoreRFID.TabIndex = 22;
            this.btnMoreRFID.Text = "...";
            this.btnMoreRFID.UseVisualStyleBackColor = true;
            this.btnMoreRFID.Click += new System.EventHandler(this.btnMoreRFID_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblRFID);
            this.groupBox.Controls.Add(this.cboxReason);
            this.groupBox.Controls.Add(this.btnMoreRFID);
            this.groupBox.Controls.Add(this.txtbRemarks);
            this.groupBox.Controls.Add(this.txtRFID);
            this.groupBox.Controls.Add(this.lblBookTitle);
            this.groupBox.Controls.Add(this.lblNotes);
            this.groupBox.Controls.Add(this.rbNo);
            this.groupBox.Controls.Add(this.txtbBookTitle);
            this.groupBox.Controls.Add(this.rbYes);
            this.groupBox.Controls.Add(this.lblDiscontinue);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(366, 277);
            this.groupBox.TabIndex = 23;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Input";
            // 
            // AdjustStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(388, 337);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdjustStock";
            this.Text = "Stock Adjustment";
            ((System.ComponentModel.ISupportInitialize)(this.epRFID)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cboxReason;
        private System.Windows.Forms.Button btnMoreRFID;
        private System.Windows.Forms.GroupBox groupBox;
    }
}
