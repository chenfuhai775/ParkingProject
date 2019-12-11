namespace Parking.BasePanel
{
    partial class BaseControl
    {

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.pLine = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Green;
            this.lbTitle.Location = new System.Drawing.Point(82, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(75, 19);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // picCar
            // 
            this.picCar.Location = new System.Drawing.Point(29, 3);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(34, 30);
            this.picCar.TabIndex = 1;
            this.picCar.TabStop = false;
            // 
            // pLine
            // 
            this.pLine.BackColor = System.Drawing.SystemColors.Control;
            this.pLine.Font = new System.Drawing.Font("宋体", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pLine.Location = new System.Drawing.Point(29, 43);
            this.pLine.Name = "pLine";
            this.pLine.Size = new System.Drawing.Size(200, 1);
            this.pLine.TabIndex = 2;
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pLine);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.lbTitle);
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(274, 179);
            this.Load += new System.EventHandler(this.BaseControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Panel pLine;
    }
}
