namespace Parking.WorkBench
{
    partial class OrderListInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdOrderInfo = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总时长 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入场区域 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出场区域 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已缴金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.优惠金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrderInfo
            // 
            this.grdOrderInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOrderInfo.BackgroundColor = System.Drawing.Color.White;
            this.grdOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.总时长,
            this.车牌号码,
            this.入场区域,
            this.出场区域,
            this.总金额,
            this.已缴金额,
            this.优惠金额,
            this.状态});
            this.grdOrderInfo.Location = new System.Drawing.Point(3, 66);
            this.grdOrderInfo.Name = "grdOrderInfo";
            this.grdOrderInfo.RowHeadersVisible = false;
            this.grdOrderInfo.RowTemplate.Height = 23;
            this.grdOrderInfo.Size = new System.Drawing.Size(914, 198);
            this.grdOrderInfo.TabIndex = 1;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "NO";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            // 
            // 总时长
            // 
            this.总时长.DataPropertyName = "Total_time";
            this.总时长.HeaderText = "总时长";
            this.总时长.Name = "总时长";
            // 
            // 车牌号码
            // 
            this.车牌号码.DataPropertyName = "VEHICLE_NO";
            this.车牌号码.HeaderText = "车牌号码";
            this.车牌号码.Name = "车牌号码";
            // 
            // 入场区域
            // 
            this.入场区域.DataPropertyName = "IN_PARTITION_CODE";
            this.入场区域.HeaderText = "入场区域";
            this.入场区域.Name = "入场区域";
            // 
            // 出场区域
            // 
            this.出场区域.DataPropertyName = "OUT_PARTITION_CODE";
            this.出场区域.HeaderText = "出场区域";
            this.出场区域.Name = "出场区域";
            // 
            // 总金额
            // 
            this.总金额.DataPropertyName = "TOTAL_COST";
            this.总金额.HeaderText = "总金额";
            this.总金额.Name = "总金额";
            // 
            // 已缴金额
            // 
            this.已缴金额.DataPropertyName = "ALREADY_PAID";
            this.已缴金额.HeaderText = "已缴金额";
            this.已缴金额.Name = "已缴金额";
            // 
            // 优惠金额
            // 
            this.优惠金额.DataPropertyName = "PER_MONEY";
            this.优惠金额.HeaderText = "优惠金额";
            this.优惠金额.Name = "优惠金额";
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "IS_PAY";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(812, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // OrderListInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 315);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdOrderInfo);
            this.Name = "OrderListInfo";
            this.Text = "OrderListInfo";
            this.Controls.SetChildIndex(this.grdOrderInfo, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrderInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总时长;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入场区域;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出场区域;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已缴金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 优惠金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.Button btnCancel;
    }
}