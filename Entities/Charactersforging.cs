using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Charactersforging
    {
        public int Id { get; set; }
        public int? ForgingExp { get; set; }

        public virtual Characters IdNavigation { get; set; }
    }
}
