using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;

namespace EsayCare.MES
{
    public class MesServer : AppServer<MesSession>
    {
        protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
        {
            return base.Setup(rootConfig, config);
        }

        protected override void OnStarted()
        {
            base.OnStarted(); 
            Logger.Info("Mes Server 启动");
        }

        protected override void OnStopped()
        {
            base.OnStopped();
            Logger.Info("Mes Server 停止");
        }

        /// <summary>
        /// 新的连接
        /// </summary>
        /// <param name="session"></param>
        protected override void OnNewSessionConnected(MesSession session)
        {
            base.OnNewSessionConnected(session);

            Logger.Info("加入新的连接:" + session.RemoteEndPoint.ToString());
            
        }

    }
}
