using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Auctionitems
    {
        public long Id { get; set; }
        public int World { get; set; }
        public int? Characterid { get; set; }
        public string CharacterName { get; set; }
        public bool? AuctionState { get; set; }
        public int? Buyer { get; set; }
        public string BuyerName { get; set; }
        public int? Price { get; set; }
        public int? Itemid { get; set; }
        public int? Inventorytype { get; set; }
        public int? Quantity { get; set; }
        public string Owner { get; set; }
        public string GmLog { get; set; }
        public int? Uniqueid { get; set; }
        public int? Flag { get; set; }
        public long? Expiredate { get; set; }
        public string Sender { get; set; }
        public byte? Upgradeslots { get; set; }
        public byte? Level { get; set; }
        public short? Str { get; set; }
        public short? Dex { get; set; }
        public short? Int { get; set; }
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
        public sbyte? ViciousHammer { get; set; }
        public string Options { get; set; }
        public string Options2 { get; set; }
        public sbyte? Socket { get; set; }
        public sbyte? Socket2 { get; set; }
        public int? Dzlevel { get; set; }
        public DateTime Shijian { get; set; }

        public virtual Characters Character { get; set; }
    }
}
