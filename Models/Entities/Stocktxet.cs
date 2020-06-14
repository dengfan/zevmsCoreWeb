using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Stocktxet
    {
        public int Id { get; set; }
        public int? A { get; set; }
        public int? B { get; set; }
        public DateTime? Shijian { get; set; }
    }
}
