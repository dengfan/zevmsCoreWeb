using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZEVMSWEB.Models
{
    public class InventoryItemViewModel
    {
        public long Id { get; set; }

        public int InventoryType { get; set; }

        public string ItemImageBase64String { get; set; }

        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string OwnerCharacterName { get; set; }

        public int OwnerCharacterId { get; set; }

        public int Quantity { get; set; }

        public long Price { get; set; }

        /// <summary>
        /// 力量
        /// </summary>
        public int Strong { get; set; }

        /// <summary>
        /// 敏捷
        /// </summary>
        public int Dexterity { get; set; }
        
        /// <summary>
        /// 智力
        /// </summary>
        public int Intelligence { get; set; }

        /// <summary>
        /// 运气
        /// </summary>
        public int Luck { get; set; }

        /// <summary>
        /// 物理攻击
        /// </summary>
        public int WAtk { get; set; }

        /// <summary>
        /// 物防
        /// </summary>
        public int WDef { get; set; }

        /// <summary>
        /// 魔攻
        /// </summary>
        public int MAtk { get; set; }

        /// <summary>
        /// 魔防
        /// </summary>
        public int MDef { get; set; }

        /// <summary>
        /// 移动速度
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// 跳跃力
        /// </summary>
        public int Jump { get; set; }

        /// <summary>
        /// 打孔数，用于判断装备品级
        /// </summary>
        public int DakongCount { get; set; }

        /// <summary>
        /// 附魔信息
        /// </summary>
        public string FumoDesc { get; set; }
    }
}
