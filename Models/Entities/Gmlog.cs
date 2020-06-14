using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Gmlog
    {
        public int Gmlogid { get; set; }
        public int Cid { get; set; }
        public string Command { get; set; }
        public int Mapid { get; set; }
        public DateTime Time { get; set; }
    }
}
