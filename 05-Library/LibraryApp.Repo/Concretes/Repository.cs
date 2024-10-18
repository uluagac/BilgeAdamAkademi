using LibraryApp.Core.Abstracts;
using LibraryApp.Repo.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repo.Concretes
{
    public class Repository<T> : IRepository<T> where T : IBaseEntity
    {
        // Fields
        private readonly IList<T> _libraryThings;

        // Constructor
        public Repository()
        {
            _libraryThings = new List<T>();
        }

        public void Add(T genericType)
        {
            try
            {
                _libraryThings.Add(genericType);
            }
            catch
            {
                throw new Exception("Kayıt işlemi sırasında bir hata gerçekleşti!");
            }
        }

        public void Delete(T genericType)
        {
            try
            {
                _libraryThings.Remove(genericType);
            }
            catch
            {
                throw new Exception("Silme işlemi sırasında bir hata gerçekleşti!");
            }
        }

        public void Update(T genericType)
        {
            //
        }

        public T GetById(int id)
        {
            if (!(_libraryThings == null))
            {
                foreach (var item in _libraryThings)
                {
                    if (item.Id == id)
                        return item;
                }
                throw new Exception("Böyle bir şey bulunamadı!");
            }
            else
                throw new Exception("Henüz liste boş!");
        }

        public IList<T> GetAll()
        {
            return _libraryThings;
        }
    }
}
