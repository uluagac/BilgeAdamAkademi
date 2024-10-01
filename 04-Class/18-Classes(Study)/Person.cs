using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Classes_Study_
{
    public abstract class Person
    {
        // Fields
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _birthDate;

        // Properties
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string FirstName
        {
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
        }
        public int BirthDate
        {
            get
            {
                return DateTime.Now.Year - _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }
    }
}
