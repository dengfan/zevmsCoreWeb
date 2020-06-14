using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Pets
    {
        public int Petid { get; set; }
        public string Name { get; set; }
        public uint? Level { get; set; }
        public uint? Closeness { get; set; }
        public uint? Fullness { get; set; }
        public int? Seconds { get; set; }
        public string Excluded { get; set; }
    }
}
