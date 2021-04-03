using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cafe_Repository;

namespace Cafe_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Add()
        {
            MenuRepository mr = new MenuRepository();
            Menu m1 = new Menu(1, "Coffee", "Black Coffe", null, 1);
            mr.Add(m1);
            Assert.IsTrue(mr.MenuList.Count == 1);
        }
        [TestMethod]
        public void Test_View()
        {
            MenuRepository mr = new MenuRepository();
            Menu m1 = new Menu(1, "Coffee", "Black Coffe", null, 1);
            Menu m2 = new Menu(2, "Bread", "Wheat Bread", null, 2);
            mr.Add(m1);
            mr.Add(m2);
            Assert.IsTrue(mr.MenuList.Count == 2);
        }
        [TestMethod]
        public void Test_DeleteMenuItem()
        {
            MenuRepository mr = new MenuRepository();
            Menu m1 = new Menu(1, "Coffee", "Black Coffe", null, 1);
            Menu m2 = new Menu(2, "Bread", "Wheat Bread", null, 2);
            mr.Add(m1);
            mr.Add(m2);
            mr.deleteMenuItem(m2);
            Assert.IsTrue(mr.MenuList.Count == 1);
        }
    }
}
