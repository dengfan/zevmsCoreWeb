using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Mainpage
    {
        public int Id { get; set; }
        public int? Characterid { get; set; }
        public int? Mainpageid { get; set; }
        public string Caidan { get; set; }
    }
}
