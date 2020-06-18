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
                    case 110:
                        return "剑客";
                    case 111:
                        return "勇士";
                    case 120:
                        return "准骑士";
                    case 121:
                        return "骑士";
                    case 130:
                        return "枪战士";
                    case 131:
                        return "龙骑士";
                    case 200:
                        return "魔法师";
                    case 210:
                        return "火毒法师";
                    case 211:
                        return "火毒巫师";
                    case 220:
                        return "冰雷法师";
                    case 221:
                        return "冰雷巫师";
                    case 230:
                        return "牧师";
                    case 231:
                        return "主教";
                    case 300:
                        return "弓箭手";
                    case 310:
                        return "猎人";
                    case 311:
                        return "射手";
                    case 320:
                        return "弓弩手";
                    case 321:
                        return "游侠";
                    case 400:
                        return "飞侠";
                    case 410:
                        return "刺客";
                    case 411:
                        return "无影人";
                    case 420:
                        return "侠客";
                    case 421:
                        return "独行客";
                    default:
                        return "新手";
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
                    case 2:
                        return "绿水灵";
                    default:
                        return "隐藏区";
                }
            }
        }
    }
}
