using PeanutButter.Business.Entities;
using PeanutButter.Business.Entities.Enums;

namespace PeanutButter.Business.Facade.Creamy
{
    public class CreamyLayerManager : IBusinessLayerManager
    {
        public Sandwich Sandwich { get; private set; }
        
        public CreamyLayerManager() { }

        /// <summary>
        /// Every sandwich needs some bread unless you are
        /// eating out of the jar which is also legal and
        /// permissible if your better half doens't bust you.
        /// Yes, I have been busted repeatedly.
        /// 
        /// We are telling AddBread what kind of bread we
        /// are adding.
        /// </summary>
        /// <param name="bread">
        /// <seealso cref="Bread"/>
        /// The type of bread (white, wheat, etc.)
        /// </param>
        public void AddBread(Bread bread)
        {
            this.Sandwich = new Sandwich()
                             {
                                 Toasted = false,
                                 BreadSlices = 2,
                                 Layers = 1,
                                 Bread = bread
                             };
        }

        /// <summary>
        /// We now we need some flavor on this sandwich,
        /// so pick one that blows your hair back.
        /// 
        /// The kicker is you define how many spoonfuls of 
        /// flavoring - I start with too much and go from there.
        /// 
        /// We are expecting the client to tell us what and how much
        /// flavoring needs to add.
        /// </summary>
        /// <param name="flavoring"><see cref="Flavor"/>Grape, Strawberry, etc.</param>
        public void AddFlavoring(Flavoring flavoring)
        {
            this.Sandwich.Flavoring = flavoring;
            //  Flavoring = new Flavoring {Flavor = Flavor.Strawberry, Spoonfuls = 6},
        }

        /// <summary>
        /// When I make a masterpiece, my kids want a slice or two.  Yes,
        /// my sandwiches are like pizzas, they feed a few people or make
        /// one person (me) very happy and full.
        /// </summary>
        /// <param name="numberOfSlices">How much do you want to share?</param>
        public void Slice(int numberOfSlices)
        {
            this.Sandwich.Slices = numberOfSlices;
        }

        /// <summary>
        /// Just like a pizza, you can add toppings.
        /// </summary>
        /// <param name="topping">
        /// <seealso cref="Topping"/>
        /// What else do you want to add? The top slice
        /// doesn't have anything on it, go for it!
        /// </param>
        public void AddTopping(Topping topping)
        {
            this.Sandwich.Topping = topping;
        }
    }
}