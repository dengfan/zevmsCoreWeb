using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Charactersiy
    {
        public int Id { get; set; }
        public int? Feiqifubentongguan1 { get; set; }

        public virtual Characters IdNavigation { get; set; }
    }
}
