using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class PlayerVariables
    {
        public uint Id { get; set; }
        public int? Characterid { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual Characters Character { get; set; }
    }
}
