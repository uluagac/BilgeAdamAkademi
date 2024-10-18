using LibraryApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Concrete
{
    public class Librarian : BasePerson
    {
        // Constructor
        public Librarian(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        // Properties
        public int BirthDate
        {
            set
            {
                if (DateTime.Now.Year - value >= 18)
                {
                    base.BirthDate = value;
                }
                else
                {
                    throw new ArgumentException("Kütüphaneci 18 yaşından büyük olmalı!");
                }
            }
        }
    }
}
