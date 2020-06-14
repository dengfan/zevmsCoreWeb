using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Events
    {
        public int Id { get; set; }
        public int? Week { get; set; }
        public int? Time { get; set; }
        public int? Minute { get; set; }
        public int? Event { get; set; }
        public int? World { get; set; }
    }
}
