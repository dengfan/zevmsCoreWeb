using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Charactersin
    {
        public int Id { get; set; }
        public int? Meso { get; set; }
        public int? Meso2 { get; set; }
        public int? Meso3 { get; set; }
        public int? Meso4 { get; set; }
        public int? Cailiao { get; set; }
        public int? Feiqi { get; set; }
        public int? Dianquan { get; set; }
        public int? Dianquan2 { get; set; }
        public int? Tplevel { get; set; }
        public int? Hjfx { get; set; }
        public int? Zhakun { get; set; }
        public int? Dkbck { get; set; }
        public int? Fmdxk { get; set; }
        public int? Wnk { get; set; }
        public int? Jueseshuliang { get; set; }
        public int? Putongfuhuo { get; set; }
        public int? Gaojifuhuo { get; set; }
        public int? Pg500000 { get; set; }
        public int? Pg100000 { get; set; }
        public int? Pg50000 { get; set; }
        public int? Pg10000 { get; set; }
        public int? Pg5000000 { get; set; }
        public int? Pg1000000 { get; set; }
        public int? Zs99 { get; set; }
        public int? Zs499 { get; set; }
        public int? Zs999 { get; set; }

        public virtual Characters IdNavigation { get; set; }
    }
}
