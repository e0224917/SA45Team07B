using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45Team07B
{
    public partial class Book
    {
        public class ValidationResponse
        {
            public bool Successful { get; set; }
            public string Information { get; set; }
        }

        public ValidationResponse ValidateISBN(Book book)
        {
            ValidationResponse outcome = new SA45Team07B.Book.ValidationResponse();
            
            return outcome;
        }
    }
}
