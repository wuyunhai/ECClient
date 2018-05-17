using System;
using ZCXJ_CS.Utilities;


namespace ZCXJ_CS.Applications
{
    public class GlobalData : Object
    { 
        //配置文件助手
        public static ConfigHelper CfgHelper = null;
        //日志助手对象
        public static LogHelper Log = null;  
        //当前工序类型
        public static string Process;
        //当前工序类型
        public static string MachineId;
        //EQC服务器IP,Port
        public static string EQCServerIP; 
        public static string EQCServerPort;
        //MES服务器IP,Port
        public static string MESServerIP;
        public static string MESServerPort;


        /// <summary>
        /// 初始化全局数据
        /// </summary>
        public static void InitGlobalData()
        { 
            //配置文件对象
            CfgHelper = new ConfigHelper();
            LoadConfig();
            //日志对象
            Log = LogHelper.GetInstence();
            Log.StartLog(LogLevel.DEBUG);
             
        }

        ~GlobalData()
        {
            
        }
        

        /// <summary>
        /// 读取配置参数
        /// </summary>
        public static void LoadConfig()
        {
            //读取配置参数
            MachineId = CfgHelper.GetKeyValue("MachineId");
            Process = CfgHelper.GetKeyValue("Process");
            MESServerIP = CfgHelper.GetKeyValue("EQCServerIP");
            MESServerPort = CfgHelper.GetKeyValue("EQCServerPort");
            EQCServerIP = CfgHelper.GetKeyValue("EQCServerIP");
            EQCServerPort = CfgHelper.GetKeyValue("EQCServerPort");
             
        }
    }
}
