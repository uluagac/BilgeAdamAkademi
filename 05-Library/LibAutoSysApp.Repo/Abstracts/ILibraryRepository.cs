using LibAutoSysApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoSysApp.Repo.Abstracts
{
    public interface ILibraryRepository<T> where T : IBaseLibrary
    {
        void BorrowBook(T book, T member);
        void ReturnBook(T book, T member);
        IList<T> GetAllItems();
    }
}
