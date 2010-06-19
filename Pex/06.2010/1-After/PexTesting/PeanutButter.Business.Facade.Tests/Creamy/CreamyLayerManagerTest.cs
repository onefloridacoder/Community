// <copyright file="CreamyLayerManagerTest.cs" company="Microsoft">Copyright © Microsoft 2010</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeanutButter.Business.Entities;
using PeanutButter.Business.Entities.Enums;
using PeanutButter.Business.Facade.Creamy;

namespace PeanutButter.Business.Facade.Creamy
{
    /// <summary>This class contains parameterized unit tests for CreamyLayerManager</summary>
    [PexClass(typeof(CreamyLayerManager))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CreamyLayerManagerTest
    {
        /// <summary>Test stub for AddBread(Bread)</summary>
        [PexMethod]
        public void AddBread([PexAssumeUnderTest]CreamyLayerManager target, Bread bread)
        {
            target.AddBread(bread);
            Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CreamyLayerManagerTest.AddBread(CreamyLayerManager, Bread)
        }

        /// <summary>Test stub for AddFlavoring(Flavoring)</summary>
        [PexMethod]
        public void AddFlavoring(
            [PexAssumeUnderTest]CreamyLayerManager target,
            Flavoring flavoring
        )
        {
            target.AddFlavoring(flavoring);
            Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CreamyLayerManagerTest.AddFlavoring(CreamyLayerManager, Flavoring)
        }

        /// <summary>Test stub for AddTopping(Topping)</summary>
        [PexMethod]
        public void AddTopping([PexAssumeUnderTest]CreamyLayerManager target, Topping topping)
        {
            target.AddTopping(topping);
            Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CreamyLayerManagerTest.AddTopping(CreamyLayerManager, Topping)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public CreamyLayerManager Constructor()
        {
            CreamyLayerManager target = new CreamyLayerManager();
            Assert.Inconclusive("this test has to be reviewed");
            return target;
            // TODO: add assertions to method CreamyLayerManagerTest.Constructor()
        }

        /// <summary>Test stub for Sandwich</summary>
        [PexMethod]
        public void SandwichGet([PexAssumeUnderTest]CreamyLayerManager target)
        {
            Sandwich result = target.Sandwich;
            Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CreamyLayerManagerTest.SandwichGet(CreamyLayerManager)
        }

        /// <summary>Test stub for Slice(Int32)</summary>
        [PexMethod]
        public void Slice(
            [PexAssumeUnderTest]CreamyLayerManager target,
            int numberOfSlices
        )
        {
            target.Slice(numberOfSlices);
            Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CreamyLayerManagerTest.Slice(CreamyLayerManager, Int32)
        }
    }
}
