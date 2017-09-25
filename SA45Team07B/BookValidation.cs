using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45Team07B
{
    public partial class Book
    {
        public bool BookValidation(Book book)
        {
            SA45Team07B_LibraryEntities context = new SA45Team07B_LibraryEntities();

            // check isbn - if its 13 digits or if it is existing isbn
            if (book.ISBN.Length != 13 || context.Books.Where(x => x.ISBN == book.ISBN).FirstOrDefault() != null)
            {
                return false;
            }

            //check 
            return true;
        }
    }
}
