using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Reactordrops
    {
        public uint Reactordropid { get; set; }
        public int Reactorid { get; set; }
        public int Itemid { get; set; }
        public int Chance { get; set; }
        public int Questid { get; set; }
    }
}
