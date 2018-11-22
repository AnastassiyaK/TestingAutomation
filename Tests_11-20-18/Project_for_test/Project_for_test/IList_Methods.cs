using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_test
{
    interface IList_Methods
    {
        void AddItem(string Item);
        void Clear();
        void InsertItem(int Index, string Item);
        void RemoveItem(string Item);
        void RemoveItemAt(int Index);
        void SortItems();
        int ReturnCount();
        bool ReturnItem(string Item);
        int ReturnIndex(string Item);
        string ReturnItemByIndex(int Index);
    }
}
