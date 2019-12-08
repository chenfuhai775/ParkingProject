namespace Parking.OwnerInfo
{
    partial class OwnerControl
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
            this.lb_Name = new System.Windows.Forms.Label();
            this.picIn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCarNo = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIn)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picIn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Name.ForeColor = System.Drawing.Color.Red;
            this.lb_Name.Location = new System.Drawing.Point(3, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(379, 60);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "- - -";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIn
            // 
            this.picIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIn.Location = new System.Drawing.Point(3, 63);
            this.picIn.Name = "picIn";
            this.picIn.Size = new System.Drawing.Size(379, 302);
            this.picIn.TabIndex = 1;
            this.picIn.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 74);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lb_Address, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Phone, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbCarNo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbCarNo
            // 
            this.lbCarNo.AutoSize = true;
            this.lbCarNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCarNo.Location = new System.Drawing.Point(3, 0);
            this.lbCarNo.Name = "lbCarNo";
            this.lbCarNo.Size = new System.Drawing.Size(373, 24);
            this.lbCarNo.TabIndex = 0;
            this.lbCarNo.Text = "- - -";
            this.lbCarNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Phone.Location = new System.Drawing.Point(3, 24);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(373, 24);
            this.lb_Phone.TabIndex = 1;
            this.lb_Phone.Text = "- - -";
            this.lb_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Address.Location = new System.Drawing.Point(3, 48);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(373, 26);
            this.lb_Address.TabIndex = 2;
            this.lb_Address.Text = "- - -";
            this.lb_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OwnerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OwnerControl";
            this.Size = new System.Drawing.Size(385, 448);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.PictureBox picIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbCarNo;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_Phone;
    }
}
