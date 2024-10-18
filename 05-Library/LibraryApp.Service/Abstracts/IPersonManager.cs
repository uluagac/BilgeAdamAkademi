using LibraryApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Service.Abstracts
{
    public interface IPersonManager : IBaseManager
    {
        void AddPerson(BasePerson person);
        void RemovePerson(BasePerson person);
        List<BasePerson> GetAllPerson();
    }
}
