using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file. Minimum of 12 tests.

        // 1. Test "[]"
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        // 2. Test "[LaunchCode]"
        [TestMethod]
        public void BracketsAroundStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }
        // 3. Test "Launch[Code]"
        [TestMethod]
        public void BracketsAroundPartOfStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        // 4. Test "[]LaunchCode"
        [TestMethod]
        public void StringWithNoBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        // 5. Test "" (empty string)
        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        // 6. Test "[]" (empty brackets)
        [TestMethod]
        public void EmptyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        // 7. Test "[LaunchCode"
        [TestMethod]
        public void MissingBracketAroundStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));

        }
        // 8. Test "Launch]Code["
        [TestMethod]
        public void MisplacedBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));

        }
        // 9. Test "["
        [TestMethod]
        public void MissingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));

        }
        // 10. Test "]["
        [TestMethod]
        public void MisOrdereddBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));

        }
        // 11. Test "[LaunchCode][LaunchCode]"
        [TestMethod]
        public void DoubleBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode][LaunchCode]"));

        }
        // 12. Test "]]LaunchCode]]LaunchCode]]"
        [TestMethod]
        public void AllBracketsInOneDirectionReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]123]]LaunchCode]]"));
        }
    }
}
