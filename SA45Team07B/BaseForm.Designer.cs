namespace SA45Team07B
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.recordLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.crosstabReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconForClose = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBorrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 9);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PapayaWhip;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.findToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1506, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.toolStripMenuItem1,
            this.recordLossToolStripMenuItem,
            this.adjustStockToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.managementToolStripMenuItem.Text = "Transaction";
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.borrowToolStripMenuItem.Text = "Borrow";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 6);
            // 
            // recordLossToolStripMenuItem
            // 
            this.recordLossToolStripMenuItem.Name = "recordLossToolStripMenuItem";
            this.recordLossToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.recordLossToolStripMenuItem.Text = "Record Lost Book";
            // 
            // adjustStockToolStripMenuItem
            // 
            this.adjustStockToolStripMenuItem.Name = "adjustStockToolStripMenuItem";
            this.adjustStockToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.adjustStockToolStripMenuItem.Text = "Adjust Stock";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem1,
            this.transactionToolStripMenuItem2});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // informationToolStripMenuItem1
            // 
            this.informationToolStripMenuItem1.Name = "informationToolStripMenuItem1";
            this.informationToolStripMenuItem1.Size = new System.Drawing.Size(193, 32);
            this.informationToolStripMenuItem1.Text = "Information";
            // 
            // transactionToolStripMenuItem2
            // 
            this.transactionToolStripMenuItem2.Name = "transactionToolStripMenuItem2";
            this.transactionToolStripMenuItem2.Size = new System.Drawing.Size(193, 32);
            this.transactionToolStripMenuItem2.Text = "Transaction";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem1,
            this.memberToolStripMenuItem1,
            this.publisherToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.modifyInformationToolStripMenuItem});
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(170, 32);
            this.bookToolStripMenuItem1.Text = "Book";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(261, 32);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // modifyInformationToolStripMenuItem
            // 
            this.modifyInformationToolStripMenuItem.Name = "modifyInformationToolStripMenuItem";
            this.modifyInformationToolStripMenuItem.Size = new System.Drawing.Size(261, 32);
            this.modifyInformationToolStripMenuItem.Text = "Modify Information";
            // 
            // memberToolStripMenuItem1
            // 
            this.memberToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.modifyInformationToolStripMenuItem1});
            this.memberToolStripMenuItem1.Name = "memberToolStripMenuItem1";
            this.memberToolStripMenuItem1.Size = new System.Drawing.Size(170, 32);
            this.memberToolStripMenuItem1.Text = "Member";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(261, 32);
            this.addNewToolStripMenuItem1.Text = "Add New";
            // 
            // modifyInformationToolStripMenuItem1
            // 
            this.modifyInformationToolStripMenuItem1.Name = "modifyInformationToolStripMenuItem1";
            this.modifyInformationToolStripMenuItem1.Size = new System.Drawing.Size(261, 32);
            this.modifyInformationToolStripMenuItem1.Text = "Modify Information";
            // 
            // publisherToolStripMenuItem
            // 
            this.publisherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem2,
            this.modifiyInformationToolStripMenuItem});
            this.publisherToolStripMenuItem.Name = "publisherToolStripMenuItem";
            this.publisherToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.publisherToolStripMenuItem.Text = "Publisher";
            // 
            // addNewToolStripMenuItem2
            // 
            this.addNewToolStripMenuItem2.Name = "addNewToolStripMenuItem2";
            this.addNewToolStripMenuItem2.Size = new System.Drawing.Size(266, 32);
            this.addNewToolStripMenuItem2.Text = "Add New";
            // 
            // modifiyInformationToolStripMenuItem
            // 
            this.modifiyInformationToolStripMenuItem.Name = "modifiyInformationToolStripMenuItem";
            this.modifiyInformationToolStripMenuItem.Size = new System.Drawing.Size(266, 32);
            this.modifiyInformationToolStripMenuItem.Text = "Modifiy Information";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookListToolStripMenuItem,
            this.memberListToolStripMenuItem,
            this.transactionListToolStripMenuItem,
            this.toolStripMenuItem2,
            this.crosstabReportToolStripMenuItem,
            this.chartReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.bookListToolStripMenuItem.Text = "Book List";
            // 
            // memberListToolStripMenuItem
            // 
            this.memberListToolStripMenuItem.Name = "memberListToolStripMenuItem";
            this.memberListToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.memberListToolStripMenuItem.Text = "Member List";
            // 
            // transactionListToolStripMenuItem
            // 
            this.transactionListToolStripMenuItem.Name = "transactionListToolStripMenuItem";
            this.transactionListToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.transactionListToolStripMenuItem.Text = "Transaction List";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(240, 6);
            // 
            // crosstabReportToolStripMenuItem
            // 
            this.crosstabReportToolStripMenuItem.Name = "crosstabReportToolStripMenuItem";
            this.crosstabReportToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.crosstabReportToolStripMenuItem.Text = "[cross-tab report]";
            // 
            // chartReportToolStripMenuItem
            // 
            this.chartReportToolStripMenuItem.Name = "chartReportToolStripMenuItem";
            this.chartReportToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.chartReportToolStripMenuItem.Text = "[chart report]";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutKeysToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // shortcutKeysToolStripMenuItem
            // 
            this.shortcutKeysToolStripMenuItem.Name = "shortcutKeysToolStripMenuItem";
            this.shortcutKeysToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.shortcutKeysToolStripMenuItem.Text = "Shortcut Keys";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(207, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // notifyIconForClose
            // 
            this.notifyIconForClose.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconForClose.Icon")));
            this.notifyIconForClose.Text = "notifyIconForMinimize";
            this.notifyIconForClose.Visible = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(164)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBorrow,
            this.toolStripButtonReturn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1506, 35);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBorrow
            // 
            this.toolStripButtonBorrow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBorrow.Image")));
            this.toolStripButtonBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBorrow.Name = "toolStripButtonBorrow";
            this.toolStripButtonBorrow.Size = new System.Drawing.Size(99, 32);
            this.toolStripButtonBorrow.Text = "Borrow";
            this.toolStripButtonBorrow.Click += new System.EventHandler(this.toolStripButtonBorrow_Click);
            // 
            // toolStripButtonReturn
            // 
            this.toolStripButtonReturn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReturn.Image")));
            this.toolStripButtonReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReturn.Name = "toolStripButtonReturn";
            this.toolStripButtonReturn.Size = new System.Drawing.Size(93, 32);
            this.toolStripButtonReturn.Text = "Return";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(124, 32);
            this.toolStripButton1.Text = "Find Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(769, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 74);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to our library system. \r\nSelect a menu button to proceed.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1506, 823);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main - Library Management System SA45Team07B";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseForm_FormClosed);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recordLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem crosstabReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconForClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBorrow;
        private System.Windows.Forms.ToolStripButton toolStripButtonReturn;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem publisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modifiyInformationToolStripMenuItem;
        public System.Windows.Forms.Label label1;
    }
}

