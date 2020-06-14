using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Buddies
    {
        public int Id { get; set; }
        public int? Characterid { get; set; }
        public int? Buddyid { get; set; }
        public sbyte? Pending { get; set; }

        public virtual Characters Character { get; set; }
    }
}
