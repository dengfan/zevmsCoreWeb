using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Cashshopcouponitems
    {
        public uint Id { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public int ItemData { get; set; }
        public int Quantity { get; set; }
        public bool? Used { get; set; }
    }
}
