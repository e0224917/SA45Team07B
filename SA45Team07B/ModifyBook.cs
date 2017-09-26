using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class ModifyBook : SA45Team07B.BaseForm
    {
        Book bookfound;

        public ModifyBook()
        {
            InitializeComponent();
        }

        private void btnFindBk_Click(object sender, EventArgs e)
        {
            using (BookPopUpSearch popsearch = new BookPopUpSearch())
            {
                if (popsearch.ShowDialog() == DialogResult.OK)
                {
                    bookfound = popsearch.BookFound;

                    txtbBkId.Text = bookfound.BookID.ToString();
                    mtbISBN.Text = bookfound.ISBN.ToString();
                    txtbBkTitle.Text = bookfound.BookTitle.ToString();
                    txtbAuthor.Text = bookfound.Author.ToString();
                    using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
                    {
                        cbxPublisher.DataSource = context.Publishers.Select(x => x.PublisherName).ToList();
                        cbxPublisher.SelectedItem = context.Publishers.Where(x => x.PublisherID == bookfound.PublisherID).First().PublisherName.ToString();
                        cbxSubjectName.DataSource = context.BookSubjects.Select(x => x.SubjectName).ToList();
                        cbxSubjectName.SelectedItem = context.BookSubjects.Where(x => x.SubjectCode == bookfound.SubjectCode).First().SubjectName.ToString();
                    }
                    txtbCallNum.Text = bookfound.CallNumber.ToString();
                    txtbPrice.Text = bookfound.Price.ToString();
                    if (bookfound.Edition != null)
                    {
                        txtbEd.Text = bookfound.Edition.ToString();
                    }
                    if (bookfound.PublishedYear != null)
                    {
                        mtbYear.Text = bookfound.PublishedYear.ToString();
                    }
                    //foreach (RFIDTag rfid in bookfound.RFIDs)
                    //{
                    //    lbxRFID.Items.Add(rfid);
                    //}
                    using (SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities())
                    {
                        var rfids = from x in context.RFIDs
                                    where x.BookID == bookfound.BookID
                                    select x.RFID;
                        lbxRFID.DataSource = rfids.ToList();
                    }
                }
                else
                {
                    //no book is selected therefore no data displayed and submit buttone disabled
                    
                }
                
            }

        }


        //do modification on selectioned item



       
       //




        private void btnSubmit_Click(object sender, EventArgs e)
        {


        }

        private void txtbBkTitle_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
