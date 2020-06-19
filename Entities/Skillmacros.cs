using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Skillmacros
    {
        public uint Entryid { get; set; }
        public int Characterid { get; set; }
        public bool Position { get; set; }
        public string Name { get; set; }
        public bool Silent { get; set; }
        public int Skill1 { get; set; }
        public int Skill2 { get; set; }
        public int Skill3 { get; set; }

        public virtual Characters Character { get; set; }
    }
}
