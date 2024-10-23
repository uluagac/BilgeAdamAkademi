using LibAutoSysApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Core.Concretes
{
    public class BookPhilosophy : BaseBook
    {
        // Constructor
        public BookPhilosophy(string isbn, string title, string authorFirstName, string authorLastName, ushort publicationYear, string category) : base(isbn, title, authorFirstName, authorLastName, publicationYear, category)
        {
        }
    }
}
