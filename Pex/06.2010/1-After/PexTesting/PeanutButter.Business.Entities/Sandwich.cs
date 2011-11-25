using PeanutButter.Business.Entities.Enums;

namespace PeanutButter.Business.Entities
{
    public class Sandwich : EntityBase
    {
        public int BreadSlices { get; set; }

        public int Layers { get; set; }

        public Flavoring Flavoring { get; set; }

        public bool Toasted { get; set; }

        public int Slices { get; set; }

        public Topping Topping { get; set; }

        public Bread Bread { get; set; }
    }
}
