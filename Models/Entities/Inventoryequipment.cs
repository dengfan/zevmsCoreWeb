using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Inventoryequipment
    {
        public long Inventoryitemid { get; set; }
        public bool? Type { get; set; }
        public int? Characterid { get; set; }
        public int? Accountid { get; set; }
        public int? Itemid { get; set; }
        public short? Position { get; set; }
        public string Owner { get; set; }
        public int? Uniqueid { get; set; }
        public string Giftfrom { get; set; }
        public long? Expiration { get; set; }
        public bool? Inventorytype { get; set; }
        public bool? Upgradeslots { get; set; }
        public bool? Level { get; set; }
        public short? Str { get; set; }
        public short? Dex { get; set; }
        public short? Inte { get; set; }
        public short? Luk { get; set; }
        public short? Hp { get; set; }
        public short? Mp { get; set; }
        public short? Watk { get; set; }
        public short? Matk { get; set; }
        public short? Wdef { get; set; }
        public short? Mdef { get; set; }
        public short? Acc { get; set; }
        public short? Avoid { get; set; }
        public short? Hands { get; set; }
        public short? Speed { get; set; }
        public short? Jump { get; set; }
        public bool? Locked { get; set; }
        public string Options { get; set; }
        public sbyte? Socket { get; set; }
        public int? Dzlevel { get; set; }
    }
}
