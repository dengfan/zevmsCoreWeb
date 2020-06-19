using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Inventoryitems
    {
        public long Inventoryitemid { get; set; }
        public bool? Type { get; set; }
        public int? Characterid { get; set; }
        public int? Accountid { get; set; }
        public int? Itemid { get; set; }
        public int? Inventorytype { get; set; }
        public int? Position { get; set; }
        public int? Quantity { get; set; }
        public string Owner { get; set; }
        public int? Uniqueid { get; set; }
        public string Giftfrom { get; set; }
        public ulong? Expiration { get; set; }
    }
}
