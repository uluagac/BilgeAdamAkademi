using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Core.Abstracts
{
    public interface IMember
    {
        //Properties
        public int MemberId { get; }
        public string FirstName { set; }
        public string LastName { set; }
        public string FullName { get; }
        public int BirthDate {  get; set; }
        public string Email { get; set; }
    }
}
