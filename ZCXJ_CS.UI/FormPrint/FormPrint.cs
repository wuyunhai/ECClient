using DM_API;
//using SuperSocket.ClientEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Reflection;
using ZCXJ_CS.Applications;
using ZCXJ_CS.Utilities;

namespace ZCXJ_CS.UI
{
    public partial class FormPrint : FormBase
    {
        #region var

       // private AsyncTcpSession client;

        private Dictionary<int, string> dicAnimals; 
        public LogHelper log;

        /// <summary>
        /// 可执行文件路径        
        ///</summary> 
        public string ExePath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory; }
        }

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


        }

        private void LoadAnimal()
        {
            dicAnimals = new Dictionary<int, string>();
            dicAnimals.Add(1, SelfPath + "shu.jpg");
            dicAnimals.Add(2, SelfPath + "niu.jpg");
            dicAnimals.Add(3, SelfPath + "hu.jpg");
            dicAnimals.Add(4, SelfPath + "tu.jpg");
            dicAnimals.Add(5, SelfPath + "long.jpg");
            dicAnimals.Add(6, SelfPath + "she.jpg");
            dicAnimals.Add(7, SelfPath + "ma.jpg");
            dicAnimals.Add(8, SelfPath + "yang.jpg");
            dicAnimals.Add(9, SelfPath + "hou.jpg");
            dicAnimals.Add(10, SelfPath + "ji.jpg");
            dicAnimals.Add(11, SelfPath + "gou.jpg");
            dicAnimals.Add(12, SelfPath + "zhu.jpg");
        }

        private void timerPrint_Tick(object sender, EventArgs e)
        {
            //Random a = new Random();
            //int i = a.Next(1, 12);
            //OnDisplayPic(dicAnimals[i]);
        }
        #endregion

        #region 图片显示

        private void OnDisplayPic(string path)
        {
            Invoke(new Action<string>((fullPath) =>
            {
                picBox.Image = Image.FromFile(path);
            }), path);
        }

        #endregion

        #region 日志显示

        private void OnDisplayLog(string msg)
        {
            Invoke(new Action<string>((message) =>
            {
                lblInfo.Text = msg;
            }), msg);
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="flag">0-清空；1-绿色；2-红色</param>
        /// <param name="type">0-图示；1-MesSN；2-PlcSN</param>
        private void OnDisplayMesSn(string msg, int flag, int type)
        {
            Invoke(new Action<string, int, int>((_msg, _flag, _type) =>
              {
                  switch (_type)
                  {
                      case 0://picBoxV

                          switch (_flag)
                          {
                              case 0:

                                  break;
                              case 1:

                                  break;
                              case 2:

                                  break;

                              default:
                                  break;
                          }
                          break;
                      case 1:
                          switch (_flag)
                          {
                              case 0:


                                  break;
                              case 1:

                                  break;
                              case 2:

                                  break;

                              default:
                                  break;
                          }
                          break;
                      case 2:
                          switch (_flag)
                          {
                              case 0:

                                  break;
                              case 1:


                                  break;
                              case 2:


                                  break;

                              default:
                                  break;
                          }
                          break;
                  }

              }), msg, flag, type);
        }

        #region 确认

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (client != null)
            //{
            //    client.Close();
            //    client = null;
            //}
            btnOK.Enabled = false;
            btnCancel.Enabled = true;
            try
            {
                //client = new AsyncTcpSession(new IPEndPoint(IPAddress.Parse(GlobalData.EQCServerIP), Convert.ToInt32(GlobalData.EQCServerPort)), 1024000);

                //#region bind events
                //client.Closed += Client_Closed; ;
                //client.Connected += client_Connected;
                //client.DataReceived += client_DataReceived;
                //client.Error += client_Error;
                //#endregion

                //client.Connect();
            }
            catch (Exception ex)
            {
                //AppendMessage("Connect failed", Environment.NewLine, ex.Message);
            }
        }

        //private void Client_Closed(object sender, EventArgs e)
        //{
        //    OnDisplayLog("客户端主动关闭连接！");
        //}

        //private void client_Error(object sender, ErrorEventArgs e)
        //{
        //    OnDisplayLog(e.Exception.Message);
        //}

        //private void client_DataReceived(object sender, DataEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void client_Connected(object sender, EventArgs e)
        //{
        //    OnDisplayLog("连接成功！");
        //}
         

        #endregion

        #region 取消

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
