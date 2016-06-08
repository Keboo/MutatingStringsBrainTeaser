using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MutatingStrings
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void MutateTheImmutable()
        {
            const string WhoAmI = "Kevin";
            Assert.AreEqual("Kevin", WhoAmI);

            CauseIdentityCrisis(WhoAmI);

            Assert.AreEqual("Grant", WhoAmI);
        }

        private static void CauseIdentityCrisis( string whoAmI )
        {
            //TODO
        }

        [TestMethod]
        public void MutateTheUnnamed()
        {
            const string WhoAmI = "Kelly";
            Assert.AreEqual("Kelly", WhoAmI);

            CauseIdentityCrisis();

            Assert.AreEqual("Chris", WhoAmI);
        }

        private static void CauseIdentityCrisis()
        {
            //TODO
        }
    }
}
