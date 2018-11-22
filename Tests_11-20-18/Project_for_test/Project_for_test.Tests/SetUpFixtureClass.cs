using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project_for_test.Tests
{
    [SetUpFixture]
    public class SetUpFixtureClass
    {
        // install, clear, envirounment , .... static, put into a file 
        //[OneTimeSetUp]
        //public Sweets AddingForTest()
        //{
        //    Sweets ListTest = new Sweets();
        //    ListTest.AddItem("Аленка");
        //    ListTest.AddItem("Трюфель");
        //    ListTest.AddItem("Арахисовая");
        //    ListTest.AddItem("Аэрофлотские");
        //    ListTest.AddItem("Грильяж");
        //    return ListTest;
        //}
        [OneTimeTearDown]
        public void EndingTests()
        {
            Console.WriteLine("bye");
        }
    }
}
