using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Savedlocations
    {
        public int Id { get; set; }
        public int Characterid { get; set; }
        public string Locationtype { get; set; }
        public int Map { get; set; }

        public virtual Characters Character { get; set; }
    }
}
