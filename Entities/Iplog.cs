using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Iplog
    {
        public uint Iplogid { get; set; }
        public int Accountid { get; set; }
        public string Ip { get; set; }
        public DateTime Login { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
