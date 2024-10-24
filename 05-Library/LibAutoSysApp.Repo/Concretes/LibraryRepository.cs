using LibAutoSysApp.Core.Abstracts;
using LibAutoSysApp.Core.Concretes;
using LibAutoSysApp.Repo.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Repo.Concretes
{
    public class LibraryRepository<T> : ILibraryRepository<T> where T : IBaseLibrary
    {
        // Fields List
        private readonly IList<T> _libraryItems;
        private BaseMember _member;
        private BaseBook _book;

        // Constructor
        public LibraryRepository()
        {
            _libraryItems = new List<T>();
        }

        // Methods
        public void BorrowBook(T book, T member)
        {
            try
            {
                _member.
            }
            catch
            {

            }
        }
        public void ReturnBook(T book, T member)
        {

        }
        public IList<T> GetAllItems()
        {
            return _libraryItems;
        }
    }
}
