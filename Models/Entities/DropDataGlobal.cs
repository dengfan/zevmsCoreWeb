using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class DropDataGlobal
    {
        public long Id { get; set; }
        public int Continent { get; set; }
        public bool DropType { get; set; }
        public int Itemid { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public int Questid { get; set; }
        public int Chance { get; set; }
        public string Comments { get; set; }
    }
}
