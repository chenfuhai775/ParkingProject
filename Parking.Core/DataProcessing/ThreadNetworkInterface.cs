using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using Parking.Core.Log4Net;
using Parking.Core.Interface;

namespace Parking.Core.DataProcessing
{
    public class ThreadNetworkInterface
    {
        private static object _objLock = new object();
        private AutoResetEvent AcceptDataEvent = new AutoResetEvent(false);
        private Queue<IDataUpLoad> queueDataUpLoad = new Queue<IDataUpLoad>();
        Thread threadAcceptDataWork = null;

        #region __启?动?￥线?程¨?__
        /// <summary>
        /// 启?动?￥数oy据Y监¨¤控?线?程¨?
        /// </summary>
        public void Start()
        {
            ThreadHelper.StartBgThread(ref threadAcceptDataWork, new ParameterizedThreadStart(AcceptUpLoadDataWork), null, true);
        }
        #endregion

        /// <summary>
        /// 往a¨′入¨?场?记?录?队¨?列￠D中D添?¨a加¨?数oy据Y
        /// </summary>
        /// <param name="record"></param>
        public void AcceptUpLoadData(IDataUpLoad data)
        {
            lock (_objLock)
            {
                queueDataUpLoad.Enqueue(data);
                AcceptDataEvent.Set();
            }
        }
        /// <summary>
        ///  处?|理¤¨a出?场?队¨?列￠D中D的ì?数oy据Y
        /// </summary>
        private void AcceptUpLoadDataWork(object state)
        {
            while (true)
            {
                try
                {
                    AcceptDataEvent.WaitOne();
                    IDataUpLoad iDataUpLoad = null;
                    while (queueDataUpLoad.Count > 0)
                    {
                        lock (_objLock)
                        {
                            if (queueDataUpLoad.Count > 0)
                            {
                                iDataUpLoad = queueDataUpLoad.First();
                            }
                        }
                        if (null != iDataUpLoad)
                        {
                            var result = iDataUpLoad.DataPush();
                            if (result)
                                queueDataUpLoad.Dequeue();
                        }
                    }
                    AcceptDataEvent.Reset();
                }
                catch (Exception ex)
                {
                    LogHelper.Log.Error("上|?传??数oy据Y错?¨a误¨?：êo" + ex.Message);
                }
                finally
                {
                    AcceptDataEvent.Reset();
                }
            }
        }

        #region __单ì￡¤列￠D对?象¨?__
        private static ThreadNetworkInterface _instance;
        public static ThreadNetworkInterface Instance
        {
            get
            {
                if (null == _instance)
                    _instance = new ThreadNetworkInterface();
                return _instance;
            }
        }
        #endregion
    }
}