using LAB1_poprawione;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void checkFullSolution()
        {
            int capacity = 20;
            Backpack backpack = new Backpack(capacity);
            Item item1 = new Item(1, 5, 15);
            Item item2 = new Item(2, 14, 30);
            Item item3 = new Item(2, 5, 6);
            Item item4 = new Item(2, 1, 1);
            backpack.AddItem(item1);
            backpack.AddItem(item2);
            backpack.AddItem(item3);
            backpack.AddItem(item4);
            int addedWeight = backpack.Solve()[0];
            int addedValue = backpack.Solve()[1];
            int expectedWeight = 20;
            int expectedValue = 46;
            Assert.AreEqual(addedValue, expectedValue);
            Assert.AreEqual(addedWeight, expectedWeight);
        }
    }
}
