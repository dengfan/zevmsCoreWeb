using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class DlqIllegalRecords
    {
        public int Id { get; set; }
        public string Machine { get; set; }
        public int? IllegalFrequency { get; set; }
        public string Duetime { get; set; }
        public string Remarks { get; set; }
    }
}
