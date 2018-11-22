using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_test
{
    public class Sweets : IList_Methods
    {
        private List<string> _Candies { get; set; }
        public Sweets()
        {
            _Candies = new List<string>();
        }

        //Adds item into the List
        public void AddItem(string candy)
        {
            _Candies.Add(candy);
        }
        //Adds item into the List on position index
        public void InsertItem(int index, string candy)
        {
            _Candies.Insert(index, candy);
        }
        //Removes accurate item
        public void RemoveItem(string candy)
        {
            _Candies.Remove(candy);
        }
        //Removes item at accurate index
        public void RemoveItemAt(int index)
        {
            _Candies.RemoveAt(index);
        }
        //Sorts the List
        public void SortItems()
        {
            _Candies.Sort();
        }
        //Returns total count of the List
        public int ReturnCount()
        {
            return _Candies.Count();
        }
        //Return true if item exits in th List, false when not exists
        public bool ReturnItem(string item)
        {
            if (_Candies.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Returns index of accurate item from the List
        public int ReturnIndex(string item)
        {
            foreach (string candy in _Candies)
            {
                if(item==candy)
                {
                    return _Candies.IndexOf(candy);
                }
            }
            return -1;
        }
        //Shows item from the List in the console
        public void WatchItems()
        {
            foreach(string item in _Candies)
            {
                Console.WriteLine(item);
            }

        }
        //Returns item from the List by accurate index
        public string ReturnItemByIndex(int Index)
        {
            return _Candies[Index];
        }
        //Removes all item from the List
        public void Clear()
        {
            _Candies.Clear();
        }

    }
}
