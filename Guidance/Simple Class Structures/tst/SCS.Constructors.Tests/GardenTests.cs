using System.Collections.ObjectModel;

namespace SCS.Constructors.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SCS.Infrastructure;
    using System.Drawing;

    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RedGarden_
    {

        [TestMethod]
        public void Should_Apply_Configured_Gardener_To_Itself()
        {

        }
    }

    [TestClass]
    public class GreenGarden_
    {
        [TestMethod]
        public void Should_Apply_Configured_Gardener_To_Itself()
        {
            var gardener = new Gardener(new Collection<Boot>(), new Collection<Tool>());
            var garden = new Gardens.RedGarden(gardener); // Garden test double
            garden.Gardener.SquareFootage = 0d;
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