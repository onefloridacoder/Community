namespace SCS.Constructors.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SCS.Infrastructure;
    using System.Drawing;

    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RedHouse_
    {

        [TestMethod]
        public void Kitchen_And_Bathroom_Dimensions_Should_Eq_Zero()
        {
            var redHouse = new Houses.RedHouse();

            // RedHouse can only use the version of the
            // Kitchen and Bathroom objects created
            // when the constructor fires.

            // Testing assertions against two value objects is not always a good thing to do;

            Assert.Inconclusive("How do I test the RedHouse?");
        }
    }

    [TestClass]
    public class GreenHouse_
    {
        [TestMethod]
        public void Kitchen_Square_Footage_Should_Eq_Zero()
        {
            var kitchen = new Kitchen(); // Kitchen test double
            kitchen.SquareFootage = 0d;
            kitchen.Color = Color.White;

            var bedroom = new Bedroom(); // Bedroom test double
            bedroom.SquareFootage = 0d;
            bedroom.Color = Color.White;

            // Only testing one assertion per type, i.e. kitchen.
            var greenHouse = new Houses.GreenHouse(kitchen, bedroom);
            Assert.IsTrue(Equals(kitchen.SquareFootage, 0d), "Kitchen square footage is greater than zero");
        }

        [TestMethod]
        public void Bedroom_Square_Footage_Should_Eq_Zero()
        {
            var kitchen = new Kitchen();
            kitchen.SquareFootage = 0d;
            kitchen.Color = Color.White;

            var bedroom = new Bedroom();
            bedroom.SquareFootage = 0d;
            bedroom.Color = Color.White;

            // Only testing one assertion per type, i.e. bedroom.
            var greenHouse = new Houses.GreenHouse(kitchen, bedroom);
            Assert.IsTrue(Equals(bedroom.SquareFootage, 0d), "Bedroom square footage is greater than zero");
        }
    }
}