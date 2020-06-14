using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Playernpcs
    {
        public Playernpcs()
        {
            PlayernpcsEquip = new HashSet<PlayernpcsEquip>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Hair { get; set; }
        public int Face { get; set; }
        public int Skin { get; set; }
        public int Dir { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Cy { get; set; }
        public int Map { get; set; }
        public int Gender { get; set; }
        public uint ScriptId { get; set; }
        public int Foothold { get; set; }
        public int Rx0 { get; set; }
        public int Rx1 { get; set; }

        public virtual ICollection<PlayernpcsEquip> PlayernpcsEquip { get; set; }
    }
}
