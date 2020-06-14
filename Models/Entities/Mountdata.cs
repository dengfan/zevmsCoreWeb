using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Mountdata
    {
        public uint Id { get; set; }
        public uint? Characterid { get; set; }
        public uint Level { get; set; }
        public uint Exp { get; set; }
        public uint Fatigue { get; set; }
    }
}
