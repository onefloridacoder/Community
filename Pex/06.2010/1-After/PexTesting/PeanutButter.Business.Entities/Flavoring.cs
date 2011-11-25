using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PeanutButter.Business.Entities.Enums;

namespace PeanutButter.Business.Entities
{
    public class Flavoring : EntityBase
    {
        public Flavor Flavor { get; set; }

        public int Spoonfuls { get; set; }
    }
}
