using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Bosslog
    {
        public int Id { get; set; }
        public int Characterid { get; set; }
        public string Bossid { get; set; }

        public virtual Characters Character { get; set; }
    }
}
