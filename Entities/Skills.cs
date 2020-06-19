using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Skills
    {
        public int Id { get; set; }
        public int? Skillid { get; set; }
        public int? Characterid { get; set; }
        public int? Skilllevel { get; set; }
        public int? Masterlevel { get; set; }

        public virtual Characters Character { get; set; }
    }
}
