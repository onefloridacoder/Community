using PeanutButter.Business.Facade.Crunchy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PeanutButter.Business.Entities;
using PeanutButter.Business.Entities.Enums;

namespace MSTest.Facade.Tests
{
    
    
    /// <summary>
    ///This is a test class for CrunchyLayerManagerTest and is intended
    ///to contain all CrunchyLayerManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CrunchyLayerManagerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CrunchyLayerManager Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PeanutButter.Business.Facade.dll")]
        public void CrunchyLayerManagerConstructorTest()
        {
            CrunchyLayerManager_Accessor target = new CrunchyLayerManager_Accessor();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for CrunchyLayerManager Constructor
        ///</summary>
        [TestMethod()]
        public void CrunchyLayerManagerConstructorTest1()
        {
            Sandwich sandwich = null; // TODO: Initialize to an appropriate value
            CrunchyLayerManager target = new CrunchyLayerManager(sandwich);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddBread
        ///</summary>
        [TestMethod()]
        public void AddBreadTest()
        {
            CrunchyLayerManager target = new CrunchyLayerManager(); // TODO: Initialize to an appropriate value
            Bread bread = new Bread(); // TODO: Initialize to an appropriate value
            target.AddBread(bread);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddFlavoring
        ///</summary>
        [TestMethod()]
        public void AddFlavoringTest()
        {
            CrunchyLayerManager target = new CrunchyLayerManager(); // TODO: Initialize to an appropriate value
            Flavoring flavoring = null; // TODO: Initialize to an appropriate value
            target.AddFlavoring(flavoring);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddTopping
        ///</summary>
        [TestMethod()]
        public void AddToppingTest()
        {
            CrunchyLayerManager target = new CrunchyLayerManager(); // TODO: Initialize to an appropriate value
            Topping topping = new Topping(); // TODO: Initialize to an appropriate value
            target.AddTopping(topping);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ConfigureSandwich
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PeanutButter.Business.Facade.dll")]
        public void ConfigureSandwichTest()
        {
            CrunchyLayerManager_Accessor target = new CrunchyLayerManager_Accessor(); // TODO: Initialize to an appropriate value
            Sandwich sandwich = null; // TODO: Initialize to an appropriate value
            target.ConfigureSandwich(sandwich);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Slice
        ///</summary>
        [TestMethod()]
        public void SliceTest()
        {
            CrunchyLayerManager target = new CrunchyLayerManager(); // TODO: Initialize to an appropriate value
            int numberOfSlices = 0; // TODO: Initialize to an appropriate value
            target.Slice(numberOfSlices);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Sandwich
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PeanutButter.Business.Facade.dll")]
        public void SandwichTest()
        {
            CrunchyLayerManager_Accessor target = new CrunchyLayerManager_Accessor(); // TODO: Initialize to an appropriate value
            Sandwich expected = null; // TODO: Initialize to an appropriate value
            Sandwich actual;
            target.Sandwich = expected;
            actual = target.Sandwich;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
