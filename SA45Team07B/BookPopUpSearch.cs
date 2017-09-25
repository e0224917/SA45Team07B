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

        private Book bookFound;
        private RFIDTag tagFound;
        
        public Book BookFound
        {
            get
            {
                return bookFound;
            }
        } 

        public RFIDTag RFIDFound
        {
            get
            {
                return tagFound;
            }
        }

        public BookPopUpSearch()
        {
            InitializeComponent();
        }

        private void BookPopUpSearch_Load(object sender, EventArgs e)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                var subjectNameList = (from x in context.BookSubjects
                                       select x.SubjectName).ToList();

                subjectNameList.Insert(0, "");

                cbSubject.DataSource = subjectNameList;

                // Lazy loading - load the first 25 rows to datagridview
                var displayList = (from x in context.RFIDs
                                  orderby x.Books.BookID, x.Availability descending
                                  select new
                                  {
                                      x.Books.BookID,
                                      x.Books.BookTitle,
                                      x.Availability,
                                      x.Books.Edition,
                                      x.Books.Author,
                                      x.Books.ISBN,
                                      x.Books.CallNumber,
                                      x.RFID,
                                      x.Books.BookSubjects.SubjectName,
                                      x.Books.Publishers.PublisherName,
                                      x.Books.PublishedYear,
                                      x.Books.Price,
                                      x.Discontinued,
                                  }).Take(25);

                dataGridViewBookList.DataSource = displayList.ToList();
            }
        }


        private void SearchAndDisplayBook()
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                List<RFIDTag> RFIDList = new List<RFIDTag>();
                RFIDList = (from x in context.RFIDs
                            select x).ToList();


                if (rbtnAll.Checked == true)
                {
                    RFIDList = (from x in RFIDList
                                select x).ToList();
                }
                else if(rbtnAvailable.Checked == true)
                {
                    RFIDList = (from x in RFIDList
                                where (x.Availability == "y" && x.Discontinued == "n")
                                select x).ToList();
                }
                else if(rbtnOnLoan.Checked == true)
                {
                    RFIDList = (from x in RFIDList
                                where (x.Availability == "n" && x.Discontinued == "n")
                                select x).ToList();
                }
                else if(rbtnDiscontinued.Checked == true)
                {
                    RFIDList = (from x in RFIDList
                                where (x.Discontinued == "y")
                                select x).ToList();
                }

                List<Book> searchResult = new List<Book>();
                searchResult = (from x in RFIDList
                                select x.Books).ToList();

                searchResult = CriteriaSeach(searchResult, txtbBookTitle, "BookTitle");
                searchResult = CriteriaSeach(searchResult, txtbAuthor, "Author");
                searchResult = CriteriaSeach(searchResult, txtbISBN, "ISBN");

                if (cbSubject.Text != "")
                {
                    searchResult = (from x in searchResult
                                    where x.BookSubjects.SubjectName == cbSubject.Text
                                    select x).ToList();
                }

                var displayList = from x in RFIDList
                                  where searchResult.Contains(x.Books)
                                  orderby x.Books.BookID, x.Availability descending
                                  select new
                                  {
                                      x.Books.BookID,
                                      x.Books.BookTitle,
                                      x.Availability,
                                      x.Books.Edition,
                                      x.Books.Author,
                                      x.Books.ISBN,
                                      x.Books.CallNumber,
                                      x.RFID,
                                      x.Books.BookSubjects.SubjectName,
                                      x.Books.Publishers.PublisherName,
                                      x.Books.PublishedYear,
                                      x.Books.Price,
                                      x.Discontinued,
                                  };

                dataGridViewBookList.DataSource = displayList.ToList();
            }
        }

        private List<Book> CriteriaSeach(List<Book> list, TextBox tb, string propertyName)
        {
            if (tb.Text != string.Empty)
            {
                list = (from x in list
                        where (x.GetType().GetProperty(propertyName).GetValue(x).ToString().ToLower().Contains(tb.Text.ToString().ToLower().Trim()))
                        select x).ToList();
            }
            return list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAndDisplayBook();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbBookTitle.Text = string.Empty;
            txtbAuthor.Text = string.Empty;
            txtbISBN.Text = string.Empty;
            cbSubject.Text = "";
            SearchAndDisplayBook();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                string selectedRFID = dataGridViewBookList.CurrentRow.Cells["RFIDColumn"].Value.ToString();

                // tag can never be null since this button is disable when there is no selected row
                this.tagFound = (from x in context.RFIDs
                            where x.RFID == selectedRFID
                            select x).First();

                this.bookFound = tagFound.Books;
            }
           
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridViewMemberList_SelectionChanged(object sender, EventArgs e)
        {
        
            if (dataGridViewBookList.SelectedRows.Count == 0)
            {
                btnOK.Enabled = false;
                btnOK.BackColor = Color.LightGray;
                toolStripStatusLblSelectedBook.Text = "No record is found.";
            }
            else
            {
                btnOK.Enabled = true;
                btnOK.BackColor = Color.White;

                string selectedName = dataGridViewBookList.CurrentRow.Cells["BookTitleColumn"].Value.ToString();

                toolStripStatusLblSelectedBook.Text = $"<<{selectedName}>> is selected.";
            }
        }

        private void dataGridViewBookList_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dataGridViewBookList.RowCount == 25)
                {
                    if(e.NewValue > 9)
                    {
                        SearchAndDisplayBook();
                        // remove this event handler
                        this.dataGridViewBookList.Scroll -= new System.Windows.Forms.ScrollEventHandler(this.dataGridViewBookList_Scroll);
                    }
                }
            }
        }
    }
}
