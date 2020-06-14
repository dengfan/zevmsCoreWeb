using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Cheatlog
    {
        public int Id { get; set; }
        public int Characterid { get; set; }
        public string Offense { get; set; }
        public int Count { get; set; }
        public DateTime Lastoffensetime { get; set; }
        public string Param { get; set; }

        public virtual Characters Character { get; set; }
    }
}
