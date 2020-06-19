using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Cashshopcoupons
    {
        public uint Id { get; set; }
        public string Code { get; set; }
        public int Used { get; set; }
        public string Character { get; set; }
    }
}
