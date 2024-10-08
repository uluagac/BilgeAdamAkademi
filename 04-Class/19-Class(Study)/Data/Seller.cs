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
        private string _passWord;

        // Constructor
        public Seller(string userName) : base(userName)
        {
            UserName = userName;
        }

        // Properties
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value.ToLower();
            }
        }
        public string PassWord
        {
            get
            {
                return _passWord.Substring(0, 3);
            }
            set
            {
                if (value.Length >= 6)
                {
                    _passWord = value;
                }
                else
                {
                    
                }
            }
        }

        // Override Method
        public override void ShowMenu()
        {
            Console.WriteLine($"{UserName} - {PassWord}");
        }

        // Methods
    }
}
