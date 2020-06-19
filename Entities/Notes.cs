using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Notes
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Message { get; set; }
        public ulong Timestamp { get; set; }
        public bool Fame { get; set; }
    }
}
