using LibraryApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Concrete
{
    public class Paper : BaseLibraryItem
    {
        // Fields
        private string _magazine;

        // Constructor
        public Paper(string title, string authorFirstName, string authorLastName) : base(title, authorFirstName, authorLastName)
        {
        }

        // Properties
        public string Magazine 
        { 
            get
            {
                return _magazine;
            }
            set
            {
                _magazine = value;
            }
        }
    }
}
