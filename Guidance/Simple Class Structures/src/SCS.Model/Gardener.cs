using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace SCS.Model
{
    using System.Collections.Generic;

    public class Gardener
    {
        public ICollection<Tool> Tools { get; private set; }
        public ICollection<Boot> Boots { get; private set; }
        public Equipment Equipment { get; private set; }

        public DateTime WorkDay { get; private set; }
        public bool IsEquipped { get; private set; }
        public bool HasWorkTime { get; private set; }

        public Gardener(ICollection<Boot> boots, IEnumerable<Tool> tools )
        {
            this.SetWorkDay(new TimeSpan(0,3,30,0));
            
            this.Boots = boots;
            using (var enumerator = tools.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    this.Equipment.Add(enumerator.Current.Name, enumerator.Current.Name);
                }
            }
        }

        // MEMO After
        // public Gardener(ICollection<Boot> boots, ICollection<Tool> tools)
        // {            
            // this.Tools = tools;
            // this.Boots = boots;
        // }
        

        /// <summary>
        /// This method takes between 10 and 20 seconds to complete.
        /// </summary>
        public void SetEquipment(ICollection<Tool> tools)
        {
            Thread.Sleep(new Random(0).Next(10, 20));
        }

        public void SetWorkDay(TimeSpan workday)
        {
            this.WorkDay = new DateTime(workday.Ticks);
        }
    }
}