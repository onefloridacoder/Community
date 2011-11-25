namespace SCS.Constructors
{
    using SCS.Infrastructure;

    public class Houses
    {
        public class RedHouse
        {
            Kitchen kitchen = new Kitchen();
            Bedroom bedroom;
            
            public RedHouse()
            {
                bedroom = new Bedroom();    
            }            
        }

        public class GreenHouse
        {
            Kitchen kitchen;
            Bedroom bedroom;

            public GreenHouse(Kitchen kitchen, Bedroom bedroom)
            {
                this.kitchen = kitchen;
                this.bedroom = bedroom;
            }
        }
    }
}
