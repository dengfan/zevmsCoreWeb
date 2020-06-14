using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Redenvelopes
    {
        public int Id { get; set; }
        public string Txet { get; set; }
        public int? Characterid { get; set; }
        public int? Leixing1 { get; set; }
        public int? Leixing2 { get; set; }
        public int? Shuliang { get; set; }
        public DateTime? Tiem { get; set; }
        public int? A { get; set; }
    }
}
