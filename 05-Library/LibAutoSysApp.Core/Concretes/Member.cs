using LibAutoSysApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Core.Concretes
{
    public class Member : BaseMember
    {
        // Fields
        public Member(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
        }
    }
}
