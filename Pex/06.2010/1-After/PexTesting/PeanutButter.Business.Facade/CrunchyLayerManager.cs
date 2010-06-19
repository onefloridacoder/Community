using System;
using PeanutButter.Business.Entities;
using PeanutButter.Business.Entities.Enums;
using System.Diagnostics;

namespace PeanutButter.Business.Facade.Crunchy
{
    public class CrunchyLayerManager : IBusinessLayerManager
    {
        public Sandwich Sandwich { get; private set; }

        public CrunchyLayerManager(Sandwich sandwich)
        {
            ConfigureSandwich(sandwich);
        }

        public CrunchyLayerManager() 
        {
            this.Sandwich = new Sandwich();
        }

        private void ConfigureSandwich(Sandwich sandwich)
        {
            if (sandwich == null)
            {
                sandwich = new Sandwich();
            }

            sandwich.Slices = 4;
            sandwich.Toasted = true;
            sandwich.Layers = 4;
            sandwich.Topping = Topping.MorePeanutButter;
            sandwich.BreadSlices = 4;

            this.Sandwich = sandwich;
        }

        public void AddBread(Bread bread)
        {
            this.Sandwich.Bread = bread;
        }

        public void AddFlavoring(Flavoring flavoring)
        {
            this.Sandwich.Flavoring = flavoring;
        }

        public void Slice(int numberOfSlices)
        {
            if (this.Sandwich.Slices == 0)
            {
                this.Sandwich.Slices = numberOfSlices;
            }
        }

        public void AddTopping(Topping topping)
        {
            // throw new NotImplementedException();

            this.Sandwich.Topping = topping;
        }
    }
}