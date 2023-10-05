using Pr13_bonusøvelse;

namespace Pr13_tigerdyret
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("12,12", JumpHelper.MakeAJump(0, 3, 4, 2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("NO", JumpHelper.MakeAJump(0, 2, 5, 3));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("182,182", JumpHelper.MakeAJump(14, 4, 98, 2));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("NO", JumpHelper.MakeAJump(21, 6, 47, 3));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("198,198", JumpHelper.MakeAJump(42, 3, 94, 2));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("NO", JumpHelper.MakeAJump(6644, 5868, 8349, 3477));
        }


    }
}