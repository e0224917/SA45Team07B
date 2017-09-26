using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class BorrowForm : SA45Team07B.BaseForm
    {
        public BorrowForm()
        {
            InitializeComponent();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string[] list = new string[] { "101B0ACB45" };
            DataService.CreateBorrowTransaction(list, 10);
        }
    }
}
