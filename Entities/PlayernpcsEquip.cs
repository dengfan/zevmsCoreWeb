using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class PlayernpcsEquip
    {
        public int Id { get; set; }
        public int Npcid { get; set; }
        public int Equipid { get; set; }
        public int Equippos { get; set; }

        public virtual Playernpcs Npc { get; set; }
    }
}
