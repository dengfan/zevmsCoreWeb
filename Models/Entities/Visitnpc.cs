using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Visitnpc
    {
        public int Id { get; set; }
        public int Characterid { get; set; }
        public int Npcid { get; set; }
        public string Npcname { get; set; }
        public int? Visitcout { get; set; }
    }
}
