using System.Collections.Generic;

using Bridge.Test.NUnit;

namespace Bridge.Collections.ClientTest.BridgeIssues
{
    // Bridge[#634]
    [Category(Constants.BRIDGE_ISSUES)]
    [TestFixture(TestNameFormat = "#634 - {0}")]
    public class Bridge634
    {
        [Test(ExpectedCount = 1)]
        public static void TestUseCase1()
        {
            var hashSet = new HashSet<string>();

            hashSet.Add("a");
            hashSet.Add("b");
            hashSet.Add("c");

            var text = "";

            foreach (string s in hashSet)
            {
                text += s;
            }

            Assert.AreEqual("abc", text, "Bridge634: foreach works for HashSet");
        }
    }
}