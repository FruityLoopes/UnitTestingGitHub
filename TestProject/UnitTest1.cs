using UnitTestingGitHub;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FailedTest()
        {
            TestMe t1 = new TestMe("Jack", "I wrote this", "1", "Reece");
            string expected = "My name is Jack and I wrote this";
            string actual = t1.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}