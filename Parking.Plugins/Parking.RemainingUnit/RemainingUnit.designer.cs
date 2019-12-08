namespace Parking.RemainingUnit
{
    partial class RemainingUnit
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgParkingStatistics = new System.Windows.Forms.DataGridView();
            this.分区信息 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.临时车位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月租车位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParkingStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgParkingStatistics, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgParkingStatistics
            // 
            this.dgParkingStatistics.AllowUserToAddRows = false;
            this.dgParkingStatistics.AllowUserToDeleteRows = false;
            this.dgParkingStatistics.AllowUserToResizeColumns = false;
            this.dgParkingStatistics.AllowUserToResizeRows = false;
            this.dgParkingStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgParkingStatistics.BackgroundColor = System.Drawing.Color.White;
            this.dgParkingStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParkingStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.分区信息,
            this.临时车位,
            this.月租车位,
            this.总计});
            this.dgParkingStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgParkingStatistics.Location = new System.Drawing.Point(23, 3);
            this.dgParkingStatistics.Name = "dgParkingStatistics";
            this.dgParkingStatistics.RowHeadersVisible = false;
            this.dgParkingStatistics.RowTemplate.Height = 23;
            this.dgParkingStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParkingStatistics.Size = new System.Drawing.Size(554, 294);
            this.dgParkingStatistics.TabIndex = 0;
            // 
            // 分区信息
            // 
            this.分区信息.HeaderText = "分区信息";
            this.分区信息.Name = "分区信息";
            // 
            // 临时车位
            // 
            this.临时车位.HeaderText = "临时车位";
            this.临时车位.Name = "临时车位";
            // 
            // 月租车位
            // 
            this.月租车位.HeaderText = "月租车位";
            this.月租车位.Name = "月租车位";
            // 
            // 总计
            // 
            this.总计.HeaderText = "总计";
            this.总计.Name = "总计";
            // 
            // RemainingUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RemainingUnit";
            this.Size = new System.Drawing.Size(600, 300);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgParkingStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgParkingStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分区信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 临时车位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月租车位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总计;
    }
}
