using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parking.Core;
using Parking.Core.DataProcessing;
using Parking.Core.Record;
using Parking.Core.Oragnization;
using Parking.Core.Common;
using Parking.Core.Enum;
using Parking.Core.Log4Net;
using Parking.Controls;
using System.Threading;
using System.Drawing.Drawing2D;

namespace Parking.RecognitionStatistics
{
    public partial class RecognitionStatistics : UserControl
    {
        #region ___类内变量___
        /// <summary>
        ///  坐标轴左边距
        /// </summary>
        private int Chart_LEFT = 20;
        /// <summary>
        /// 坐标轴上边距
        /// </summary>
        private int Chart_TOP = 20;
        /// <summary>
        /// 画布高度
        /// </summary>
        int Chart_HEIGHT = 0;
        /// <summary>
        /// 画布宽度
        /// </summary>
        int Chart_WIDTH = 1030;
        /// <summary>
        /// 字体比例尺
        /// </summary>
        private float fontScale = 0;
        /// <summary>
        /// 坐标轴颜色
        /// </summary>
        Color HistogramColor = Color.Gray;
        /// <summary>
        /// 静态锁
        /// </summary>
        private static object _lock = new object();
        /// <summary>
        /// 随机函数
        /// </summary>
        Random r = new Random();
        /// <summary>
        /// 采点数据
        /// </summary>
        List<Point> lCameras = new List<Point>();
        /// <summary>
        /// 线条颜色
        /// </summary>
        Color lColor = Color.Green;
        bool IsPostBack = true;
        String[] n = { "", "100", "80", "60", "40", "20" };
        #endregion

        #region ___构造函数___
        public RecognitionStatistics()
        {
            InitializeComponent();
        }
        #endregion

        #region ___页面加载___
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecognitionStatistics_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);

