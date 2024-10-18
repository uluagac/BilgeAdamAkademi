using LibraryApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Concrete
{
    public class Book : BaseLibraryItem
    {
        // Fields
        private string _publishingHouse;

        // Constructor
        public Book(string title, string authorFirstName, string authorLastName) : base(title, authorFirstName, authorLastName)
        {
        }

        // Properties
        public string PublishingHouse
        {
            get
            {
                return _publishingHouse;
            }
            set
            {
                _publishingHouse = value;
            }
        }
    }
}
