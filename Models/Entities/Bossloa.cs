using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Bossloa
    {
        public int Id { get; set; }
        public int Accountid { get; set; }
        public string Bossid { get; set; }

        public virtual Characters Account { get; set; }
    }
}
