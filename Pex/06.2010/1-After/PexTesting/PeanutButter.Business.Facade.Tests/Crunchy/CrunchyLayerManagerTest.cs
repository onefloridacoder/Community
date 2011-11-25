// <copyright file="CrunchyLayerManagerTest.cs" company="Microsoft">Copyright © Microsoft 2010</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeanutButter.Business.Entities;
using PeanutButter.Business.Entities.Enums;
using PeanutButter.Business.Facade.Crunchy;

namespace PeanutButter.Business.Facade.Crunchy
{
    /// <summary>This class contains parameterized unit tests for CrunchyLayerManager</summary>
    [PexClass(typeof(CrunchyLayerManager))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CrunchyLayerManagerTest
    {
        /// <summary>Test stub for AddBread(Bread)</summary>
        [PexMethod]
        public void AddBread([PexAssumeUnderTest]CrunchyLayerManager target, Bread bread)
        {
            target.AddBread(bread);
            //Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CrunchyLayerManagerTest.AddBread(CrunchyLayerManager, Bread)
        }

        /// <summary>Test stub for AddFlavoring(Flavoring)</summary>
        [PexMethod]
        public void AddFlavoring(
            [PexAssumeUnderTest]CrunchyLayerManager target,
            Flavoring flavoring
        )
        {
            target.AddFlavoring(flavoring);
            // Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CrunchyLayerManagerTest.AddFlavoring(CrunchyLayerManager, Flavoring)
        }

        /// <summary>Test stub for AddTopping(Topping)</summary>
        [PexMethod]
        public void AddTopping([PexAssumeUnderTest]CrunchyLayerManager target, Topping topping)
        {
            target.AddTopping(topping);
            // Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CrunchyLayerManagerTest.AddTopping(CrunchyLayerManager, Topping)
        }

        /// <summary>Test stub for .ctor(Sandwich)</summary>
        [PexMethod]
        public CrunchyLayerManager Constructor(Sandwich sandwich)
        {
            CrunchyLayerManager target = new CrunchyLayerManager(sandwich);
            // Assert.Inconclusive("this test has to be reviewed");
            return target;
            // TODO: add assertions to method CrunchyLayerManagerTest.Constructor(Sandwich)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public CrunchyLayerManager Constructor01()
        {
            CrunchyLayerManager target = new CrunchyLayerManager();
            // Assert.Inconclusive("this test has to be reviewed");
            return target;
            // TODO: add assertions to method CrunchyLayerManagerTest.Constructor01()
        }

        /// <summary>Test stub for Sandwich</summary>
        [PexMethod]
        public void SandwichGet([PexAssumeUnderTest]CrunchyLayerManager target)
        {
            Sandwich result = target.Sandwich;
            // Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CrunchyLayerManagerTest.SandwichGet(CrunchyLayerManager)
        }

        /// <summary>Test stub for Slice(Int32)</summary>
        [PexMethod]
        public void Slice(
            [PexAssumeUnderTest]CrunchyLayerManager target,
            int numberOfSlices
        )
        {
            target.Slice(numberOfSlices);
            // Assert.Inconclusive("this test has to be reviewed");
            // TODO: add assertions to method CrunchyLayerManagerTest.Slice(CrunchyLayerManager, Int32)
        }
    }
}
