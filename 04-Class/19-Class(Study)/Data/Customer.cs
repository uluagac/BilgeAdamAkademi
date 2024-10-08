using _19_Class_Study_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Study_.Data
{
    public class Customer : User
    {
        // Fields
        private string _email;

        // Constructor
        public Customer(string email) : base(email)
        {
            Email = email;
        }

        // Properties
        public string Email
        {
            get
            {
                return _email.Split('@')[0];
            }
            set
            {
                _email = value.ToLower();
            }
        }

        // Override Method
        public override void ShowMenu()
        {

        }
    }
}
