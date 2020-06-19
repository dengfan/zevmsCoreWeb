using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Shopitems
    {
        public uint Shopitemid { get; set; }
        public uint Shopid { get; set; }
        public int Itemid { get; set; }
        public int Price { get; set; }
        public int Pitch { get; set; }
        public int Position { get; set; }
        public int Reqitem { get; set; }
        public int Reqitemq { get; set; }
    }
}
