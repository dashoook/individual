using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ind1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {   int a = 3;
            int b = 27;
            double r1 = ind.Program.Example(a, b);
            Assert.AreEqual(15, r1);}}}
