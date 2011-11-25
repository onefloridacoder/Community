using System;
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
                this.Gardener = new Gardener(new Collection<Boot>(), new Collection<Tool>());
                this.Gardener.SetWorkDay(new TimeSpan(0,3,30,00));
            }

            public RedGarden(Gardener gardener,  ICollection<Tool> tools)
            {
                this.Gardener = gardener;
                this.Gardener.SetEquipment(tools);
                this.Gardener.SetWorkDay(new TimeSpan(0, 3, 30, 00));
            }
        }

        public class GreenGarden
        {
            public Gardener Gardener { get; private set; }

            public GreenGarden(Gardener gardener)
            {
                // TODO:JAS Complete member initialization
                this.Gardener = gardener;
            }

            public void DoWork()
            {
                if (!(this.Gardener.IsEquipped || this.Gardener.HasWorkTime))
                {
                    FireGardeningService();
                }
                GetOnWithIt();
            }

            private void FireGardeningService()
            {
                //TODO Finish Implementation
            }

            private void GetOnWithIt()
            {
                //TODO Finish Implementation
            }
        }
    }
}
