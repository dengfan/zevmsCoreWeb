using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Changemapspecial
    {
        public int Id { get; set; }
        public int Charactersid { get; set; }
        public int Mapid { get; set; }

        public virtual Characters Characters { get; set; }
    }
}
