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
            dataGridView1.DataSource = Context.Members.ToList();
        
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
