using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Reports
    {
        public uint Id { get; set; }
        public DateTime Reporttime { get; set; }
        public int Reporterid { get; set; }
        public int Victimid { get; set; }
        public sbyte Reason { get; set; }
        public string Chatlog { get; set; }
        public string Status { get; set; }
    }
}
