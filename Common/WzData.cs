using reWZ;
using reWZ.WZProperties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ZEVMSWEB.Common
{
    public class WzData
    {
        public Dictionary<int, string> ItemIdAndNameDic { get; set; }

        public static string GetImageBase64String(int itemId, int inventoryType, WZFile wzfile)
        {
            WZCanvasProperty wzcp = null;
            try
            {
                switch (inventoryType)
                {
                    case 1: // 装备
                        var cat = GetCharacterItemTypeName(itemId);
                        if (string.IsNullOrEmpty(cat))
                        {
                            return string.Empty;
                        }

                        wzcp = wzfile.MainDirectory["Character"][cat][string.Concat(itemId.ToString().PadLeft(8, '0'), ".img")]["info"]["icon"] as WZCanvasProperty;
                        break;
                    case 2: // 消耗
                    case 3: // 消耗
                    case 4: // 材料
                        cat = "Consume";
                        if (inventoryType == 3 || inventoryType == 4)
                        {
                            cat = "Etc";
                        }

                        var o = wzfile.MainDirectory["Item"][cat][string.Concat(itemId.ToString().PadLeft(8, '0').Substring(0, 4), ".img")][itemId.ToString().PadLeft(8, '0')]["info"]["icon"];
                        if (o is WZUOLProperty)
                        {
                            var uol = o as WZUOLProperty; // ../../02040002/info/icon
                            if (uol != null)
                            {
                                var path = uol.Value;
                                o = o.Parent;
                                while (path.StartsWith("../"))
                                {
                                    o = o.Parent;
                                    path = path.Substring(3);
                                }

                                wzcp = o.ResolvePath(path) as WZCanvasProperty;
                            }
                        }
                        else
                        {
                            wzcp = o as WZCanvasProperty;
                        }
                        break;
                    default:
                        break;
                }

                if (wzcp == null)
                {
                    return string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }

            using (Bitmap m = wzcp.Value)
            {
                if (m != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        m.Save(ms, ImageFormat.Png);
                        byte[] byteImage = ms.ToArray();
                        return Convert.ToBase64String(byteImage);
                    }
                }
            }

            return string.Empty;
        }

        //UNKNOWN(0),
        //EQUIP(1),
        //USE(2),
        //SETUP(3),
        //ETC(4),
        //CASH(5),
        //EQUIPPED(-1);

        public static string GetCharacterItemTypeName(int itemId)
        {
            string cat = string.Empty;

            if (itemId >= 1010000 && itemId < 1040000 || itemId >= 1122000 && itemId < 1123000)
            {
                cat = "Accessory";
            }
            else if (itemId >= 1000000 && itemId < 1010000)
            {
                cat = "Cap";
            }
            else if (itemId >= 1102000 && itemId < 1103000)
            {
                cat = "Cape";
            }
            else if (itemId >= 1040000 && itemId < 1050000)
            {
                cat = "Coat";
            }
            else if (itemId >= 20000 && itemId < 22000)
            {
                cat = "Face";
            }
            else if (itemId >= 1080000 && itemId < 1090000)
            {
                cat = "Glove";
            }
            else if (itemId >= 30000 && itemId < 50000)
            {
                cat = "Hair";
            }
            else if (itemId >= 1050000 && itemId < 1060000)
            {
                cat = "Longcoat";
            }
            else if (itemId >= 1060000 && itemId < 1070000)
            {
                cat = "Pants";
            }
            else if (itemId >= 1802000 && itemId < 1810000)
            {
                cat = "PetEquip";
            }
            else if (itemId >= 1112000 && itemId < 1120000)
            {
                cat = "Ring";
            }
            else if (itemId >= 1092000 && itemId < 1100000)
            {
                cat = "Shield";
            }
            else if (itemId >= 1070000 && itemId < 1080000)
            {
                cat = "Shoes";
            }
            else if (itemId >= 1900000 && itemId < 2000000)
            {
                cat = "Taming";
            }
            else if (itemId >= 1300000 && itemId < 1800000)
            {
                cat = "Weapon";
            }

            return cat;
        }
    }
}
