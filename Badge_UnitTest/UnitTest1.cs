using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Badge_Repository;

namespace Badge_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddBadge()
        {
            BadgeRepository br = new BadgeRepository();
            Assert.IsTrue(br._badges.Count == 0);
            Badge b1 = new Badge(123, "Cool Guy Badge.");
            b1.doorNames.Add("A1");
            br.Add(b1.badgeID, b1);
            Assert.IsTrue(br._badges.Count == 1);
        }
        [TestMethod]
        public void Test_DeleteAllDoors()
        {
            BadgeRepository br = new BadgeRepository();
            Badge b1 = new Badge(123, "Cool Guy Badge.");
            b1.doorNames.Add("A1");
            br.Add(b1.badgeID, b1);
            br.DeleteAllDoors(123);
            Assert.IsTrue(b1.doorNames.Count == 0);
        }
        [TestMethod]
        public void Test_EditRemoveDoor()
        {
            BadgeRepository br = new BadgeRepository();
            Badge b1 = new Badge(123, "Cool Guy Badge.");
            b1.doorNames.Add("A1");
            br.Add(b1.badgeID, b1);
            br.Edit(123, "A1", "remove");
            Assert.IsTrue(b1.doorNames.Count == 0);
        }
        [TestMethod]
        public void Test_EditAddDoor()
        {
            BadgeRepository br = new BadgeRepository();
            Badge b1 = new Badge(123, "Cool Guy Badge.");
            b1.doorNames.Add("A1");
            br.Add(b1.badgeID, b1);
            br.Edit(123, "B1", "add");
            Assert.IsTrue(b1.doorNames.Count == 2);
        }
        [TestMethod]
        public void Test_IsDoorValidTrue()
        {
            BadgeRepository br = new BadgeRepository();
            Badge b1 = new Badge(123, "Cool Guy Badge.");
            b1.doorNames.Add("A1");
            br.Add(b1.badgeID, b1);
            Assert.IsTrue(br.IsVaildBadgeID(123));
            Assert.IsFalse(br.IsVaildBadgeID(456));
        }
        [TestMethod]
        public void Test_GetBadgeByID()
        {
            BadgeRepository br = new BadgeRepository();
            Badge b1 = new Badge(123, "Cool Guy Badge.");
            b1.doorNames.Add("A1");
            br.Add(b1.badgeID, b1);
            Assert.IsTrue(br._badges.ContainsKey(123));
        }
    }
}
