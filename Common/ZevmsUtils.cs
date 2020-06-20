using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZEVMSWEB.Models.Entities;

namespace ZEVMSWEB.Common
{
    public class ZevmsUtils
    {
        private static Dictionary<int, string> _fumoDescDic = new Dictionary<int, string>();

        private static void GetFumoDescDic()
        {
            if (_fumoDescDic.Count > 0)
            {
                return;
            }

            using (var context = new zevms027Context())
            {
                var list = context.MxmxdFumoInfo.ToList().Select(o => new { o.FumoType, o.FumoName, o.FumoInfo }).OrderBy(o => o.FumoType);
                foreach (var item in list)
                {
                    if (!_fumoDescDic.ContainsKey(item.FumoType))
                    {
                        _fumoDescDic.Add(item.FumoType, string.Concat(item.FumoName, item.FumoInfo).Replace("%s", "{0}").Replace("%%", "%"));
                    }
                }
            }
        }

        public static int GetDakongCount(string pairs)
        {
            if (string.IsNullOrEmpty(pairs))
            {
                return 0;
            }

            var regex = new Regex(":");
            var matches = regex.Matches(pairs);
            return matches.Count;
        }

        public static string GetFumoDescription(string pairs)
        {
            if (string.IsNullOrEmpty(pairs))
            {
                return string.Empty;
            }

            GetFumoDescDic();

            var sb = new StringBuilder(100);

            try
            {
                var arr = pairs.Split(',');
                foreach (var item in arr)
                {
                    if (string.IsNullOrEmpty(item))
                    {
                        continue;
                    }

                    var arr2 = item.Split(':');
                    var fumoType = Convert.ToInt32(arr2[0]);
                    var fumoVal = arr2[1];
                    var dicInfo = "未知附魔 +{0}";
                    if (_fumoDescDic.ContainsKey(fumoType))
                    {
                        dicInfo = _fumoDescDic[fumoType];
                    }
                    var fumoDesc = string.Format(dicInfo, fumoVal);
                    sb.Append("🔷 <strong>").Append(fumoDesc).Append("</strong><br/>");
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static UdpClient SendToQqGroupClient = new UdpClient(9001);

        public static void SendMsgToQqGroup(string msg)
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                byte[] bytes = Encoding.GetEncoding("GB18030").GetBytes(msg);

                IPAddress remoteIp = IPAddress.Parse("127.0.0.1");
                IPEndPoint remotePoint = new IPEndPoint(remoteIp, 9000);
                SendToQqGroupClient.Send(bytes, bytes.Length, remotePoint);

                Serilog.Log.Logger.Error("SendMsgToGameServer ok");
            }
            catch (Exception ex)
            {
                Serilog.Log.Logger.Error(ex, "SendMsgToGameServer error");
            }
        }
    }
}
