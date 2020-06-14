using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Buddyentries
    {
        public int Id { get; set; }
        public int Owner { get; set; }
        public int Buddyid { get; set; }

        public virtual Characters OwnerNavigation { get; set; }
    }
}
