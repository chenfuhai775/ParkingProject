namespace Parking.RecognitionStatistics
{
    partial class RecognitionStatistics
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picScale = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRecognitionRate = new System.Windows.Forms.Label();
            this.lbErrorCarNo = new System.Windows.Forms.Label();
            this.lbCurrCarNo = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbChannelName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picScale)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picScale
            // 
            this.picScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScale.Location = new System.Drawing.Point(3, 3);
            this.picScale.Name = "picScale";
            this.picScale.Size = new System.Drawing.Size(446, 309);
            this.picScale.TabIndex = 0;
            this.picScale.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.picScale, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 315);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbRecognitionRate);
            this.panel1.Controls.Add(this.lbErrorCarNo);
            this.panel1.Controls.Add(this.lbCurrCarNo);
            this.panel1.Controls.Add(this.lbIP);
            this.panel1.Controls.Add(this.lbChannelName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbCamera);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(455, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 309);
            this.panel1.TabIndex = 1;
            // 
            // lbRecognitionRate
            // 
            this.lbRecognitionRate.AutoSize = true;
            this.lbRecognitionRate.Location = new System.Drawing.Point(91, 212);
            this.lbRecognitionRate.Name = "lbRecognitionRate";
            this.lbRecognitionRate.Size = new System.Drawing.Size(11, 12);
            this.lbRecognitionRate.TabIndex = 11;
            this.lbRecognitionRate.Text = "0";
            // 
            // lbErrorCarNo
            // 
            this.lbErrorCarNo.AutoSize = true;
            this.lbErrorCarNo.Location = new System.Drawing.Point(91, 170);
            this.lbErrorCarNo.Name = "lbErrorCarNo";
            this.lbErrorCarNo.Size = new System.Drawing.Size(35, 12);
            this.lbErrorCarNo.TabIndex = 10;
            this.lbErrorCarNo.Text = "- - -";
            // 
            // lbCurrCarNo
            // 
            this.lbCurrCarNo.AutoSize = true;
            this.lbCurrCarNo.Location = new System.Drawing.Point(91, 132);
            this.lbCurrCarNo.Name = "lbCurrCarNo";
            this.lbCurrCarNo.Size = new System.Drawing.Size(35, 12);
            this.lbCurrCarNo.TabIndex = 9;
            this.lbCurrCarNo.Text = "- - -";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(91, 94);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(35, 12);
            this.lbIP.TabIndex = 8;
            this.lbIP.Text = "- - -";
            // 
            // lbChannelName
            // 
            this.lbChannelName.AutoSize = true;
            this.lbChannelName.Location = new System.Drawing.Point(91, 55);
            this.lbChannelName.Name = "lbChannelName";
            this.lbChannelName.Size = new System.Drawing.Size(35, 12);
            this.lbChannelName.TabIndex = 7;
            this.lbChannelName.Text = "- - -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "识别率：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "错误车牌：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "当前车牌：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "设备地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "通道名称：";
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(75, 11);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(100, 20);
            this.cbCamera.TabIndex = 1;
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择相机：";
            // 
            // RecognitionStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecognitionStatistics";
            this.Size = new System.Drawing.Size(652, 315);
            this.Load += new System.EventHandler(this.RecognitionStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScale)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picScale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbChannelName;
        private System.Windows.Forms.Label lbRecognitionRate;
        private System.Windows.Forms.Label lbErrorCarNo;
        private System.Windows.Forms.Label lbCurrCarNo;
        private System.Windows.Forms.Label lbIP;
    }
}
