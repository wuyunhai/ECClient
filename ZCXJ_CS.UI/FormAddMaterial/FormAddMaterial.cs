using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZCXJ_CS.UI;

namespace ZCXJ_CS.UI
{
    public partial class FormAddMaterial : FormBase
    {
        AppServer appServer; 
        public delegate void ChangeTxbInfoDelegate(string message);
        ChangeTxbInfoDelegate changeTxbInfoDelegate;
        public string SessionID { get; set; }
 

        public FormAddMaterial()
        {
            InitializeComponent();

             
        }

        private void FormAddMaterial_Load(object sender, EventArgs e)
        {
            appServer = new AppServer();
            if (!appServer.Setup(6542))
            {
                txbInfo.Text = "服务器创建失败！";
            }
            if (appServer.Start())
            {
                txbInfo.Text = "就绪";
            }
            else
            {
                txbInfo.Text = "服务器启动失败!";
            }
            appServer.NewSessionConnected += AppServer_NewSessionConnected;
            appServer.NewRequestReceived += AppServer_NewRequestReceived;
            appServer.SessionClosed += AppServer_SessionClosed;
        }


        private void AppServer_NewSessionConnected(AppSession session)
        {
            this.Invoke(changeTxbInfoDelegate, "连接成功");
        }

        private void AppServer_SessionClosed(AppSession session, SuperSocket.SocketBase.CloseReason value)
        {
            this.Invoke(changeTxbInfoDelegate, value);
        }

        private void AppServer_NewRequestReceived(AppSession session, SuperSocket.SocketBase.Protocol.StringRequestInfo requestInfo)
        {
            switch (requestInfo.Key.ToUpper())
            {
                case "SNC":
                    SessionID = session.SessionID;
 
                    byte[] buffer = Encoding.UTF8.GetBytes("SNC {\"WO\":null,\"EquipmentID\":\"L01.OP040\",\"SN\":\"DS201568974\",\"PartCode\":null,\"CheckResult\":\"OK\",\"Description\":null,\"TestItems\":\"{ \"lightRack\": \"1_2_3\"}\"}\r\n");
                    session.Send(buffer, 0, buffer.Length);
                    this.Invoke(new Action(() => { txbScan.Focus(); }));
                    break;
                default:
                    this.Invoke(new Action(() => { txbInfo.Text = "数据错误"; }));
                    break;
            }
        }

        public void ChangeTxbInfo(string message)
        {
            txbInfo.Text = message;
        }

        private void txbScan_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public bool CheckCommon(string ID)
        {
            return true;
        }
       

    }
}
