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
            MutateStringContent(whoAmI, "Grant");
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
            // Rely on string interning: "Kelly" here will be the same object as "Kelly" in MutateTheUnnamed().
            // CLR of .NET 4.5+ will intern string literals when assembly is loaded into AppDomain.
            // In previous versions we should use string.Intern("Kelly") to be sure of valid reference.

            //string whoAmI = string.Intern("Kelly");
            string whoAmI = "Kelly";

            MutateStringContent(whoAmI, "Chris");
        }

        private static void MutateStringContent(string source, string target)
        {
            // obtain pointer and iterate with replacing
            unsafe
            {
                fixed (char* ptr = source)
                {
                    for (int i = 0; i < source.Length; i++)
                    {
                        ptr[i] = target[i];
                    }
                }
            }
        }
    }
}
