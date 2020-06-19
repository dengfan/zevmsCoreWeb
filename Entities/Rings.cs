using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Rings
    {
        public int Id { get; set; }
        public int PartnerRingId { get; set; }
        public int PartnerChrId { get; set; }
        public int Itemid { get; set; }
        public string Partnername { get; set; }
    }
}
