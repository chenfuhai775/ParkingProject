namespace Parking.ControlPanel
{
    partial class CarControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_CarNo = new System.Windows.Forms.Label();
            this.picIn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ChannelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_InTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_CarNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picIn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 208);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_CarNo
            // 
            this.lb_CarNo.AutoSize = true;
            this.lb_CarNo.Location = new System.Drawing.Point(3, 0);
            this.lb_CarNo.Name = "lb_CarNo";
            this.lb_CarNo.Size = new System.Drawing.Size(53, 12);
            this.lb_CarNo.TabIndex = 0;
            this.lb_CarNo.Text = "lb_CarNo";
            // 
            // picIn
            // 
            this.picIn.Location = new System.Drawing.Point(3, 73);
            this.picIn.Name = "picIn";
            this.picIn.Size = new System.Drawing.Size(100, 50);
            this.picIn.TabIndex = 1;
            this.picIn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "入口通道：";
            // 
            // lb_ChannelName
            // 
            this.lb_ChannelName.AutoSize = true;
            this.lb_ChannelName.Location = new System.Drawing.Point(89, 13);
            this.lb_ChannelName.Name = "lb_ChannelName";
            this.lb_ChannelName.Size = new System.Drawing.Size(41, 12);
            this.lb_ChannelName.TabIndex = 1;
            this.lb_ChannelName.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_InTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_ChannelName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 62);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "入场时间：";
            // 
            // lb_InTime
            // 
            this.lb_InTime.AutoSize = true;
            this.lb_InTime.Location = new System.Drawing.Point(91, 38);
            this.lb_InTime.Name = "lb_InTime";
            this.lb_InTime.Size = new System.Drawing.Size(59, 12);
            this.lb_InTime.TabIndex = 4;
            this.lb_InTime.Text = "lb_InTime";
            // 
            // CarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CarControl";
            this.Size = new System.Drawing.Size(325, 307);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_CarNo;
        private System.Windows.Forms.PictureBox picIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_ChannelName;
        private System.Windows.Forms.Label lb_InTime;
        private System.Windows.Forms.Label label2;
    }
}
