using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Parking.Core.DataProcessing
{
    public static class ThreadHelper
    {
        /// <summary>
        /// 启动一个线程。不适用于挂起的线程。
        /// </summary>
        /// <param name="t">线程</param>
        /// <param name="pts">要启动的线程的函数对象的委托</param>
        /// <param name="state">要传入线程的参数</param>
        /// <param name="killAlive">如果线程已经运行，是否先关闭之</param>
        public static void StartBgThread(ref Thread t, ParameterizedThreadStart pts, object state, bool killAlive)
        {
            if (t != null)
            {
                if (t.IsAlive)
                {
                    if (killAlive)
                    {
                        t.Interrupt();
                        t.Abort();
                        t.Join();
                    }
                    else
                        return;
                }
                if (t.ThreadState.ToString().Contains(ThreadState.Stopped.ToString())
                    || t.ThreadState.ToString().Contains(ThreadState.Aborted.ToString())
                    || t.ThreadState.ToString().Contains(ThreadState.AbortRequested.ToString()))
                {
                    t = new Thread(pts);
                }
            }
            else
            {
                t = new Thread(pts);
            }
            t.IsBackground = true;
            t.Start(state);
        }

    }
}
