using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Claims_Repository;

namespace Claims_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Add()
        {
            ClaimsRepository mr = new ClaimsRepository();
            Claim c1 = new Claim(1, "Car", "Car accident on 465", 400, new DateTime(2021, 1, 3), new DateTime(2021, 1, 5), true);
            mr.Add(c1);
            Assert.IsTrue(mr.ClaimList.Count == 1);
        }
        [TestMethod]
        public void Test_View()
        {
            ClaimsRepository mr = new ClaimsRepository();
            Claim mi1 = new Claim(1, "Car", "Car accident on 465", 400, new DateTime(2021, 1, 3), new DateTime(2021, 1, 5), true);
            Claim mi2 = new Claim(2, "Home", "House fire in kitchen", 4000, new DateTime(2021, 1, 3), new DateTime(2021, 2, 5), true);
            mr.Add(mi1);
            mr.Add(mi2);
            Assert.IsTrue(mr.ClaimList.Count == 2);
        }
        [TestMethod]
        public void Test_DeleteMenuItem()
        {
            ClaimsRepository mr = new ClaimsRepository();
            Claim mi1 = new Claim(1, "Car", "Car accident on 465", 400, new DateTime(2021, 1, 3), new DateTime(2021, 1, 5), true);
            Claim mi2 = new Claim(2, "Home", "House fire in kitchen", 4000, new DateTime(2021, 1, 3), new DateTime(2021, 2, 5), true);
            mr.Add(mi1);
            mr.Add(mi2);
            mr.deleteClaim(mi2);
            Assert.IsTrue(mr.ClaimList.Count == 1);
        }
    }
}
