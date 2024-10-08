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
        private string _userName;

        // Constructor
        public Customer(string userName) : base(userName)
        {
            _userName = userName;
        }

        // Properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value.ToLower(); }
        }

        // Override Method
        public override void ShowMenu()
        {
            Console.WriteLine($"{UserName}");
            Console.Write("1 - Ürünleri İncele\t2 - Çıkış Yap");

        }
    }
}
