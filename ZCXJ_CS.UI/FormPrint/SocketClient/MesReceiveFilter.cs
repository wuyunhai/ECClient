using SuperSocket.ProtoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZCXJ_CS.Applications;
using ZCXJ_CS.Utilities;

namespace ZCXJ_CS.UI
{
    public class MesReceiveFilter : TerminatorReceiveFilter<MesPackageInfo>
    {

        public MesReceiveFilter() : base(Encoding.ASCII.GetBytes("\r\n"))
        {

        }

        public override MesPackageInfo ResolvePackage(IBufferStream bufferStream)
        {
            TransmitData TData = new TransmitData();
            string cmdFullText = string.Empty;
            string key = string.Empty;
            string body = string.Empty;
            string strTData = string.Empty;
            //string[] parameters = null;

            cmdFullText = bufferStream.ReadString((int)bufferStream.Length, Encoding.UTF8);
            key = Regex.Split(cmdFullText, "\u0020")[0];
            body = string.Join("", cmdFullText.ToArray().Skip(key.ToArray().Length + 1).ToList());
            body = body.TrimEnd("\r\n".ToCharArray());
            TData = JsonHelper.Deserialize<TransmitData>(body);
            if (TData != null) TData.Func = key;
            return new MesPackageInfo(key, body, cmdFullText, TData);
        }
    }
}
