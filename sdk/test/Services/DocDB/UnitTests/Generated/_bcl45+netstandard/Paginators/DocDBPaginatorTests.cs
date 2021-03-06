#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */

using Amazon.DocDB;
using Amazon.DocDB.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DocDBPaginatorTests
    {
        private static Mock<AmazonDocDBClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDocDBClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        public void DescribeDBClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBClustersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBClustersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBClustersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        public void DescribeDBEngineVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBEngineVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBEngineVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBEngineVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBEngineVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBEngineVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        public void DescribeDBInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBInstancesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBInstancesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        public void DescribeDBSubnetGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDBSubnetGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDBSubnetGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDBSubnetGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDBSubnetGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDBSubnetGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        public void DescribeEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        public void DescribeOrderableDBInstanceOptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeOrderableDBInstanceOptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOrderableDBInstanceOptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DocDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOrderableDBInstanceOptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeOrderableDBInstanceOptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOrderableDBInstanceOptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif