using System.Collections.Generic;
using System.Collections.ObjectModel;
using SCS.Infrastructure;
using SCS.Model;

namespace SCS.Constructors
{
    public class Gardens
    {
        public class RedGarden
        {
            public Gardener Gardener { get; private set; }

            public RedGarden()
            {
                // Before
                // MEMO This is going to take for-eeever!
                this.Gardener = new Gardener(new Collection<Boot>());
                this.Gardener.SetWorkDay();
            }

            public RedGarden(Gardener gardener)
            {
                // TODO:JAS Complete member initialization
                this.gardener = gardener;
                this.gardener.SetEquipment();
            }
        }

        public class GreenGarden
        {
            private Gardener gardener;
            public GreenGarden(Gardener gardener)
            {
                // TODO:JAS Complete member initialization
                this.gardener = gardener;
            }
        }
    }
}
