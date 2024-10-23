using LibAutoSysApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Core.Concretes
{
    public class BookScience : BaseBook
    {
        // Constructor
        public BookScience(string isbn, string title, string authorFirstName, string authorLastName, ushort publicationYear, string category) : base(isbn, title, authorFirstName, authorLastName, publicationYear, category)
        {
        }
    }
}
