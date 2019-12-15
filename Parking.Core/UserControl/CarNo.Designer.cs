namespace Parking.Controls
{
    partial class CarNo
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
            this.tbCarNo = new System.Windows.Forms.TextBox();
            this.picChangePro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChangePro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCarNo
            // 
            this.tbCarNo.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCarNo.Location = new System.Drawing.Point(0, 0);
            this.tbCarNo.Name = "tbCarNo";
            this.tbCarNo.Size = new System.Drawing.Size(175, 31);
            this.tbCarNo.TabIndex = 1;
            // 
            // picChangePro
            // 
            this.picChangePro.BackColor = System.Drawing.Color.White;
            this.picChangePro.Location = new System.Drawing.Point(175, 0);
            this.picChangePro.Name = "picChangePro";
            this.picChangePro.Size = new System.Drawing.Size(15, 30);
            this.picChangePro.TabIndex = 2;
            this.picChangePro.TabStop = false;
            this.picChangePro.Click += new System.EventHandler(this.picChangePro_Click);
            // 
            // CarNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picChangePro);
            this.Controls.Add(this.tbCarNo);
            this.Name = "CarNo";
            this.Size = new System.Drawing.Size(190, 30);
            this.Load += new System.EventHandler(this.CarNo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.picChangePro_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picChangePro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCarNo;
        private System.Windows.Forms.PictureBox picChangePro;
    }
}
