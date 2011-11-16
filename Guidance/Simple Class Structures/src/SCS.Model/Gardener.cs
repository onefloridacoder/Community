namespace SCS.Infrastructure
{
    using System.Collections.Generic;

    public class Gardener
    {
        private ICollection<Tool> Tools;
        private ICollection<Boot> Boots;

        public Gardener(ICollection<Boot> boots)
        {
            this.Boots = boots;
        }

        public Gardener(ICollection<Boot> boots, ICollection<Tool> tools)
        {
            // MEMO Before
            // TODO JAS Move this into a setter method
            // using (var enumerator = tools.GetEnumerator())
            // {
            //    while (enumerator.MoveNext())
            //    {
            //        this.Equipment.Add(enumerator.Current.Name, enumerator.Current.Name);
            //    }
            // }

            // MEMO After
            // this.Tools = tools;
        }

        public Equipment Equipment { get; private set; }

        /// <summary>
        /// This method takes at least five minutes to complete.
        /// </summary>
        public virtual void SetEquipment()
        {
            // First
            // this.Equipment = new Equipment();

            // Second
            // using (var enumerator = tools.GetEnumerator())
            // {
            //    while (enumerator.MoveNext())
            //    {
            //        this.Equipment.Add(enumerator.Current.Name, enumerator.Current.Name);
            //    }
            // }           
        }
    }
}