using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Characterslots
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public byte World { get; set; }
        public byte Slots { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
