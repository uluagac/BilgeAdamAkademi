using LibraryApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repo.Abstracts
{
    public interface IRepository<T> where T : IBaseEntity
    {
        void Add(T genericType);
        void Delete(T genericType);
        void Update(T genericType);
        T GetById(int id);
        IList<T> GetAll();
    }
}
