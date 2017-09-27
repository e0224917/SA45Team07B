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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.epRFID)).BeginInit();
            this.groupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.BackColor = System.Drawing.Color.Transparent;
            this.lblRFID.Location = new System.Drawing.Point(13, 142);
            this.lblRFID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(103, 48);
            this.lblRFID.TabIndex = 10;
            this.lblRFID.Text = "RFID:";
            // 
            // txtbRFID
            // 
            this.txtbRFID.Location = new System.Drawing.Point(231, 135);
            this.txtbRFID.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtbRFID.MaxLength = 10;
            this.txtbRFID.Name = "txtbRFID";
            this.txtbRFID.Size = new System.Drawing.Size(446, 55);
            this.txtbRFID.TabIndex = 11;
            this.txtbRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            this.txtbRFID.Validating += new System.ComponentModel.CancelEventHandler(this.txtRFID_Validating);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Location = new System.Drawing.Point(13, 238);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(187, 48);
            this.lblBookTitle.TabIndex = 12;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // txtbBookTitle
            // 
            this.txtbBookTitle.Location = new System.Drawing.Point(231, 231);
            this.txtbBookTitle.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtbBookTitle.Name = "txtbBookTitle";
            this.txtbBookTitle.ReadOnly = true;
            this.txtbBookTitle.Size = new System.Drawing.Size(524, 55);
            this.txtbBookTitle.TabIndex = 13;
            // 
            // txtbRemarks
            // 
            this.txtbRemarks.Enabled = false;
            this.txtbRemarks.Location = new System.Drawing.Point(231, 439);
            this.txtbRemarks.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtbRemarks.MaxLength = 255;
            this.txtbRemarks.Multiline = true;
            this.txtbRemarks.Name = "txtbRemarks";
            this.txtbRemarks.Size = new System.Drawing.Size(524, 191);
            this.txtbRemarks.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Location = new System.Drawing.Point(13, 341);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(142, 48);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Reason:";
            // 
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.BackColor = System.Drawing.Color.Transparent;
            this.rbRemove.Checked = true;
            this.rbRemove.Location = new System.Drawing.Point(231, 57);
            this.rbRemove.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(179, 52);
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
            this.rbRestore.Location = new System.Drawing.Point(491, 57);
            this.rbRestore.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.rbRestore.Name = "rbRestore";
            this.rbRestore.Size = new System.Drawing.Size(171, 52);
            this.rbRestore.TabIndex = 18;
            this.rbRestore.Text = "Restore";
            this.rbRestore.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(227, 715);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(173, 78);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(464, 718);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 75);
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
            this.cboxReason.Location = new System.Drawing.Point(231, 334);
            this.cboxReason.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cboxReason.Name = "cboxReason";
            this.cboxReason.Size = new System.Drawing.Size(524, 56);
            this.cboxReason.TabIndex = 21;
            this.cboxReason.SelectedIndexChanged += new System.EventHandler(this.cboxReason_SelectedIndexChanged);
            // 
            // btnMoreRFID
            // 
            this.btnMoreRFID.BackColor = System.Drawing.Color.White;
            this.btnMoreRFID.CausesValidation = false;
            this.btnMoreRFID.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnMoreRFID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMoreRFID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreRFID.Location = new System.Drawing.Point(691, 129);
            this.btnMoreRFID.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnMoreRFID.Name = "btnMoreRFID";
            this.btnMoreRFID.Size = new System.Drawing.Size(64, 66);
            this.btnMoreRFID.TabIndex = 22;
            this.btnMoreRFID.Text = "...";
            this.btnMoreRFID.UseVisualStyleBackColor = false;
            this.btnMoreRFID.Click += new System.EventHandler(this.btnMoreRFID_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBox.Location = new System.Drawing.Point(27, 27);
            this.groupBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox.Size = new System.Drawing.Size(813, 674);
            this.groupBox.TabIndex = 23;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Stock Adjustment";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(13, 62);
            this.lblAction.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(130, 48);
            this.lblAction.TabIndex = 23;
            this.lblAction.Text = "Action:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 768);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(876, 53);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(221, 48);
            this.toolStripStatusLabel1.Text = "Adjust stock.";
            // 
            // AdjustStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(876, 821);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.Name = "AdjustStock";
            this.Text = "Stock Adjustment";
            this.Load += new System.EventHandler(this.AdjustStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epRFID)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
