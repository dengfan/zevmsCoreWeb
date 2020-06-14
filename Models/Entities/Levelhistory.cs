using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Levelhistory
    {
        public int Accountid { get; set; }
        public int Characterid { get; set; }
        public int Level { get; set; }
        public DateTime Date { get; set; }
        public long Time { get; set; }
    }
}
