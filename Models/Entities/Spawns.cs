using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Spawns
    {
        public int Id { get; set; }
        public int Idd { get; set; }
        public int F { get; set; }
        public int Fh { get; set; }
        public string Type { get; set; }
        public int Cy { get; set; }
        public int Rx0 { get; set; }
        public int Rx1 { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int? Mobtime { get; set; }
        public int Mid { get; set; }
    }
}
