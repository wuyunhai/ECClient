using SuperSocket.ProtoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCXJ_CS.Applications;

namespace ZCXJ_CS.UI
{
    public class MesPackageInfo : IPackageInfo
    {
        public MesPackageInfo(string header, string body,string fullData, TransmitData tData)
        {
            Header = header;
            Body = body;
            Data = fullData;

            TData = new TransmitData();
            TData = tData;
        }
        /// <summary>
        /// 服务器返回的字节数据头部
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// 服务器返回的字节数据
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// 服务器返回的字符串数据
        /// </summary>
        public string Body { get; set; } 

        public TransmitData  TData { get; set; }


    }
}
