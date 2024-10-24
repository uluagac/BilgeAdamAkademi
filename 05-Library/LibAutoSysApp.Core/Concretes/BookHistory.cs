using LibAutoSysApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Core.Concretes
{
    public class BookHistory : BaseBook
    {
        // Constructor
        public BookHistory(string isbn, string title, string authorFirstName, string authorLastName, ushort publicationYear) : base(isbn, title, authorFirstName, authorLastName, publicationYear)
        {
            Category = "History";
        }
    }
}
