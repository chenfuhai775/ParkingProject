namespace Parking.CarInformation
{
    partial class ChargeDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgMessage = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbChargeName = new System.Windows.Forms.Label();
            this.lbChargeCode = new System.Windows.Forms.Label();
            this.lbCumulativeWay = new System.Windows.Forms.Label();
            this.lbfreeOvertimeBiling = new System.Windows.Forms.Label();
            this.lbfreePreferentialWay = new System.Windows.Forms.Label();
            this.lbfreeTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgMessage, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 392);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 91);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lbfreeTime, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbfreePreferentialWay, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbfreeOvertimeBiling, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbCumulativeWay, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbChargeCode, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbChargeName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 91);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgMessage
            // 
            this.dgMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMessage.BackgroundColor = System.Drawing.Color.White;
            this.dgMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMessage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMessage.Location = new System.Drawing.Point(3, 120);
            this.dgMessage.Name = "dgMessage";
            this.dgMessage.RowTemplate.Height = 23;
            this.dgMessage.Size = new System.Drawing.Size(473, 269);
            this.dgMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收费规则名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "计费累计方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "免费优惠方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "收费规则编号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "免费超时计费";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "免费停车时长";
            // 
            // lbChargeName
            // 
            this.lbChargeName.AutoSize = true;
            this.lbChargeName.Location = new System.Drawing.Point(96, 0);
            this.lbChargeName.Name = "lbChargeName";
            this.lbChargeName.Size = new System.Drawing.Size(35, 12);
            this.lbChargeName.TabIndex = 6;
            this.lbChargeName.Text = "- - -";
            // 
            // lbChargeCode
            // 
            this.lbChargeCode.AutoSize = true;
            this.lbChargeCode.Location = new System.Drawing.Point(329, 0);
            this.lbChargeCode.Name = "lbChargeCode";
            this.lbChargeCode.Size = new System.Drawing.Size(35, 12);
            this.lbChargeCode.TabIndex = 7;
            this.lbChargeCode.Text = "- - -";
            // 
            // lbCumulativeWay
            // 
            this.lbCumulativeWay.AutoSize = true;
            this.lbCumulativeWay.Location = new System.Drawing.Point(96, 30);
            this.lbCumulativeWay.Name = "lbCumulativeWay";
            this.lbCumulativeWay.Size = new System.Drawing.Size(35, 12);
            this.lbCumulativeWay.TabIndex = 8;
            this.lbCumulativeWay.Text = "- - -";
            // 
            // lbfreeOvertimeBiling
            // 
            this.lbfreeOvertimeBiling.AutoSize = true;
            this.lbfreeOvertimeBiling.Location = new System.Drawing.Point(329, 30);
            this.lbfreeOvertimeBiling.Name = "lbfreeOvertimeBiling";
            this.lbfreeOvertimeBiling.Size = new System.Drawing.Size(35, 12);
            this.lbfreeOvertimeBiling.TabIndex = 9;
            this.lbfreeOvertimeBiling.Text = "- - -";
            // 
            // lbfreePreferentialWay
            // 
            this.lbfreePreferentialWay.AutoSize = true;
            this.lbfreePreferentialWay.Location = new System.Drawing.Point(96, 60);
            this.lbfreePreferentialWay.Name = "lbfreePreferentialWay";
            this.lbfreePreferentialWay.Size = new System.Drawing.Size(35, 12);
            this.lbfreePreferentialWay.TabIndex = 10;
            this.lbfreePreferentialWay.Text = "- - -";
            // 
            // lbfreeTime
            // 
            this.lbfreeTime.AutoSize = true;
            this.lbfreeTime.Location = new System.Drawing.Point(329, 60);
            this.lbfreeTime.Name = "lbfreeTime";
            this.lbfreeTime.Size = new System.Drawing.Size(35, 12);
            this.lbfreeTime.TabIndex = 11;
            this.lbfreeTime.Text = "- - -";
            // 
            // ChargeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChargeDetails";
            this.Size = new System.Drawing.Size(479, 392);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbChargeName;
        private System.Windows.Forms.Label lbfreeTime;
        private System.Windows.Forms.Label lbfreePreferentialWay;
        private System.Windows.Forms.Label lbfreeOvertimeBiling;
        private System.Windows.Forms.Label lbCumulativeWay;
        private System.Windows.Forms.Label lbChargeCode;
    }
}
