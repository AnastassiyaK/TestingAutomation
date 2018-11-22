using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project_for_test.Tests
{
    class AddingItemsTests
    {
        Sweets ListTest = new Sweets();
        [SetUp]
        public void AddingForTest()
        {

            ListTest.AddItem("Аленка");
            ListTest.AddItem("Трюфель");
            ListTest.AddItem("Арахисовая");
            ListTest.AddItem("Аэрофлотские");
            ListTest.AddItem("Грильяж");

        }
        [TearDown]
        public void ShowData()
        {
            ListTest.Clear();
        }

        [Test(Author = "Anastasia K", Description = "Insert an item into a List at " +
            "set position")]
        [Order(1)]
        public void Insert()
        {
            int amount = ListTest.ReturnCount();
            string item = "Желе";
            int index = amount - 1;
            ListTest.InsertItem(index, item);
            Assert.That(amount + 1, Is.EqualTo(ListTest.ReturnCount()));
            Assert.That(ListTest.ReturnIndex(item), Is.EqualTo(index));

        }
        [Test]
        [Order(2)]
        [Author("Anastasia K")]
        public void AddItems()
        {
            int amount = ListTest.ReturnCount();
            string item = "Президент";
            ListTest.AddItem(item);
            Assert.That(ListTest.ReturnCount(), Is.GreaterThan(amount));
            Assert.That(ListTest.ReturnItem(item), Is.True);
        }

    }
}
