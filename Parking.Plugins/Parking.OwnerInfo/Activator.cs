using UIShell.OSGi;
using Parking.Core.Record;
using Parking.Core.Enum;
using Parking.Core.DataProcessing;

namespace Parking.OwnerInfo
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            //todo:
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
        }

        #region ___注册消息总线事件___
        private void Instance_OnMessageBroadcast(ProcessRecord msg, bool isWaitOne)
        {
            ActiveMessage(msg, isWaitOne);
        }
        /// <summary>
        /// 响应广播消息
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <param name="isWaitOne"></param>
        private void ActiveMessage(ProcessRecord recordInfo, bool isWaitOne)
        {
            if (recordInfo.OPERATER_TYPE == enumOperaterType.QueryUserIfno) {
                new OwnerInfo().Show();
            }
        }
        #endregion

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
