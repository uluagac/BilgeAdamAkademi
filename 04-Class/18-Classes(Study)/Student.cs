using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Classes_Study_
{
    public class Student : Person
    {
        // Fields
        private bool _scholarship;

        // Properties
        public bool Scholarship
        {
            get
            {
                return _scholarship;
            }
            set
            {
                _scholarship = value;
            }
        }
    }
}
