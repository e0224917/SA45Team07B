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

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            //this.notifyIconForMinimize.ShowBalloonTip(200, "", "Library Management is still running.", ToolTipIcon.None);
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        //private void CloseButton_Click(object sender, EventArgs e)
        //{
        //    this.notifyIconForClose.ShowBalloonTip(200, "", "Library Management has been closed.", ToolTipIcon.None);
        //    this.Close();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        /*
        #region DO NOT REMOVE: Drag Borderless Form from Title bar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        */

        private void toolStripButtonBorrow_Click(object sender, EventArgs e)
        {
            
        }

            private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIconForClose.ShowBalloonTip(200, "", "Library Management has been closed.", ToolTipIcon.None);          
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(this is AddNewBook)
            {
                AddNewPublisher form = new AddNewPublisher();
                form.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    ((AddNewBook)this).LoadPublisherList();
                }
            }
            
        }
    }
}
