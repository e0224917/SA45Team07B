using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SA45Team07B
{
    public partial class DashBoard : SA45Team07B.BaseForm
    {
        private SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

        public SA45Team07B_LibraryEntities Context
        {
            get
            {
                return context;
            }
        }

        public DashBoard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowForm borrowform = new BorrowForm();
            borrowform.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnForm returnform = new SA45Team07B.ReturnForm();
            returnform.ShowDialog();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            AddNewBook addbk = new AddNewBook();
            addbk.ShowDialog();
        }

        private void btnModifyBooks_Click(object sender, EventArgs e)
        {
            ModifyBook modifybk = new ModifyBook();
            modifybk.ShowDialog();
        }

        private void btnFindBk_Click(object sender, EventArgs e)
        {
            BookInfo findbk = new BookInfo();
            findbk.ShowDialog();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddNewMember addmbr = new AddNewMember();
            addmbr.ShowDialog();
        }

        private void btnModifyMember_Click(object sender, EventArgs e)
        {
            ModifyMember modifymbr = new ModifyMember();
            modifymbr.ShowDialog();
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            MemberInfo findmbr = new MemberInfo();
            findmbr.ShowDialog();
        }
    }
}
