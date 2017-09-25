using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class BookPopUpSearch : Form
    {
        private SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

        private Book book;
        private RFIDTag tag;
        
        public Book Book
        {
            get
            {
                return book;
            }
        } 

        public RFIDTag RFID
        {
            get
            {
                return tag;
            }
        }

        public BookPopUpSearch()
        {
            InitializeComponent();
        }

        private void BookPopUpSearch_Load(object sender, EventArgs e)
        {
            var query = from x in context.RFIDs
                        orderby x.BookID ascending
                        select new { x.Books.BookID, x.Books.BookTitle, x.Books.BookSubjects.SubjectName, x.RFID, x.Availability };

            dataGridViewBookList.DataSource = query.ToList();

            //dataGridViewBookList.DataSource = context.Books.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // TODO - set 0 to column name

            string bookID = dataGridViewBookList.CurrentRow.Cells["BookID"].Value.ToString();
            string RFID = dataGridViewBookList.CurrentRow.Cells["RFID"].Value.ToString();

            tag = (from x in context.RFIDs
                   where x.RFID == RFID
                   select x).First();

            book = tag.Books;

            MessageBox.Show(tag.RFID + " " + book.BookID);
           
            this.DialogResult = DialogResult.OK;
        }
    }
}
