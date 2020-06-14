using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Trocklocations
    {
        public int Trockid { get; set; }
        public int? Characterid { get; set; }
        public int? Mapid { get; set; }

        public virtual Characters Character { get; set; }
    }
}
