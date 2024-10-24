using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Core.Abstracts
{
    public abstract class BaseBook : IBaseLibrary
    {
        // Fields
        private string _isbn;
        private string _title;
        private string _authorFirstName;
        private string _authorLastName;
        private ushort _publicationYear;
        private string _category;

        // Constructor
        protected BaseBook(string isbn, string title, string authorFirstName, string authorLastName, ushort publicationYear)
        {
            Isbn = isbn;
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            PublicationYear = publicationYear;
        }

        //Properties
        /// <summary>
        /// Değeri atarken "tire" ve "boşluklar" kaldırılar karakter sayısı kontrol edilir. Değer döndürürken "tire" ve "boşluklar" kaldırılmaz, bu nedenle string kullanılır.
        /// </summary>
        public string Isbn
        {
            get { return _isbn; }
            set
            {
                string CleanIsbn = value.Replace("-", "").Replace(" ", "");
                if (CleanIsbn.Length == 10 || CleanIsbn.Length == 13)
                {
                    _isbn = value;
                }
                throw new ArgumentException("ISBN must be either 10 or 13 characters long.");
            }
        }

        /// <summary>
        /// Değeri atarken her kelimenin ilk harfini büyük olarak ayarlar.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                _title = string.Join(" ", value.Split(' ').Select(valueChar => char.ToUpper(valueChar[0]) + valueChar.Substring(1).ToLower()));
            }
        }

        /// <summary>
        /// Değeri atarken her ismin ilk harfini büyük olarak ayarlar.
        /// </summary>
        public string AuthorFirstName
        {
            get { return _authorFirstName; }
            set
            {
                _authorFirstName = string.Join(" ", value.Split(' ').Select(valueChar => char.ToUpper(valueChar[0]) + valueChar.Substring(1).ToLower()));
            }
        }

        /// <summary>
        /// Değeri atarken ilk harfi büyük olarak ayarlar.
        /// </summary>
        public string AuthorLastName
        {
            get { return _authorLastName; }
            set
            {
                _authorLastName = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        /// <summary>
        /// Değeri atarken 0 ile anlık yıl kontrolü yapar.
        /// </summary>
        public ushort PublicationYear
        {
            get { return _publicationYear; }
            set
            {
                if (value >= ushort.MinValue && value <= DateTime.Now.Year)
                {
                    _publicationYear = value;
                }
                else
                {
                    throw new ArgumentException($"The publication year must be between 0 and {DateTime.Now.Year}.");
                }
            }
        }

        /// <summary>
        /// Kitabın durumunu, varsayılan olarak Available (Mevcut), ayarlar.
        /// </summary>
        public StatusBook StatusBook { get; set; } = StatusBook.Available;

        /// <summary>
        /// Değeri atarken ilk harfi büyük olarak ayarlar.
        /// </summary>
        public string Category
        {
            get
            {
                return _category;
            }
            protected set
            {
                _category = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        // Override Method
        /// <summary>
        /// Constructorda alınan kitap bilgilerini döndüren method.
        /// </summary>
        /// <returns>Kitap bilgileri</returns>
        public override string ToString()
        {
            return $"ISBN: {Isbn}, Title: {Title}, Author: {AuthorFirstName} {AuthorLastName}, Publication Year: {PublicationYear}, Category: {Category}";
        }
    }
}
