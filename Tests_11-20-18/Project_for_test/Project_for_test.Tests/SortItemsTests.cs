using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_test.Tests
{
    [TestFixture]
    class SortItemsTests
    {
        /// <summary> 
        /// Trace
        /// TestCaseSource
        /// </summary>
        //public Sweets List;
        Sweets ListTest = new Sweets();
        [SetUp]
        [Description("Adding items for the tests")]
        public void AddingForTest()
        {
            
            ListTest.AddItem("Аленка");
            ListTest.AddItem("Трюфель");
            ListTest.AddItem("Арахисовая");
            ListTest.AddItem("Аэрофлотские");
            ListTest.AddItem("Грильяж");

        }
        [TearDown]
        [Description("Makes testing List empty")]
        public void ShowData()
        {
            ListTest.Clear();
        }
        
        [Test]
        [Order(1)]
        [Author("Anastasia K")]
        [Description("Sort our List by ASC")]
        public void Sort()
        {
            List<string> ListForCheck = new List<string>();
            for (int i = 0; i < ListTest.ReturnCount(); i++)
            {
                ListForCheck.Add(ListTest.ReturnItemByIndex(i));
            }
            ListForCheck.Sort();
            ListTest.SortItems();
            for(int i=0;i<ListTest.ReturnCount();i++)
            {
                  Assert.That(ListTest.ReturnItemByIndex(i),Is.EqualTo(ListForCheck[i]));
            }

        }       

    }
}
