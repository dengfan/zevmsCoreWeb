using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class PlayerQuests
    {
        public int Id { get; set; }
        public int? Charid { get; set; }
        public int? Questid { get; set; }
        public string Data { get; set; }
        public int? State { get; set; }
        public string Name { get; set; }

        public virtual Characters Char { get; set; }
    }
}
