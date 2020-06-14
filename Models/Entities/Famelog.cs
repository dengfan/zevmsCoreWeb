using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Famelog
    {
        public int Famelogid { get; set; }
        public int Characterid { get; set; }
        public int CharacteridTo { get; set; }
        public DateTime When { get; set; }

        public virtual Characters Character { get; set; }
    }
}
