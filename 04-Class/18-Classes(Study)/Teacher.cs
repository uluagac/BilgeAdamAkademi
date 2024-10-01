using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Classes_Study_
{
    public class Teacher : Person
    {
        // Fields
        private string _rank;
        private decimal _salary;

        // Properties
        public string Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                _rank = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
    }
}
