using CCWin;
using DM_API;
using SuperSocket.ClientEngine;
using SuperSocket.ProtoBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZCXJ_CS.Applications;
using ZCXJ_CS.Utilities;


namespace ZCXJ_CS.UI
{
    public partial class FormPrint : FormBase
    {
        #region var

        public delegate void CbDelegate();
        public delegate void CbDelegate<T1>(T1 obj1);
        public delegate void CbDelegate<T1, T2>(T1 obj1, T2 obj2);

        private DM_SFCInterface SFCInterface;
        private EasyClient<MesPackageInfo> client;
        private Dictionary<string, string> dicAnimals;
        public LogHelper log;
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

        #region constructor

        public FormPrint()
        {
            InitializeComponent();
        }

        #endregion

        #region load

        /// <summary>
        /// 初始加载
        /// </summary> 
        private void FormPrint_Load(object sender, EventArgs e)
        {
            log = LogHelper.GetInstence();
            LoadAnimal();
            SFCInterface = new DM_SFCInterface();
            GetWOCollection("CH");
        }

        /// <summary>
        /// 查询彩盒制令单
        /// </summary>
        /// <param name="v"></param>
        private void GetWOCollection(string v)
        {
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

        private void timerPrint_Tick(object sender, EventArgs e)
        {
            //Random a = new Random();
            //int i = a.Next(1, 12);
            //OnDisplayPic(dicAnimals["龙"]);
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

        #endregion 

        #region 确认

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbWO.SelectedValue == null || dgvList.Rows.Count == 0)
            {
                DialogResult dr = DlgBox.Show("请选择制令单,且工单数不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //MessageBoxEx.Show("请选择制令单,且工单数不能为空.", "提示", MessageBoxButtons.OK);

                return;
            }
            if (client != null)
            {
                client.Close();
                client = null;
            }


            try
            {
                ShowMessage("开始连接Eqc Server ……");

                #region bind events

                client = new EasyClient<MesPackageInfo>()
                {
                    ReceiveBufferSize = 65535
                };
                client.Initialize(new MesReceiveFilter());
                client.Closed += Client_Closed; ;
                client.Connected += client_Connected;
                client.NewPackageReceived += Client_NewPackageReceived;
                client.Error += client_Error;
                var connected = await client.ConnectAsync(new IPEndPoint(IPAddress.Parse(GlobalData.EQCServerIP), Convert.ToInt32(GlobalData.EQCServerPort)));
                if (connected && client.IsConnected)
                {
                    this.BeginInvoke(new CbDelegate(() =>
                    {
                        cmbWO.Enabled = !cmbWO.Enabled;
                        btnOK.Enabled = !btnOK.Enabled;
                        btnCancel.Enabled = !btnCancel.Enabled;
                        txbBoxID.Focus();
                    }));
                }
                else
                {
                    ShowMessage("连接失败！");
                }
                #endregion

            }
            catch (Exception ex)
            {
                ShowMessage(string.Format("连接EQC服务器失败:{0}", ex.Message));
            }
        }

        private void Client_NewPackageReceived(object sender, PackageEventArgs<MesPackageInfo> e)
        {
            if (e.Package.TData != null)
            {
                switch (e.Package.Header)
                {
                    case "ISR":
                        if (e.Package.TData.CheckResult == CheckResultCode.OK.ToString())
                        {
                            ShowMessage("请开始扫描彩盒ID条码.");
                        }
                        else
                        {
                            ShowMessage("设备未具备开工条件.");
                            if (client != null)
                            {
                                client.Close();
                                client = null;
                            }

                        }
                        break;
                    case "SNC":
                        ShowSNCheckResult(e.Package.TData.CheckResult);
                        if (e.Package.TData.CheckResult == CheckResultCode.OK.ToString())
                        {
                            try
                            {
                                DataTable dt = SFCInterface.SFC_DM_CheckRoute(e.Package.TData.SN, GlobalData.EquipmentNO, e.Package.TData.WO, "PASS");//FAIL

                                string CheckStatus = dt.Rows[0][0].ToString().ToString();
                                string ReturnMsg = dt.Rows[0][1].ToString().ToString();
                                if (CheckStatus == "1") //成功  
                                {
                                    ShowMessage("MES过站成功>>" + CheckStatus + ":" + ReturnMsg);
                                    // 加载下一条
                                    GetNextSN(WO);
                                }
                                else
                                {
                                    ShowMessage("MES过站失败>>" + CheckStatus + ":" + ReturnMsg);
                                }
                            }
                            catch (Exception ex)
                            {
                                ShowMessage("执行过站方法出错>>" + ex.Message);
                            }
                        }
                        else
                        {
                            for (int i = 5; i > 0; i--)
                            {
                                ShowMessage("彩盒SN校验失败，【" + i.ToString() + "】秒后重新下发.");
                                Thread.Sleep(1000);
                            }
                            ShowMessage("条码已重新下发.");
                            SendFactory(FunCode.SND.ToString());
                        }
                        break;

                    default:
                        ShowMessage("未能识别该功能码：" + e.Package.Header);
                        break;
                }
            }
            else
            {
                ShowMessage("提示：协议格式错误，协议格式：3位功能码 + 空格 + json字符串 + 回车换行符.");
            }
        }

        private void Client_Closed(object sender, EventArgs e)
        {
            this.BeginInvoke(new CbDelegate(() =>
            {
                cmbWO.SelectedIndex = -1;
                cmbWO.Enabled = !cmbWO.Enabled;
                btnOK.Enabled = !btnOK.Enabled;
                btnCancel.Enabled = !btnCancel.Enabled;
                txbBoxID.Focus();
                Clear();
                OnDisplayPic(null);
                ShowMessage("与EQC服务器断开连接！");
            }));
        }

        private void client_Error(object sender, ErrorEventArgs e)
        {
            if (e.Exception.GetType() == typeof(System.Net.Sockets.SocketException))
            {
                var socketExceptin = e.Exception as System.Net.Sockets.SocketException;
                if (socketExceptin.SocketErrorCode == SocketError.ConnectionRefused)
                {
                    ShowMessage("错误:请先启动EQC服务端！");
                }
                else
                    ShowMessage("错误:" + e.Exception.Message);
            }
            else
                ShowMessage("错误:" + e.Exception.Message);
        }

        //连接成功
        private void client_Connected(object sender, EventArgs e)
        {
            ShowMessage("连接成功！");

            // 连接成功，发请求问设备是否具备开工条件
            SendFactory(FunCode.ISR.ToString());

        }

        #endregion

        #region 取消

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }

        }

        #endregion

        #region 选择制令单加载事件

        private void cmbWO_DropDownClosed(object sender, EventArgs e)
        {
            Clear();
            if (cmbWO.SelectedValue != null)
            {
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
            if (txbBoxID.Text.EndsWith("\r\n"))
            {
                bool b = GetBoxSpecCheck(cmbWO.SelectedText, txbBoxID.Text);
                if (b)
                {
                    SendFactory(FunCode.SND.ToString());
                }
            }
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
            if (client.IsConnected == true)
            {
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
                string strSend = funCode + GlobalData.SpacePoint + JsonHelper.Serialize(tData) + GlobalData.EndPoint;
                var data = Encoding.UTF8.GetBytes(strSend);
                client.Send(new ArraySegment<byte>(data, 0, data.Length));
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

    }


}
