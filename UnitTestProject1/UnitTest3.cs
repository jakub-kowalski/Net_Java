using LAB1_poprawione;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void checkDifferentOrder()
        {
            int capacity = 20;
            Backpack backpack1 = new Backpack(capacity);
            Backpack backpack2 = new Backpack(capacity);
            Item item1 = new Item(1, 5, 10);
            Item item2 = new Item(2, 9, 2);
            Item item3 = new Item(3, 3, 2);
            Item item4 = new Item(4, 10, 2);
            backpack1.AddItem(item1);
            backpack1.AddItem(item2);
            backpack1.AddItem(item3);
            backpack1.AddItem(item4);
            backpack2.AddItem(item1);
            backpack2.AddItem(item2);
            backpack2.AddItem(item3);
            backpack2.AddItem(item4);
            int addedWeight1 = backpack1.Solve()[0];
            int addedWeight2 = backpack2.Solve()[0];
            int addedValue1 = backpack1.Solve()[1];
            int addedValue2 = backpack2.Solve()[1];
            Assert.AreEqual(addedValue1, addedValue2);
            Assert.AreEqual(addedWeight1, addedWeight2);
        }
    }
}
