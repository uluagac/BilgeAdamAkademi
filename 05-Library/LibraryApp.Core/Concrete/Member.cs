using LibraryApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Concrete
{
    public class Member : BasePerson
    {
        // Constructor
        public Member(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
