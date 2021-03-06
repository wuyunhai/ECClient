﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Net.NetworkInformation;
using CCWin;
using DM_API;
using SuperSocket.SocketEngine;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System.Net;
using System.Collections.Concurrent;
using SuperSocket.SocketBase.Config;

namespace EsayCare.MES
{
    public partial class FormMain : Skin_Metro
    {
        #region var
        #region main

        //标识网络是否通畅
        public bool IsConnectionOK = false;
        //可执行文件路径
        public string ExePath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory; }
        }
        //计时数
        private long timeCounter = 0;
        //日志记录助手
        private LogHelper log;
        //配置文件助手
        private ConfigHelper cfgHelper;

        #endregion

        #region CH_var

        public delegate void CbDelegate();
        public delegate void CbDelegate<T1>(T1 obj1);
        public delegate void CbDelegate<T1, T2>(T1 obj1, T2 obj2);
        private MesServer mesServer;
        private DM_SFCInterface SFCInterface;
        private Dictionary<string, string> dicAnimals;
        public static ConcurrentDictionary<string, MesSession> mOnLineConnections = new ConcurrentDictionary<string, MesSession>();

        public string WO;
        public string SN;

        /// <summary>
        /// 图片路径
        /// </summary>
        public string SelfPath
        {
            get
            {
                string Path = Assembly.GetExecutingAssembly().Location;
                Path = Path.Substring(0, Path.LastIndexOf('\\'));
                return Path + "\\animals\\";
            }
        }

        #endregion

        #endregion

        #region 构造函数

        public FormMain()
        {
            InitializeComponent();

            #region main

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 在缓冲区重绘
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            #endregion
        }

        #endregion

        #region 窗体载入

        private void FormMain_Load(object sender, EventArgs e)
        {
            #region main 
            GlobalData.InitGlobalData();//初始化全局数据
            //设置界面元素
            Indicator.Text = "程序正在加载中,请稍后...";
            Indicator.ShowText = true;
            Indicator.Start();

            this.Text = string.Format("IA-MES CS端系统 ({0} - {1})", GlobalData.Process, GlobalData.MachineId);
            CenterImage.Image = Image.FromFile(ExePath + @"Res\Network2.png");
            staStripVersion.Text = "版本：" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            InitFormMainContext();
            //隐藏条码-日志窗口
            tabCtrlBottom.Visible = false;
            //启动网络连接监测线程
            Thread threadPing = new Thread(CheckNetConnection);
            threadPing.IsBackground = true;
            threadPing.Priority = ThreadPriority.Lowest;
            threadPing.Start(GlobalData.EQCServerIP);

            #endregion

            #region CH
            cmbClients.DisplayMember = "RemoteEndPoint";
            cmbClients.ValueMember = "SessionID";

            LoadAnimal();
            SFCInterface = new DM_SFCInterface();
            GetWOCollection("CH");

            InitAppServer();
            #endregion
        }

        private void InitAppServer()
        {
            try
            {

                Indicator.Text = "初始化MES服务器...";
                //方法一、采用当前应用程序中的【App.config】文件。
                //var bootstrap = BootstrapFactory.CreateBootstrap();

                //=>方法二、采用自定义独立【SuperSocket.config】配置文件
                var bootstrap = BootstrapFactory.CreateBootstrapFromConfigFile("SuperSocket.config");

                #region [=>自定义服务配置]
                //IServerConfig serverConfig = new ServerConfig
                //{
                //    Name = "MesServer",// "AgileServer",//服务器实例的名称
                //    ServerType = "EsayCare.MES.MesServer, EsayCare.MES",
                //    Ip = "Any",//Any - 所有的IPv4地址 IPv6Any - 所有的IPv6地址
                //    Mode = SocketMode.Tcp,//服务器运行的模式, Tcp (默认) 或者 Udp
                //    Port = int.Parse("6543"),//服务器监听的端口
                //    SendingQueueSize = 5000,//发送队列最大长度, 默认值为5
                //    MaxConnectionNumber = 5000,//可允许连接的最大连接数
                //    LogCommand = false,//是否记录命令执行的记录
                //    LogBasicSessionActivity = false,//是否记录session的基本活动，如连接和断开
                //    LogAllSocketException = false,//是否记录所有Socket异常和错误
                //    //Security = "tls",//Empty, Tls, Ssl3. Socket服务器所采用的传输层加密协议
                //    MaxRequestLength = 5000,//最大允许的请求长度，默认值为1024
                //    TextEncoding = "UTF-8",//文本的默认编码，默认值是 ASCII，（###改成UTF-8,否则的话中文会出现乱码）
                //    KeepAliveTime = 60,//网络连接正常情况下的keep alive数据的发送间隔, 默认值为 600, 单位为秒
                //    KeepAliveInterval = 60,//Keep alive失败之后, keep alive探测包的发送间隔，默认值为 60, 单位为秒
                //    ClearIdleSession = true, // 是否定时清空空闲会话，默认值是 false;（###如果开启定时60秒钟情况闲置的连接，为了保证客户端正常不掉线连接到服务器，故我们需要设置10秒的心跳数据包检查。也就是说清除闲置的时间必须大于心跳数据包的间隔时间，否则就会出现服务端主动踢掉闲置的TCP客户端连接。）
                //    ClearIdleSessionInterval = 60,//: 清空空闲会话的时间间隔, 默认值是120, 单位为秒;
                //    SyncSend = true,//:是否启用同步发送模式, 默认值: false;
                //};
                //var rootConfig = new RootConfig()
                //{

                //    MaxWorkingThreads = 5000,//线程池最大工作线程数量
                //    MinWorkingThreads = 10,// 线程池最小工作线程数量;
                //    MaxCompletionPortThreads = 5000,//线程池最大完成端口线程数量;
                //    MinCompletionPortThreads = 10,// 线程池最小完成端口线程数量;
                //    DisablePerformanceDataCollector = true,// 是否禁用性能数据采集;
                //    PerformanceDataCollectInterval = 60,// 性能数据采集频率 (单位为秒, 默认值: 60);
                //    LogFactory = "ConsoleLogFactory",//默认logFactory的名字
                //    Isolation = IsolationMode.AppDomain// 服务器实例隔离级别                
                //};
                #endregion

                if (!bootstrap.Initialize())
                {
                    ShowMessage(ColorHelper.MsgRed, "Failed to initialize!");
                    return;
                }
                StartResult startResult = bootstrap.Start();
                if (startResult == StartResult.Success)
                {
                    Indicator.Visible = false;
                    this.ShowMessage(ColorHelper.MsgGreen, "服务启动成功，等待设备连接 =>");
                    mesServer = bootstrap.AppServers.Cast<MesServer>().FirstOrDefault();
                    if (mesServer != null)
                    {
                        mesServer.NewSessionConnected += MesServer_NewSessionConnected;
                        mesServer.NewRequestReceived += MesServer_NewRequestReceived;
                        mesServer.SessionClosed += MesServer_SessionClosed;
                     
                    }
                    else
                        this.ShowMessage(ColorHelper.MsgRed, "请检查配置文件中是否有可用的服务信息！");
                }
                else
                    this.ShowMessage(ColorHelper.MsgRed, "服务启动失败！");
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void MesServer_SessionClosed(MesSession session, global::SuperSocket.SocketBase.CloseReason value)
        {
            this.ShowMessage(session.RemoteEndPoint, "断开连接");
            MesSession outMesSession;
            mOnLineConnections.TryRemove(session.SessionID, out outMesSession);
            this.ShowConnectionCount(mOnLineConnections.Count);
            ShowClientsMessage(mOnLineConnections);
            //this.ShowConnectionCount(this.tcpServerEngine.SessionCount);
        }

        void MesServer_NewRequestReceived(MesSession session, StringRequestInfo requestInfo)
        {
            switch (requestInfo.Key)
            {
                case "echo":
                    this.ShowMessage(session.RemoteEndPoint, requestInfo.Body);
                    break;
                case "heartbeat":
                    this.ShowMessage(session.RemoteEndPoint, requestInfo.Body);
                    string msg = string.Format("push {0}", requestInfo.Body + Environment.NewLine);//一定要加上分隔符
                    byte[] bMsg = System.Text.Encoding.UTF8.GetBytes(msg);//消息使用UTF-8编码
                    session.Send(new ArraySegment<byte>(bMsg, 0, bMsg.Length));
                    break;
                default:
                    this.ShowMessage(session.RemoteEndPoint, "未知的指令（error unknow command）");
                    break;
            }
        }
        //private void Client_NewPackageReceived(object sender, PackageEventArgs<MesPackageInfo> e)
        //{
        //    if (e.Package.TData != null)
        //    {
        //        switch (e.Package.Header)
        //        {
        //            case "ISR":
        //                if (e.Package.TData.CheckResult == CheckResultCode.OK.ToString())
        //                {
        //                    ShowMessage("请开始扫描彩盒ID条码.");
        //                }
        //                else
        //                {
        //                    ShowMessage("设备未具备开工条件.");
        //                    if (client != null)
        //                    {
        //                        client.Close();
        //                        client = null;
        //                    }

        //                }
        //                break;
        //            case "SNC":
        //                ShowSNCheckResult(e.Package.TData.CheckResult);
        //                if (e.Package.TData.CheckResult == CheckResultCode.OK.ToString())
        //                {
        //                    try
        //                    {
        //                        DataTable dt = SFCInterface.SFC_DM_CheckRoute(e.Package.TData.SN, GlobalData.EquipmentNO, e.Package.TData.WO, "PASS");//FAIL

        //                        string CheckStatus = dt.Rows[0][0].ToString().ToString();
        //                        string ReturnMsg = dt.Rows[0][1].ToString().ToString();
        //                        if (CheckStatus == "1") //成功  
        //                        {
        //                            ShowMessage("MES过站成功>>" + CheckStatus + ":" + ReturnMsg);
        //                            // 加载下一条
        //                            GetNextSN(WO);
        //                        }
        //                        else
        //                        {
        //                            ShowMessage("MES过站失败>>" + CheckStatus + ":" + ReturnMsg);
        //                        }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        ShowMessage("执行过站方法出错>>" + ex.Message);
        //                    }
        //                }
        //                else
        //                {
        //                    for (int i = 5; i > 0; i--)
        //                    {
        //                        ShowMessage("彩盒SN校验失败，【" + i.ToString() + "】秒后重新下发.");
        //                        Thread.Sleep(1000);
        //                    }
        //                    ShowMessage("条码已重新下发.");
        //                    SendFactory(FunCode.SND.ToString());
        //                }
        //                break;

        //            default:
        //                ShowMessage("未能识别该功能码：" + e.Package.Header);
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        ShowMessage("提示：协议格式错误，协议格式：3位功能码 + 空格 + json字符串 + 回车换行符.");
        //    }
        //}
         
         

        void MesServer_NewSessionConnected(MesSession session)
        {
            this.ShowMessage(session.RemoteEndPoint, "连接成功！");
            mOnLineConnections.TryAdd(session.SessionID, session);
            this.ShowConnectionCount(mOnLineConnections.Count);
            ShowClientsMessage(mOnLineConnections);
        }
         

        #endregion

        #region 加载窗口内容

        private void InitFormMainContext()
        {
            #region main

            cfgHelper = GlobalData.CfgHelper;
            log = GlobalData.Log;
            log.OnDisplayLog += OnDisplayLog;

            #endregion
        }

        #endregion

        #region 查询彩盒制令单

        /// <summary>
        /// 查询彩盒制令单
        /// </summary>
        /// <param name="v"></param>
        private void GetWOCollection(string v)
        {
            Indicator.Text = "加载制令单...";
            //TODO:1-查询彩盒制令单

            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add("制令单号");

            List<string> lstWo = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                dr = dt.NewRow();
                dr["制令单号"] = "WO020306900" + i.ToString();
                dt.Rows.Add(dr);
                lstWo.Add("WO020306900" + i.ToString());
            }

            cmbWO.DataSource = lstWo;
            cmbWO.SelectedIndex = -1;
        }

        private void LoadAnimal()
        {
            dicAnimals = new Dictionary<string, string>();
            dicAnimals.Add("鼠", SelfPath + "shu.jpg");
            dicAnimals.Add("牛", SelfPath + "niu.jpg");
            dicAnimals.Add("虎", SelfPath + "hu.jpg");
            dicAnimals.Add("兔", SelfPath + "tu.jpg");
            dicAnimals.Add("龙", SelfPath + "long.jpg");
            dicAnimals.Add("蛇", SelfPath + "she.jpg");
            dicAnimals.Add("马", SelfPath + "ma.jpg");
            dicAnimals.Add("羊", SelfPath + "yang.jpg");
            dicAnimals.Add("猴", SelfPath + "hou.jpg");
            dicAnimals.Add("鸡", SelfPath + "ji.jpg");
            dicAnimals.Add("狗", SelfPath + "gou.jpg");
            dicAnimals.Add("猪", SelfPath + "zhu.jpg");
        }

        #endregion

        #region 图片显示

        private void OnDisplayPic(string path)
        {
            Invoke(new Action<string>((fullPath) =>
            {
                if (string.IsNullOrWhiteSpace(fullPath))
                    picBox.Image = null;
                else
                    picBox.Image = Image.FromFile(path);
            }), path);
        }

        #endregion

        #region 日志显示

        private void ShowClientsMessage(ConcurrentDictionary<string, MesSession> msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<ConcurrentDictionary<string, MesSession>>(this.ShowClientsMessage), msg);
            }
            else
            {
                this.cmbClients.DataSource = msg.Values;
                if (msg.Values.Count > 0 && cmbClients.Text != "")
                {
                    this.cmbClients.SelectedIndex = 0;
                }
                else
                {
                    this.cmbClients.SelectedIndex = -1;
                    this.cmbClients.Text = "";
                    this.cmbWO.Enabled = false;
                    this.btnOK.Enabled = false;
                }
                cmbClients.Enabled = false;
                btnUnLock.Text = "解 锁";
            }
        }

        private void ShowSNCheckResult(string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string>(this.ShowSNCheckResult), msg);
            }
            else
            {
                if (msg == CheckResultCode.OK.ToString())
                    lblSNC.ForeColor = Color.FromArgb(255, 30, 200, 100);
                else
                    lblSNC.ForeColor = Color.Red;
                lblSNC.Text = msg;
            }
        }
        private void ShowMessage(string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string>(this.ShowMessage), msg);
            }
            else
            {

                log.Info(msg);
                lblInfo.Text = msg;
            }
        }
        private void ShowMessage(IPEndPoint client, string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<IPEndPoint, string>(this.ShowMessage), client, msg);
            }
            else
            {
                log.Info(msg);
                lblInfo.Text = client.ToString() + " " + msg;
            }
        }
        private void ShowMessage(Color color, string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<Color, string>(this.ShowMessage), color, msg);
            }
            else
            {
                log.Info(msg);
                lblInfo.Text = msg;
                lblInfo.ForeColor = color;
            }
        }

        private void ShowConnectionCount(int clientCount)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<int>(this.ShowConnectionCount), clientCount);
            }
            else
            {
                this.toolStripLabel_clientCount.Text = "在线数量： " + clientCount.ToString();
            }
        }
        #endregion

        #region 确认

        private void btnOK_Click(object sender, EventArgs e)
        {
            SendFactory(FunCode.ISR.ToString()); 
        }
          
        #endregion

        #region 取消

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 选择制令单加载事件

        private void cmbWO_DropDownClosed(object sender, EventArgs e)
        {
            Clear();
            if (cmbWO.SelectedValue != null)
            {
                btnOK.Enabled = (this.mesServer.State == ServerState.Running);
                //清空数据
                WO = cmbWO.SelectedValue.ToString();
                GetBoxInforByWO(WO);
            }
        }

        private void Clear()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate(this.Clear));
            }
            else
            {
                dgvList.DataSource = null;
                lblCount.Text = "";
                lblCountP.Text = "";
                lblCountU.Text = "";
                lblSNC.Text = "";
                picBox.Image = null;
            }

        }

        /// <summary>
        /// 查询制令单关联的个性化工单
        /// </summary>
        private void GetBoxInforByWO(string wo)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string>(this.GetBoxInforByWO), wo);
            }
            else
            {
                //TODO:2-根据制令单查询个性化小工单

                //------------------------test
                if (cmbWO.SelectedIndex != 0)
                    return;


                DataTable dt = new DataTable();
                dt.Columns.Add("序号");
                dt.Columns.Add("彩盒工单");
                dt.Columns.Add("彩盒条码");
                dt.Columns.Add("类型");
                dt.Columns.Add("属性");
                dt.Columns.Add("描述");
                dt.Columns.Add("工单总数");
                dt.Columns.Add("已生产数");
                dt.Columns.Add("未生产数");
                DataRow dr = dt.NewRow();
                dr[0] = 1;
                dr[1] = "WO09876";
                dr[2] = "SN098765";
                dr[3] = "5瓶装";
                dr[4] = "龙";
                dr[5] = "Description";
                dr[6] = "100";
                dr[7] = "65";
                dr[8] = "35";
                dt.Rows.Add(dr);
                dgvList.AutoGenerateColumns = false;

                if (dt == null && dt.Rows.Count == 0) return;
                dgvList.DataSource = dt;
                SN = dt.Rows[0]["彩盒工单"].ToString();
                //notice
                lblCount.Text = dt.Rows[0]["工单总数"].ToString();
                lblCountP.Text = dt.Rows[0]["已生产数"].ToString();
                lblCountU.Text = dt.Rows[0]["未生产数"].ToString();

                ShowMessage("点击确认按钮，锁定工单，并询问设备是否具备开工条件.");
            }
        }

        #endregion

        #region 根据盒子属性加载相应图片

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string sType = dgvList.Rows[0].Cells[3].Value.ToString();
                OnDisplayPic(dicAnimals[sType]);
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region 彩盒规格校验

        /// <summary>
        /// 彩盒规格校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private bool GetBoxSpecCheck(string wo, string boxID)
        {
            //TODO:3--彩盒ID校验
            return true;
        }

        //模拟条码校验
        private void skinLabel3_DoubleClick(object sender, EventArgs e)
        {
            bool b = GetBoxSpecCheck(cmbWO.SelectedText, txbBoxID.Text);
            if (b)
            {
                SendFactory(FunCode.SND.ToString());
            }
        }

        //

        #endregion

        #region 客户端发送消息

        private void SendFactory(string funCode)
        {
            try
            {
                MesSession mesSession = (MesSession)this.cmbClients.SelectedItem;
                if (mesSession == null)
                {
                    ShowMessage("没有选中任何在线设备！");
                    return;
                }
                if (!mesSession.Connected)
                {
                    ShowMessage("目标设备不在线！");
                    return;
                }
                 
                TransmitData tData = null;
                switch (funCode)
                {
                    case "ISR":
                        ShowMessage("询问设备是否具备开工条件.");
                        tData = new TransmitData(WO, GlobalData.EquipmentNO, null, null, null, null);
                        break;
                    case "SND":
                        ShowMessage("彩盒规格校验ok，下发SN打印.");
                        tData = new TransmitData(WO, GlobalData.EquipmentNO, SN, null, null, null);
                        tData.Items.Add("url", GlobalData.URL);
                        break;
                }
                string msg = funCode + GlobalData.SpacePoint + JsonHelper.Serialize(tData) + Environment.NewLine;//一定要加上分隔符 
                byte[] bMsg = System.Text.Encoding.UTF8.GetBytes(msg);//消息使用UTF-8编码
                mesSession.Send(new ArraySegment<byte>(bMsg, 0, bMsg.Length));
            }
            catch (Exception ee)
            {
                ShowMessage(ee.Message);
            } 
        }

        #endregion

        #region 获取下一条工单记录（SN）
        private void skinLabel1_DoubleClick(object sender, EventArgs e)
        {
            if (cmbWO.SelectedValue != null)
            {
                GetNextSN(cmbWO.SelectedText);
            }
        }

        /// <summary>
        /// TODO:4---获取下一条工单记录
        /// </summary>
        /// <param name="wO"></param>
        private void GetNextSN(string wO)
        {
            Thread.Sleep(1000);

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string>(this.GetNextSN), wO);
            }
            else
            {
                Clear();

                //------------------------test
                if (cmbWO.SelectedIndex != 0)
                    return;

                DataTable dt = new DataTable();
                dt.Columns.Add("序号");
                dt.Columns.Add("彩盒工单");
                dt.Columns.Add("彩盒条码");
                dt.Columns.Add("类型");
                dt.Columns.Add("属性");
                dt.Columns.Add("描述");
                dt.Columns.Add("工单总数");
                dt.Columns.Add("已生产数");
                dt.Columns.Add("未生产数");
                DataRow dr = dt.NewRow();
                dr[0] = 2;
                dr[1] = "WO09876";
                dr[2] = "SN098765";
                dr[3] = "5瓶装";
                dr[4] = "蛇";
                dr[5] = "Description";
                dr[6] = "100";
                dr[7] = "65";
                dr[8] = "35";
                dt.Rows.Add(dr);
                dgvList.AutoGenerateColumns = false;

                if (dt == null && dt.Rows.Count == 0) return;
                dgvList.DataSource = dt;
                SN = dt.Rows[0]["彩盒工单"].ToString();
                //notice
                lblCount.Text = dt.Rows[0]["工单总数"].ToString();
                lblCountP.Text = dt.Rows[0]["已生产数"].ToString();
                lblCountU.Text = dt.Rows[0]["未生产数"].ToString();

                ShowMessage("请扫描彩盒ID条码");
            }

        }
        #endregion

        //-------------------------------------------------------------------------
        #region main

        /// <summary>
        /// 使用ping检测网络是否通畅
        /// </summary>
        /// <param name="ip">被测主机IP地址</param>
        /// <returns></returns>
        private void CheckNetConnection(object obj)
        {

            object lockObj = new object();
            string ip = obj as string;
            Ping ping = new Ping();
            while (true)
            {
                try
                {
                    PingReply pingReply_Server = ping.Send(ip, 2000);
                    PingReply pingReply_Plc = ping.Send(GlobalData.EQCServerIP, 2000);
                    lock (lockObj)
                    {
                        if (pingReply_Plc.Status == IPStatus.Success && pingReply_Server.Status == IPStatus.Success)
                        {
                            IsConnectionOK = true;
                        }
                        else
                        {
                            IsConnectionOK = false;
                        }
                    }
                }
                catch (Exception)
                {
                    IsConnectionOK = false;
                }
                finally
                {
                    Thread.Sleep(2000);
                }
            }
        }
        /// <summary>
        /// 显示日志信息
        /// </summary>
        /// <param name="msg"></param>
        private void OnDisplayLog(string msg)
        {
            this.Invoke(new Action<string>((message) =>
            {
                rtbLog.AppendText(message);
                rtbLog.ScrollToCaret();
                message = message.Substring(message.IndexOf(">>") + 2);
                message = "信息：" + message.Substring(0, message.LastIndexOf('('));
                staStripNote.Text = message;
            }), msg);
        }
        /// <summary>
        /// 主界面定时器事件
        /// </summary>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            //更新时间
            staStripTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //更新当前操作工
            lblLoginUser.Text = "admin";

            //检查网络连接 
            if (timeCounter % 5 == 0)
            {
                if (IsConnectionOK)
                {
                    if (IsConnectionOK)
                    {
                        CenterImage.Image = Image.FromFile(ExePath + @"Res\Network.png");
                    }
                    else
                    {
                        CenterImage.Image = Image.FromFile(ExePath + @"Res\Network2.png");
                    }
                    //IsNetConnected = IsConnectionOK;
                }
            }
            timeCounter++;
        }
        /// <summary>
        /// 状态条提示文字
        /// </summary>
        private void staStripNote_Click(object sender, EventArgs e)
        {
            staStripShowOutWnd_Click(null, null);
        }
        /// <summary>
        /// 显隐条码和日志窗口
        /// </summary>
        private void staStripShowOutWnd_Click(object sender, EventArgs e)
        {
            tabCtrlBottom.Visible = !tabCtrlBottom.Visible;
            if (tabCtrlBottom.Visible)
            {
                staStripShowOutWnd.Text = " ↓ [条码-日志]";
            }
            else
            {
                staStripShowOutWnd.Text = " ↑ [条码-日志]";
            }
        }
        /// <summary>
        /// 测试2
        /// </summary>
        private void staStripTest2_Click(object sender, EventArgs e)
        {
            MainSplit.Panel1Collapsed = !MainSplit.Panel1Collapsed;

            log.Debug("测试启动");
        }
        #region /// <summary> 退出处理
        /// <summary>
        /// 双击登录头像框，注销并弹出登录框
        /// </summary>
        private void picLoginUser_DoubleClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 双击登录用户名，注销并弹出登录框
        /// </summary>
        private void lblLoginUser_DoubleClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 双击标题栏图标，退出系统
        /// </summary>
        private void picMainIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblMainTitle_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 主窗口关闭处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出本系统吗？", "退出系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                log.OnDisplayLog -= OnDisplayLog;
            }
        }



        #endregion 退出处理
        private void picNetwork_Click(object sender, EventArgs e)
        {
            MainSplit.Panel1Collapsed = !MainSplit.Panel1Collapsed;
        }

        #endregion

        private void cboClients_DropDown(object sender, EventArgs e)
        {
            if (mesServer == null)
            {
                this.cmbClients.DataSource = null;
                return;
            }
            ShowClientsMessage(mOnLineConnections);
        }

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            if (cmbClients.Items.Count > 0)
            {
                cmbClients.Enabled = !cmbClients.Enabled;
                if (btnUnLock.Text == "解 锁")
                    btnUnLock.Text = "锁 定";
                else
                    btnUnLock.Text = "解 锁";
            }
            else
            {
                MessageBox.Show("无设备连接.");
            }

        }

        private void cmbClients_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbClients.SelectedValue != null)
            {
                ShowMessage("请选择制令单.");
                cmbWO.Enabled = true;
            }
        }

        private void cmbWO_DropDown(object sender, EventArgs e)
        {

        }
    }
}
