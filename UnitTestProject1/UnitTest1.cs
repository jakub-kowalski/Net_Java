using LAB1_poprawione;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;

namespace UnitTestProject1  
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void returnedAtLeastOne()
        {
            int capacity = 20;
            Backpack backpack = new Backpack(capacity);
            Item item1 = new Item(1, 5, 10);
            Item item2 = new Item(2, 9, 2);
            backpack.AddItem(item1);
            backpack.AddItem(item2);
            int addedWeight = backpack.Solve()[0];
            bool result = addedWeight <= capacity;
            Assert.IsTrue(result);
        }
    }
}
