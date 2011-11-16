using System.Collections.Generic;
using SCS.Infrastructure;

namespace SCS.Constructors
{
    public class Gardens
    {
        public class RedGarden
        {
            private Gardener gardener;

            public RedGarden()
            {
                
            }

            public RedGarden(Gardener gardener)
            {
                // TODO:JAS Complete member initialization
                this.gardener = gardener;
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
