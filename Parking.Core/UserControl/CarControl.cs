using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CarInfoControl
{
    public partial class CarControl : UserControl
    {
        /// <summary>
        ///  入场时间
        /// </summary>
        public DateTime EntryTime { get; set; }
        /// <summary>
        ///  出场时间
        /// </summary>
        public DateTime ExitTime { get; set; }
        /// <summary>
        ///  入场岗亭名称
        /// </summary>
        public string EntryStationName { get; set; }
        /// <summary>
        ///  图片路径
        /// </summary>
        public string PicturePath { get; set; }
        /// <summary>
        ///  卡类型
        /// </summary>
        public string CardType { get; set; }
        /// <summary>
        ///  车牌号
        /// </summary>
        public string CarNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CarControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarControl_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    this.lblCarNo.Text = carInfo.CarNo.ToString();
            //    this.lblEntryTime.Text = carInfo.EntryTime.ToString("yyyy-MM-dd HH:mm:ss");
            //    if (!string.IsNullOrEmpty(carInfo.ExitTime.ToString()))
            //    {
            //        this.lblExitTime.Text = carInfo.ExitTime.ToString();
            //    }
            //    else
            //    {
            //        this.lblExitTime.Text = string.Empty;
            //    }

            //    this.lblEntryStation.Text = carInfo.EntryStationName;

            //    this.picBox.BackgroundImageLayout = ImageLayout.Stretch;


            //    this.picBox.Image = Image.FromFile(carInfo.PicturePath);

            //    this.picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }
        public void CarControl_EventCarInfo()
        {
            //carInfo = carModel;
        }
    }
}