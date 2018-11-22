using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_test.Tests
{
    [TestFixture]
    class RemoveItemsTests
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
        [Test]
        [Order(1)]
        [Author("Anastasia K")]
        public void RemoveItems()
        {
            int amount = ListTest.ReturnCount();
            string item = "Аленка";
            ListTest.RemoveItem(item);
            Assert.That(ListTest.ReturnCount(), Is.LessThan(amount));
            Assert.That(ListTest.ReturnItem(item), Is.False);
        }
        [Test]
        [Order(2)]
        [Author("Anastasia K")]
        public void RemoveItemsAtIndex()
        {
            string item = "Трюфель";
            int amount = ListTest.ReturnCount();
            int Item_Index = ListTest.ReturnIndex(item);
            ListTest.RemoveItemAt(Item_Index);
            Assert.That(ListTest.ReturnCount(), Is.LessThan(amount));
            Assert.That(ListTest.ReturnItem(item), Is.False);
        }

    }
}
