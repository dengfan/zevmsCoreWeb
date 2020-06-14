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

        public virtual Characters IdNavigation { get; set; }
    }
}
