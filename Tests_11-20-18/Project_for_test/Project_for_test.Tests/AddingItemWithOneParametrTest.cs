using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project_for_test.Tests
{
    class AddingItemWithOneParametrTest
    {
        Sweets ListTest = new Sweets();
        //[TestCaseSource(typeof(StringForAdding))]
        //public void AddItem(string[] item)
        //{
        //    int amount = ListTest.ReturnCount();
        //    for (int i = 0; i < item.Length; i++)
        //    {
        //        ListTest.AddItem(item[i]);
        //    }
        //    Assert.That(ListTest.ReturnCount(), Is.GreaterThan(amount));
        //    for (int i = 0; i < item.Length; i++)
        //    {
        //        Assert.That(ListTest.ReturnItem(item[i]), Is.True);
        //    }
        //}
        [TestCaseSource(typeof(StringForAdding))]
        public void AddItems(string a,string b)
        {
            int amount = ListTest.ReturnCount();
            ListTest.AddItem(a);
            ListTest.AddItem(b);
            Assert.That(ListTest.ReturnCount(), Is.EqualTo(amount+2));
            Assert.That(ListTest.ReturnItem(a), Is.True);
            Assert.That(ListTest.ReturnItem(b), Is.True);
        }
        [TestCaseSource(nameof(StringCases))]
        public void AddIte(string a, string b)
        {
            int amount = ListTest.ReturnCount();
            ListTest.AddItem(a);
            ListTest.AddItem(b);
            Assert.That(ListTest.ReturnCount(), Is.EqualTo(amount + 2));
            Assert.That(ListTest.ReturnItem(a), Is.True);
            Assert.That(ListTest.ReturnItem(b), Is.True);
        }
       
            public static object[] StringCases =
            {
                new string[] {"Аленка", "Арахисовая"}
            };


    }
    

}
