using LibraryApp.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Service.Abstracts
{
    public interface IItemManager : IBaseManager
    {
        void AddThing(BaseLibraryItem item);
        void RemoveThing(BaseLibraryItem item);
        List<BaseLibraryItem> GetAllItems();
        List<BaseLibraryItem> GetBorrowerByItem(BasePerson person);
    }
}
