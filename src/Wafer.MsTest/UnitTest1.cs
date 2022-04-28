using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wafer.Entity;

namespace Wafer.MsTest;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Journal one = new Journal() { Id = "1" };
        //Journal two = one;
        //Assert.AreSame(one, two);
        //int a = 100;
        //int b = 2;
        //int c = a * b;
        //Assert.AreEqual(200,c,"yes is ok");
        //Assert.IsTrue(200==c);
        Journal one = new Journal() { Id = "1002" };
        Assert.IsNotNull(one);
        Assert.AreEqual("1002", one.Id);
        //Assert.AreEqual("1003",one.Id);
        Assert.IsInstanceOfType(one, typeof(Journal));
    }
    [TestMethod]
    public void XamlUITestMethod()
    {
        Journal one = new Journal() { Id = "1002" };
        Journal two = new Journal() { Id = "1002" };
        Assert.AreEqual(one.Id, two.Id);
        //Assert.AreSame(two, one);
    }
    [TestMethod]
    public void TestStartWithUpper()
    {
        string[] words = { "Alphabet", "Aebra", "ABC", "Aiek", "AOkik" };
        foreach (var word in words)
        {
            bool result = word.StartsWith('A');
            Assert.IsTrue(result, string.Format("Expected for '{0}':true;Actual:{1}", word, result));
        }
    }
}
