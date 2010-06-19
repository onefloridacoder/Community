using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeanutButter.Business.Entities
{
    public class EntityBase
    {
        public long? Id { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public string LastUpdatedBy { get; set; }

        public long? Version { get; set; }
    }
}
