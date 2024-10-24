using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Core.Abstracts
{
    public class BaseMember : IBaseLibrary
    {
        private static int _memberId = 1000;
        private string _firstName;
        private string _lastName;
        private int _birthDate;
        private string _email;

        //Constructors
        public BaseMember(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            _memberId++;
        }

        // Properties
        /// <summary>
        /// Sadece dönüş için.
        /// </summary>
        public int MemberId
        {
            get
            {
                return _memberId;
            }
        }

        /// <summary>
        /// Değeri atarken her ismin ilk harfini büyük olarak ayarlar.
        /// </summary>
        public string FirstName
        {
            set
            {
                _firstName = string.Join(" ", value.Split(' ').Select(valueChar => char.ToUpper(valueChar[0]) + valueChar.Substring(1).ToLower())); ;
            }
        }

        /// <summary>
        /// Değeri atarken ilk harfi büyük olarak ayarlar.
        /// </summary>
        public string LastName
        {
            set
            {
                _lastName = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        /// <summary>
        /// İsim ve soyismi bütün olarak döndürür.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
        }

        /// <summary>
        /// Doğum yılını alır ancak yaşı döndürür.
        /// </summary>
        public int BirthDate
        {
            get
            {
                return DateTime.Now.Year - _birthDate;
            }
            set
            {
                if (value > 1900 && value < DateTime.Now.Year)
                {
                    _birthDate = value;
                }
                else
                {
                    throw new ArgumentException($"Birthdate must be between 1900 and {DateTime.Now.Year}.");
                }
            }
        }

        /// <summary>
        /// E-posta kontrolü yaparken içerisinde e-posta için gerekli olan karakterlerin kontrolü yapılır.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains('@') && value.Contains('.'))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Email must include both '@' and '.'.");
                }
            }
        }

        // Override Method
        /// <summary>
        /// Constructorda bildirilen değerleri okumak için "override" method.
        /// </summary>
        /// <returns>Kullanıcı bilgiler</returns>
        public override string ToString()
        {
            return $"ID: {MemberId}, Name: {FullName}, Email: {Email}";
        }
    }
}
