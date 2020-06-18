using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZEVMSWEB.Models
{
    public class ReponseJsonViewModel
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public object Body { get; set; }
    }
}
