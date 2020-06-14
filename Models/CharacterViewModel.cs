using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZEVMSWEB.Models
{
    public class CharacterViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }

        public int Job { get; set; }

        public string JobName
        {
            get
            {
                switch (Job)
                {
                    case 100:
                        return "战士";
                    default:
                        return "基佬";
                }
            }
        }
    }
}
