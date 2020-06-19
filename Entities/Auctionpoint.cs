using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Auctionpoint
    {
        public int Characterid { get; set; }
        public int? Point { get; set; }
        public int? Selling { get; set; }

        public virtual Characters Character { get; set; }
    }
}
