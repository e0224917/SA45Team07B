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
            this.txtbRFID = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtbBookTitle = new System.Windows.Forms.TextBox();
            this.txtbRemarks = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.rbRestore = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epRFID = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboxReason = new System.Windows.Forms.ComboBox();
            this.btnMoreRFID = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epRFID)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.BackColor = System.Drawing.Color.Transparent;
            this.lblRFID.Location = new System.Drawing.Point(6, 62);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(43, 21);
            this.lblRFID.TabIndex = 10;
            this.lblRFID.Text = "RFID";
            // 
            // txtbRFID
            // 
            this.txtbRFID.Location = new System.Drawing.Point(104, 59);
            this.txtbRFID.MaxLength = 10;
            this.txtbRFID.Name = "txtbRFID";
            this.txtbRFID.Size = new System.Drawing.Size(100, 29);
            this.txtbRFID.TabIndex = 11;
            this.txtbRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            this.txtbRFID.Validating += new System.ComponentModel.CancelEventHandler(this.txtRFID_Validating);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Location = new System.Drawing.Point(6, 104);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(78, 21);
            this.lblBookTitle.TabIndex = 12;
            this.lblBookTitle.Text = "Book Title";
            // 
            // txtbBookTitle
            // 
            this.txtbBookTitle.Location = new System.Drawing.Point(104, 101);
            this.txtbBookTitle.Name = "txtbBookTitle";
            this.txtbBookTitle.ReadOnly = true;
            this.txtbBookTitle.Size = new System.Drawing.Size(238, 29);
            this.txtbBookTitle.TabIndex = 13;
            // 
            // txtbRemarks
            // 
            this.txtbRemarks.Enabled = false;
            this.txtbRemarks.Location = new System.Drawing.Point(104, 192);
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
            this.lblNotes.Location = new System.Drawing.Point(6, 149);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(61, 21);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Reason";
            // 
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.BackColor = System.Drawing.Color.Transparent;
            this.rbRemove.Checked = true;
            this.rbRemove.Location = new System.Drawing.Point(104, 25);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(85, 25);
            this.rbRemove.TabIndex = 17;
            this.rbRemove.TabStop = true;
            this.rbRemove.Text = "Remove";
            this.rbRemove.UseVisualStyleBackColor = false;
            this.rbRemove.CheckedChanged += new System.EventHandler(this.rbRemove_CheckedChanged);
            // 
            // rbRestore
            // 
            this.rbRestore.AutoSize = true;
            this.rbRestore.BackColor = System.Drawing.Color.Transparent;
            this.rbRestore.Location = new System.Drawing.Point(221, 25);
            this.rbRestore.Name = "rbRestore";
            this.rbRestore.Size = new System.Drawing.Size(81, 25);
            this.rbRestore.TabIndex = 18;
            this.rbRestore.Text = "Restore";
            this.rbRestore.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(102, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 34);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 314);
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
            this.cboxReason.Location = new System.Drawing.Point(104, 146);
            this.cboxReason.Name = "cboxReason";
            this.cboxReason.Size = new System.Drawing.Size(100, 29);
            this.cboxReason.TabIndex = 21;
            this.cboxReason.SelectedIndexChanged += new System.EventHandler(this.cboxReason_SelectedIndexChanged);
            // 
            // btnMoreRFID
            // 
            this.btnMoreRFID.CausesValidation = false;
            this.btnMoreRFID.Location = new System.Drawing.Point(313, 59);
            this.btnMoreRFID.Name = "btnMoreRFID";
            this.btnMoreRFID.Size = new System.Drawing.Size(29, 29);
            this.btnMoreRFID.TabIndex = 22;
            this.btnMoreRFID.Text = "...";
            this.btnMoreRFID.UseVisualStyleBackColor = true;
            this.btnMoreRFID.Click += new System.EventHandler(this.btnMoreRFID_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblAction);
            this.groupBox.Controls.Add(this.lblRFID);
            this.groupBox.Controls.Add(this.cboxReason);
            this.groupBox.Controls.Add(this.btnMoreRFID);
            this.groupBox.Controls.Add(this.txtbRemarks);
            this.groupBox.Controls.Add(this.txtbRFID);
            this.groupBox.Controls.Add(this.lblBookTitle);
            this.groupBox.Controls.Add(this.lblNotes);
            this.groupBox.Controls.Add(this.rbRestore);
            this.groupBox.Controls.Add(this.txtbBookTitle);
            this.groupBox.Controls.Add(this.rbRemove);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(366, 295);
            this.groupBox.TabIndex = 23;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Stock Adjustment";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(6, 27);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(54, 21);
            this.lblAction.TabIndex = 23;
            this.lblAction.Text = "Action";
            // 
            // AdjustStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(394, 359);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdjustStock";
            this.Text = "Stock Adjustment";
            this.Load += new System.EventHandler(this.AdjustStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epRFID)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.TextBox txtbRFID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtbBookTitle;
        private System.Windows.Forms.TextBox txtbRemarks;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RadioButton rbRemove;
        private System.Windows.Forms.RadioButton rbRestore;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epRFID;
        private System.Windows.Forms.ComboBox cboxReason;
        private System.Windows.Forms.Button btnMoreRFID;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblAction;
    }
}
