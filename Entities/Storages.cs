using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Storages
    {
        public uint Storageid { get; set; }
        public int Accountid { get; set; }
        public int Slots { get; set; }
        public int Meso { get; set; }
        public bool? World { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
