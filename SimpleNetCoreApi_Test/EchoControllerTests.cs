using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleNetCoreApiV1Client;

namespace SimpleNetCoreApi_Test
{
    [TestClass]
    public class EchoControllerTests : ControllerTests
    {
        [TestMethod]
        public void Should_ApiEchoByIdGet_ReturnExactValue()
        {
            var client = new SimpleNetCoreApi(ApiBaseUri);
            var value = DateTime.UtcNow.DayOfYear;

            var result = client.ApiEchoByIdGet(value);

            Assert.AreEqual(value, result);
        }
    }
}
