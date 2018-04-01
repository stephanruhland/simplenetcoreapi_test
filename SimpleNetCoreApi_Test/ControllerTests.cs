using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleNetCoreApi_Test
{
    public abstract class ControllerTests
    {
        private const string BaseUriEnv = "SIMPLENETCOREAPI_BASEURI";
        public Uri ApiBaseUri;

        [TestInitialize]
        public void Init()
        {
            var baseUri = Environment.GetEnvironmentVariable(BaseUriEnv);
            Console.WriteLine($"{BaseUriEnv}: {baseUri}");
            if (string.IsNullOrWhiteSpace(baseUri))
            {
                throw new ArgumentNullException(nameof(BaseUriEnv));
            }
            ApiBaseUri = new Uri(baseUri);
        }
    }
}
