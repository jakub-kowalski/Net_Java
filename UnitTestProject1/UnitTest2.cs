using LAB1_poprawione;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void returnedEmpty()
        {
            int capacity = 5;
            Backpack backpack = new Backpack(capacity);
            Item item1 = new Item(1, 6, 10);
            Item item2 = new Item(2, 9, 2);
            backpack.AddItem(item1);
            backpack.AddItem(item2);
            int addedWeight = backpack.Solve()[0];
            bool result = (addedWeight <= capacity);
            Assert.IsTrue(result);
            Assert.IsTrue(addedWeight==0);
        }
    }
}
