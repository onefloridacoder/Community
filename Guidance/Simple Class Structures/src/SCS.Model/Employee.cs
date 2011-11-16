namespace SCS.Model
{
    using System.Collections.Generic;

    public class Employee : Gardener
    {
        public Employee(ICollection<Boot> boots, ICollection<Tool> tools)
            : base(boots, tools)
        {

        }

        public override void SetEquipment()
        {
            // MEMO Before
            base.SetEquipment();

            // MEMO After
            base.Equipment.Add("Shovel", "Shovel");
        }
    }
}