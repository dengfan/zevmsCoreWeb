using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Cashitems
    {
        public int? Serialnumber { get; set; }
        public int? Itemid { get; set; }
        public short? Quantity { get; set; }
        public int? Price { get; set; }
        public bool? Gender { get; set; }
        public sbyte? Period { get; set; }
        public bool? Onsale { get; set; }
        public int? Sj { get; set; }
    }
}
