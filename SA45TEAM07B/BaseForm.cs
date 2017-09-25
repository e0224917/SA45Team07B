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





        private void toolStripButtonBorrow_Click(object sender, EventArgs e)
        {
            
        }


        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIconForClose.ShowBalloonTip(200, "", "Library Management has been closed.", ToolTipIcon.None);
            this.notifyIconForClose.Icon = null;
        }
    }
}
