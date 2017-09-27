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
        private Book bookFound;
        private RFIDTag tagFound;
        private List<RFIDTag> tagsOfBookFound;
        private BookSubject subjectOfBookFound;
        private Publisher publisherOfBookFound;
        private bool isFirstLoad;

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

        public List<RFIDTag> RFIDsOfBookFound
        {
            get
            {
                return tagsOfBookFound;
            }
        }

        public BookSubject SubjectOfBookFound
        {
            get
            {
                return subjectOfBookFound;
            }
        }

        public Publisher PublisherOfBookFound
        {
            get
            {
                return publisherOfBookFound;
            }
        }

        public BookPopUpSearch()
        {
            InitializeComponent();
            this.rbtnAll.Checked = true;
        }

        /// <summary>
        /// "all" "available" "onloan" "discontinued" to activate corresponding radiobutton.
        /// </summary>
        /// <param name="radioButton"></param>
        public BookPopUpSearch(string radioButton)
        {
            InitializeComponent();

            if (radioButton.ToLower() == "all")
            {
                this.rbtnAll.Checked = true;
            }
            else if (radioButton.ToLower() == "available")
            {
                this.rbtnAvailable.Checked = true;
            }
            else if (radioButton.ToLower() == "onloan")
            {
                this.rbtnOnLoan.Checked = true;
            }
            else if (radioButton.ToLower() == "discontinued")
            {
                this.rbtnDiscontinued.Checked = true;
            }
        }

        private void BookPopUpSearch_Load(object sender, EventArgs e)
        {
            using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
            {
                var subjectNameList = (from x in context.BookSubjects
                                       select x.SubjectName).ToList();

                subjectNameList.Insert(0, "");

                cbSubject.DataSource = subjectNameList;

                SearchAndDisplayBook(false);
                isFirstLoad = true;
            }

        }

        /// <summary>
        /// showAll will display all records. If showAll is false, display only the first 25 records.
        /// </summary>
        /// <param name="showAll"></param>
        private void SearchAndDisplayBook(bool showAll = true)
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
                else if (rbtnAvailable.Checked == true)
                {
                    RFIDList = (from x in RFIDList
                                where (x.Availability == "y" && x.Discontinued == "n")
                                select x).ToList();
                }
                else if (rbtnOnLoan.Checked == true)
                {
                    RFIDList = (from x in RFIDList
                                where (x.Availability == "n" && x.Discontinued == "n")
                                select x).ToList();
                }
                else if (rbtnDiscontinued.Checked == true)
                {
                    RFIDList = (from x in RFIDList
                                where (x.Discontinued == "y")
                                select x).ToList();
                }

                List<Book> searchResult = new List<Book>();
                searchResult = (from x in RFIDList
                                select x.Books).ToList();

                searchResult = CriteriaSeach(searchResult, txtbBookTitle, "BookTitle");
                searchResult = CriteriaSeach(searchResult, txtbISBN, "ISBN");

                // cannot apply CriteriaSeach for Author as it is allowed null
                if (txtbAuthor.Text != string.Empty)
                {
                    List<Book> searchResultByAuthor = (from x in context.Books
                                                       where x.Author.ToLower().Contains(txtbAuthor.Text.ToString().ToLower().Trim())
                                                       select x).ToList();

                    searchResult = searchResult.Intersect(searchResultByAuthor).ToList();
                }

                if (cbSubject.Text != "")
                {
                    searchResult = (from x in searchResult
                                    where x.BookSubjects.SubjectName == cbSubject.Text
                                    select x).ToList();
                }

                if (showAll)
                {
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
                                          x.Discontinued
                                      };

                    dataGridViewBookList.DataSource = displayList.ToList();
                }
                else
                {
                    var displayList = (from x in RFIDList
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
                                          x.Discontinued
                                      }).Take(25);

                    dataGridViewBookList.DataSource = displayList.ToList();
                }
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
            rbtnAll.Checked = true;
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

                this.bookFound = RFIDFound.Books;
                this.tagsOfBookFound = BookFound.RFIDs.ToList();
                this.subjectOfBookFound = BookFound.BookSubjects;
                this.publisherOfBookFound = BookFound.Publishers;
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
                toolStripStatusLblSelectedBook.Text = "No record is found.";
            }
            else
            {
                btnOK.Enabled = true;

                string selectedName = dataGridViewBookList.CurrentRow.Cells["BookTitleColumn"].Value.ToString();

                toolStripStatusLblSelectedBook.Text = $"<<{selectedName}>> is selected.";
            }
        }

        private void dataGridViewBookList_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (isFirstLoad && e.OldValue > 8)
                {
                    SearchAndDisplayBook();
                    isFirstLoad = false;
                    // remove this event handler
                    this.dataGridViewBookList.Scroll -= new System.Windows.Forms.ScrollEventHandler(this.dataGridViewBookList_Scroll);
                }
            }
        }
    }

}
