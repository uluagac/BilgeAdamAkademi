using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19_Class_Study_.Abstract;

namespace _19_Class_Study_.Data
{
    public class Seller : User
    {
        // Fields
        private string _userName;

        // Constructor
        public Seller(string userName)
        {
            _userName = userName;
        }

        // Properties

        // Override Method
        public override void ShowMenu()
        {

        }

        // Methods
    }
}
