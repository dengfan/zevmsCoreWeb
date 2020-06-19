using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Shops
    {
        public uint Shopid { get; set; }
        public int Npcid { get; set; }
        public string Beizhu { get; set; }
        public int? Map { get; set; }
    }
}
