using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class CharactersKmob
    {
        public int Id { get; set; }
        public int? Mobshuliang { get; set; }

        public virtual Characters IdNavigation { get; set; }
    }
}
