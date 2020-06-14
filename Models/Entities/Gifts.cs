using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Gifts
    {
        public int Id { get; set; }
        public int? To { get; set; }
        public string From { get; set; }
        public string Message { get; set; }
        public uint? Sn { get; set; }
        public int? Uniqueid { get; set; }

        public virtual Characters ToNavigation { get; set; }
    }
}
