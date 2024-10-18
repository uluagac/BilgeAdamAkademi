using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core.Abstracts
{
    public abstract class BaseLibraryItem : IBaseEntity
    {
        // Fields
        private static int _id = 10000;
        private string _title;
        private string _authorFirstName;
        private string _authorLastName;
        private string _category;
        private int _date;

        // Constructor
        protected BaseLibraryItem(string title, string authorFirstName, string authorLastName)
        {
            Title = title;
            AuthorFirstName = authorFirstName;

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
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
        public string AuthorFirstName
        {
            set
            {
                _authorFirstName = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
        public string AuthorLastname
        {
            set
            {
                _authorLastName = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
        public string AuthorFullName
        {
            get
            {
                return $"{_authorFirstName} {_authorLastName}";
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
        public int Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        // Override Methods
        public override string ToString()
        {
            return $"ID: {Id}, Title: {Title}, Author: {AuthorFullName}, Category: {Category}";
        }
    }
}
