using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Warehouse
    {
        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? Itemid { get; set; }
        public int? Cout { get; set; }
        public long? Time { get; set; }
        public int? World { get; set; }
    }
}
