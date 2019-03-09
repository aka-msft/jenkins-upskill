using NUnit.Framework;
using HelloWorld;
//using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace HelloWorldTests
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }
}