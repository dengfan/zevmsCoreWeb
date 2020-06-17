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

        public int World { get; set; }
        public string WorldName
        {
            get
            {
                switch (World)
                {
                    case 0:
                        return "蓝蜗牛";
                    case 1:
                        return "蘑菇仔";
                    default:
                        return "基佬";
                }
            }
        }
    }
}
