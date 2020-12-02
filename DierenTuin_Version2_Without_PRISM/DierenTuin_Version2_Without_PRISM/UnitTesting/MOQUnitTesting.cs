using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using DierenTuin_Version2_Without_PRISM.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;

namespace DierenTuin_Version2_Without_PRISM.UnitTesting
{
    [TestClass]
    class MOQUnitTesting
    {
        [TestMethod]

        public void TestMethod1()
        {
            var ApeMockInfo = new ApeModel();
            var LionMockInfo = new LionModel();
            var ElephantMockInfo = new ElephantModel();

            Action act = () =>
            {
                Assert.AreEqual(10, ApeMockInfo.EdibleAmountPerEnergyPerUnit);
                Assert.AreEqual(25, LionMockInfo.EdibleAmountPerEnergyPerUnit);
                Assert.AreEqual(50, ElephantMockInfo.EdibleAmountPerEnergyPerUnit);
            };
        
        }
    }
}
