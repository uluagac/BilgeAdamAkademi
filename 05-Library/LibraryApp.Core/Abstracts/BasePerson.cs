using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Abstracts
{
    public abstract class BasePerson : IBaseEntity
    {
		// Fields
		private static int _id = 0;
		private string _firstName;
        private string _lastName;
		private int _birthDate;
		private string _email;

        // Constructor
        protected BasePerson(string firstName, string lastName)
        {
			FirstName = firstName;
			LastName = lastName;
			_id++;
        }

        // Properties
        public int Id 
		{ 
			get
			{
				return _id;
			}
		}
        public string FirstName
		{
			set
			{
				_firstName = char.ToUpper(value[0]) + value.Substring(1).ToLower();
			}
		}
		public string LastName
		{
			set
			{
                _lastName = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
		}
		public string FullName
		{
			get
			{
				return $"{_lastName} {_firstName}";
			}
		}
        public int BirthDate { get; set; }
        public string Email 
		{ 
			get
			{
				return _email;
			} 
			set
			{
				if (value.Contains("@") && value.Contains("."))
				{
					_email = value;
				}
				else
				{
					throw new ArgumentException("Geçersiz e-posta adresi!");
				}
			}
		}

        // Override Methods
        public override string ToString()
        {
            return $"ID: {Id}, Person: {FullName}, E-mail: {Email}";
        }
    }
}
