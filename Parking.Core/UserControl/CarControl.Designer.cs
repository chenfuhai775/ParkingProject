namespace CarInfoControl
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCarNo = new System.Windows.Forms.Label();
            this.lblEntryTime = new System.Windows.Forms.Label();
            this.lblExitTime = new System.Windows.Forms.Label();
            this.lblEntryStation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(24, 31);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 50);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "车牌号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "进场时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "出场时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "入口岗亭：";
            // 
            // lblCarNo
            // 
            this.lblCarNo.AutoSize = true;
            this.lblCarNo.Location = new System.Drawing.Point(104, 199);
            this.lblCarNo.Name = "lblCarNo";
            this.lblCarNo.Size = new System.Drawing.Size(35, 12);
            this.lblCarNo.TabIndex = 5;
            this.lblCarNo.Text = "- - -";
            // 
            // lblEntryTime
            // 
            this.lblEntryTime.AutoSize = true;
            this.lblEntryTime.Location = new System.Drawing.Point(104, 231);
            this.lblEntryTime.Name = "lblEntryTime";
            this.lblEntryTime.Size = new System.Drawing.Size(35, 12);
            this.lblEntryTime.TabIndex = 6;
            this.lblEntryTime.Text = "- - -";
            // 
            // lblExitTime
            // 
            this.lblExitTime.AutoSize = true;
            this.lblExitTime.Location = new System.Drawing.Point(104, 267);
            this.lblExitTime.Name = "lblExitTime";
            this.lblExitTime.Size = new System.Drawing.Size(35, 12);
            this.lblExitTime.TabIndex = 7;
            this.lblExitTime.Text = "- - -";
            // 
            // lblEntryStation
            // 
            this.lblEntryStation.AutoSize = true;
            this.lblEntryStation.Location = new System.Drawing.Point(273, 199);
            this.lblEntryStation.Name = "lblEntryStation";
            this.lblEntryStation.Size = new System.Drawing.Size(35, 12);
            this.lblEntryStation.TabIndex = 8;
            this.lblEntryStation.Text = "- - -";
            // 
            // CarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEntryStation);
            this.Controls.Add(this.lblExitTime);
            this.Controls.Add(this.lblEntryTime);
            this.Controls.Add(this.lblCarNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Name = "CarControl";
            this.Size = new System.Drawing.Size(359, 323);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCarNo;
        private System.Windows.Forms.Label lblEntryTime;
        private System.Windows.Forms.Label lblExitTime;
        private System.Windows.Forms.Label lblEntryStation;
    }
}
