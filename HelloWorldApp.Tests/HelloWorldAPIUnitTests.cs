using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApp.Controllers;

namespace HelloWorldApp.Tests
{
    [TestClass]
    public class HelloWorldAPIUnitTests
    {
        [TestMethod]
        public void GetHelloMessage()
        {
            //Set up Prerequisites
            var controller = new HelloWorldController();
            //Act on Test
            string result = controller.Get();
            //Assert the result
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result);
        }

    }
}
