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
using Parking.Core.Log4Net;
using Parking.Core.Enum;
using Parking.Core.Record;
using Parking.Core.Interface;
using Parking.Core.Infrastructure;
using log4net;
using System.IO;
using Parking.Controls;
using Parking.Core.Model;
using Parking.DBService.IBLL;

namespace Parking.CarInformation
{
    public partial class CarInformation : UserControl
    {
        Image yellow, blue, black;

        private FN_LAYOUT_SUBJECT _Plugin;
        public CarInformation(FN_LAYOUT_SUBJECT pluginInfo)
        {
            InitializeComponent();
            _Plugin = pluginInfo;
            ////////////////////////////////////////////////注册消息总线事件///////////////////////////////////////////
            ThreadMessageTransact.Instance.OnMessageBroadcast += new ThreadMessageTransact.OnMessageBroadcastEventHandler(Instance_OnMessageBroadcast);
        }
        #region ___注册消息总线事件___
        private void Instance_OnMessageBroadcast(ProcessRecord msg, bool isWaitOne)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { ActiveMessage(msg, isWaitOne); }));
                return;
            }
            ActiveMessage(msg, isWaitOne);
        }
        /// <summary>
        /// 响应广播消息
        /// </summary>
        /// <param name="recordInfo"></param>
        /// <param name="isWaitOne"></param>
        private void ActiveMessage(ProcessRecord recordInfo, bool isWaitOne)
        {
            if (recordInfo.OPERATER_TYPE == enumOperaterType.SwitchdataGrid)
            {
                if (!string.IsNullOrEmpty(recordInfo.PicFullName))
                {
                    this.lblCarNum.Text = recordInfo.VEHICLE_NO;
                    this.picCarImg.Image = new Bitmap(GlobalEnvironment.BasePath + recordInfo.PicFullName);
                }
            }
        }
        #endregion
        private void CarInformation_Load(object sender, EventArgs e)
        {
            try
            {
                ThreadMessageTransact.Instance.OnPlate += new Action<ProcessRecord>(Instance_OnPlate);
                lblCarNum.AutoSize = false;
                lblCarNum.Height = (int)(((Double)this.Height / (Double)100) * 20);
                this.lblCarNum.Width = this.Width;
                this.lblCarNum.Top = 0;
                this.lblCarNum.Left = 0;
                if (File.Exists(GlobalEnvironment.BasePath + @"Image\Yellow.jpg"))
                    yellow = GetThumbnail(GlobalEnvironment.BasePath + @"Image\Yellow.jpg", this.lblCarNum.Width, lblCarNum.Height);
                if (File.Exists(GlobalEnvironment.BasePath + @"Image\Blue.jpg"))
                    blue = GetThumbnail(GlobalEnvironment.BasePath + @"Image\Blue.jpg", this.lblCarNum.Width, lblCarNum.Height);
                if (File.Exists(GlobalEnvironment.BasePath + @"Image\Black.jpg"))
                    black = GetThumbnail(GlobalEnvironment.BasePath + @"Image\Black.jpg", this.lblCarNum.Width, lblCarNum.Height);
                this.lblCarNum.Image = blue;
                FontFamily ff = new FontFamily(lblCarNum.Font.Name);
                lblCarNum.Font = new Font(ff, 100, lblCarNum.Font.Style, GraphicsUnit.World);
                getFontSize(lblCarNum, "粤B88888");
                this.picCarImg.Top = this.lblCarNum.Height + 62;
                this.picCarImg.Left = 0;
                this.picCarImg.Width = this.Width;
                System.Drawing.Image img = GetThumbnail(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Image\Carpic.png", this.picCarImg.Width, picCarImg.Height);
                this.picCarImg.Image = img;
                lblType.Left = 10;
                lblType.Top = (int)(((Double)lblType.Height / (Double)100) * 20);
                lblType.Left = lblType.Width + 12;
                lblType.Top = (int)(((Double)lblType.Height / (Double)100) * 20);
                getFontSize(lblType, lblType.Text);
                getFontSize(lblType, lblType.Text);
            }
            catch (Exception ex)
            { LogHelper.Log.Error(ex.Message); }
        }
        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="serverImagePath">图片地址</param>
        /// <param name="thumbnailImagePath">缩略图地址</param>
        /// <param name="width">图片宽度</param>
        /// <param name="height">图片高度</param>
        /// <param name="p"></param>
        public static Image GetThumbnail(string serverImagePath, int width, int height)
        {
            System.Drawing.Image serverImage = System.Drawing.Image.FromFile(serverImagePath);
            //画板大小
            int towidth = width;
            int toheight = height;
            //缩略图矩形框的像素点
            int ow = serverImage.Width;
            int oh = serverImage.Height;
            //新建一个bmp图片
            System.Drawing.Image bm = new System.Drawing.Bitmap(width, height);
            //新建一个画板
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bm);
            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充
            g.Clear(System.Drawing.Color.White);
            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(serverImage, new System.Drawing.Rectangle((width - towidth) / 2, (height - toheight) / 2, towidth, toheight),
                0, 0, ow, oh,
                System.Drawing.GraphicsUnit.Pixel);
            return bm;

        }
        /// <summary>
        /// lable字体自适应大小
        /// </summary>
        /// <param name="content"></param>
        private void getFontSize(Label lbl, string content)
        {
            FontFamily ff = new FontFamily(lbl.Font.Name);
            lbl.Font = new Font(ff, lbl.Font.Size, lbl.Font.Style, GraphicsUnit.World);
            float size = this.lblCarNum.Font.Size;
            while (content.Length * size > lbl.Width)
            {
                size -= 0.5F;
            }
            while (size > lbl.Height)
            {
                size -= 0.5F;
            }
            lbl.Font = new Font(ff, size, lbl.Font.Style, GraphicsUnit.World);
            lbl.Text = content;
        }
        /// <summary>
        /// 事件响应
        /// </summary>
        /// <param name="data"></param>
        public void Instance_OnPlate(ProcessRecord data)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { ShowPictureInfo(data); }));
                return;
            }
            ShowPictureInfo(data);
        }
        /// <summary>
        /// 显示最新车辆信息
        /// </summary>
        /// <param name="data"></param>
        public void ShowPictureInfo(ProcessRecord data)
        {
            try
            {
                lblType.Text = data.CARD_TYPE == enumCardType.CAR_TYPE_TEMP ? "临时车" : data.CARD_TYPE == enumCardType.CAR_TYPE_MONTH ? "月卡车" : "固定车";
                picCarImg.Image = GetThumbnail(data.PicFullName, this.picCarImg.Width, picCarImg.Height);
                lblCarNum.Text = data.INOUT_RECODE.VEHICLE_NO;
            }
            catch (Exception ex)
            {
                LogHelper.Log.Error(ex.Message);
            }
        }
    }
}