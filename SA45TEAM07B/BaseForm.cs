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

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
