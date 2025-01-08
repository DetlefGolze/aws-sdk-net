﻿using Amazon.QueryCompatible.Model;
using Amazon.QueryCompatible.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.QueryCompatible
{
    [TestClass]
    public class HostPrefixMarshallingTests
    {
        [TestMethod]
        public void StaticEndpointHostTrait()
        {
            var marshaller = new StaticOpRequestMarshaller();
            var request = new StaticOpRequest
            {
                Name = "myname"
            };

            var internalRequest = marshaller.Marshall(request);
            Assert.AreEqual(internalRequest.HostPrefix, "data-");
        }

        [TestMethod]
        public void MemberRefEndpointHostTrait()
        {
            var marshaller = new MemberRefOpRequestMarshaller();
            var request = new MemberRefOpRequest
            {
                Name = "myname"
            };

            var internalRequest = marshaller.Marshall(request);
            Assert.AreEqual(internalRequest.HostPrefix, "foo-myname.");
        }
    }
}
