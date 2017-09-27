using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class BaseForm : Form
    {


        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIconLibraryManagement.ShowBalloonTip(100, "", "Library Management has been closed.", ToolTipIcon.None);
            this.notifyIconLibraryManagement.Visible = false;
            this.notifyIconLibraryManagement.Dispose();
        }

        private void notifyIconLibraryManagement_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowForm borrowform = new BorrowForm();
            borrowform.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm returnform = new ReturnForm();
            returnform.ShowDialog();
        }

        private void recordLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordLost recordlost = new RecordLost();
            recordlost.ShowDialog();
        }

        private void adjustStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdjustStock adjuststock = new AdjustStock();
            adjuststock.ShowDialog();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInfo bookinfo = new BookInfo();
            bookinfo.ShowDialog();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberPopUpSearch memberpopupsearch = new MemberPopUpSearch();
            memberpopupsearch.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBook addnewbook = new AddNewBook();
            addnewbook.ShowDialog();
        }

        private void modifyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyBook modifybook = new ModifyBook();
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewMember addnewmember = new AddNewMember();
        }


    }
}