            var Cameras = GlobalEnvironment.CurrWorkStationOragnization.Where(x => x.productLine == enumProductLine.IdentificationCamera).ToList();
            this.cbCamera.DataSource = Cameras;
            cbCamera.ValueMember = "ORGANIZATION_CODE";
            cbCamera.DisplayMember = "ORGANIZATION_NAME";
            IsPostBack = false;
            Chart_HEIGHT = this.picScale.Height - 30;
        }
        #endregion

        #region ___注册消息总线事件___
        private void Instance_OnMessageBroadcast(ProcessRecord msg, bool isWaitOne)
        {
            if (msg.OPERATER_TYPE == enumOperaterType.RecognitionEvent)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { AddLastPoint(msg.IP); }));
                    return;
                }
                AddLastPoint(msg.IP);
            }
        }
        /// <summary>
        /// 采样一个数据，并放入最后位置
        /// </summary>
        private void AddLastPoint(string Ip)
        {
            if (lCameras.Count > 0)
            {
                var equDevice = InitCamerasInfo();
                if (null != equDevice && equDevice.IP == Ip)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        int x = lCameras[i].X;
                        int y = lCameras[i].Y;
                        lCameras[i] = new Point(x - 20, y);
                    }
                    lCameras.RemoveAt(0);
                    int Number = equDevice.ErrorCount;
                    if (equDevice.ListRecognitioResult.Count > 0)
                    {
                        int Count = 0;
                        int Max = 0;
                        foreach (var temp in equDevice.ListRecognitioResult)
                        {
                            Count += temp.Count;
                            Max = Max > temp.Count ? Max : temp.Count;
                        }
                        double RecognitionRate = Convert.ToDouble(Convert.ToDouble(Max) / Convert.ToDouble(Count));
                        this.lbRecognitionRate.Text = (RecognitionRate * 100).ToString("#0.000") + "% (" + Max + "-" + Count + ")";
                        Number = Convert.ToInt32((1 - RecognitionRate) * Chart_HEIGHT);
                    }
                    lCameras.Add(new Point(1000, Chart_TOP + (Chart_HEIGHT / n.Length) + Number));
                    DrawingCoordinate();
                }
            }
        }
        #endregion

        #region ___后台画图线程___
        /// <summary>
        /// 画坐标图
        /// </summary>
        public void DrawingCoordinate()
        {
            if (lCameras.Count > 0)
            {
                Graphics g5 = this.picScale.CreateGraphics();
                g5.SmoothingMode = SmoothingMode.AntiAlias;
                g5.Clear(Color.White);
                PointF barOrigin = new PointF(Chart_LEFT, 0);
                #region ___画坐标轴__
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle((int)barOrigin.X, (int)barOrigin.Y, Chart_WIDTH, Chart_HEIGHT), HistogramColor, HistogramColor, 1.2F, true);
                //画坐标x轴
                g5.DrawLine(new Pen(HistogramColor, 2), new Point(Chart_LEFT - 1, Chart_TOP + Chart_HEIGHT), new Point(Chart_LEFT + Chart_WIDTH, Chart_TOP + Chart_HEIGHT));
                //画X箭头
                g5.DrawLine(new Pen(HistogramColor, 2), new Point(Chart_LEFT + Chart_WIDTH, Chart_TOP + Chart_HEIGHT), new Point(Chart_LEFT + Chart_WIDTH - 5, Chart_TOP + Chart_HEIGHT - 5));
                g5.DrawLine(new Pen(HistogramColor, 2), new Point(Chart_LEFT + Chart_WIDTH, Chart_TOP + Chart_HEIGHT), new Point(Chart_LEFT + Chart_WIDTH - 5, Chart_TOP + Chart_HEIGHT + 5));
                //画坐标y轴
                g5.DrawLine(new Pen(HistogramColor, 2), new Point(Chart_LEFT, Chart_TOP), new Point(Chart_LEFT, Chart_TOP + Chart_HEIGHT));
                //画Y箭头
                g5.DrawLine(new Pen(HistogramColor, 2), new Point(Chart_LEFT, Chart_TOP), new Point(Chart_LEFT - 5, Chart_TOP + 5));
                g5.DrawLine(new Pen(HistogramColor, 2), new Point(Chart_LEFT, Chart_TOP), new Point(Chart_LEFT + 5, Chart_TOP + 5));

                //画刻度
                String[] n = { "", "100", "80", "60", "40", "20" };
                int y = Chart_TOP;
                for (int i = 0; i < n.Length; i++)
                {
                    g5.DrawString(n[i].ToString(), new Font("微软雅黑", 7 + fontScale), brush, Convert.ToInt32(Chart_LEFT - 20), y - 5);
                    if (n[i] != string.Empty)
                        g5.DrawLine(new Pen(HistogramColor, 2), new Point(Chart_LEFT, y), new Point(Chart_LEFT + 5, y));
                    y = y + Chart_HEIGHT / (n.Length);
                }
                #endregion
                DrawCurves(g5);
                g5.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="grp"></param>
        private void DrawCurves(Graphics grp)
        {
            Point[] temps = new Point[lCameras.Count];
            lock (_lock)
            {
                for (int i = 0; i < lCameras.Count; i++)
                {
                    temps[i] = lCameras[i];
                }
            }
            grp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            grp.DrawCurve(new Pen(lColor, 2), temps);
        }

        #endregion

        #region ___选择相机___
        /// <summary>
        /// 选择相机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPostBack)
                InitData();
        }
        /// <summary>
        /// 采样
        /// </summary>
        private void InitData()
        {
            lock (_lock)
            {
                lCameras.Clear();
                var equDevice = InitCamerasInfo();
                if (null != equDevice)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        Point p = new Point(i * 20 + 20, Chart_TOP + (Chart_HEIGHT / n.Length));
                        lCameras.Add(p);
                    }
                    DrawingCoordinate();
                }
            }
        }
        /// <summary>
        /// 加载相机信息
        /// </summary>
        /// <returns></returns>
        private Equipment InitCamerasInfo()
        {
            this.lbErrorCarNo.Text = string.Empty;
            this.lbCurrCarNo.Text = string.Empty;
            string OrgCode = this.cbCamera.SelectedValue.ToString();
            var equDevice = GlobalEnvironment.ListOragnization.Where(x => x.ORGANIZATION_CODE == OrgCode).FirstOrDefault();
            if (null != equDevice)
            {
                if (null != equDevice.CurrRecognitioData)
                {
                    this.lbCurrCarNo.Text = equDevice.CurrRecognitioData.CarNo + " (" + equDevice.CurrRecognitioData.Count + ")";
                    if (equDevice.ListRecognitioResult.Count > 1)
                    {
                        var ErrorCamera = equDevice.ListRecognitioResult.Where(x => x.CarNo != equDevice.CurrRecognitioData.CarNo).OrderByDescending(x => x.Count).FirstOrDefault();
                        this.lbErrorCarNo.Text = ErrorCamera.CarNo + " (" + ErrorCamera.Count + ")";
                    }
                }
                this.lbIP.Text = equDevice.IP;
                var channel = CommHelper.GetOrgInfos(equDevice.ORGANIZATION_CODE, false).Where(x => x.channelType == enumChannelType.chn_in || x.channelType == enumChannelType.chn_out).LastOrDefault();
                if (null != channel)
                    this.lbChannelName.Text = channel.ORGANIZATION_NAME;
            }
            return equDevice;
        }
        /// <summary>
        /// 重绘界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picScale_Paint(object sender, PaintEventArgs e)
        {
            DrawingCoordinate();
        }
        #endregion
    }
}