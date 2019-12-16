namespace Parking.ControlPanel
{
    partial class CentralPaymentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtOutTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtInTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCardNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCarNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pCarPic = new System.Windows.Forms.Panel();
            this.pagingControl = new Parking.Controls.PagingControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.cmbCardType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtOutTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtInTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCardNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCarNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(230)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(474, 75);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 34);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(230)))));
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(374, 75);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(89, 34);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbCardType
            // 
            this.cmbCardType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Location = new System.Drawing.Point(83, 77);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(121, 29);
            this.cmbCardType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(10, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "卡类型";
            // 
            // dtOutTime
            // 
            this.dtOutTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtOutTime.Location = new System.Drawing.Point(656, 30);
            this.dtOutTime.Name = "dtOutTime";
            this.dtOutTime.Size = new System.Drawing.Size(144, 29);
            this.dtOutTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(620, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "至";
            // 
            // dtInTime
            // 
            this.dtInTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtInTime.Location = new System.Drawing.Point(462, 30);
            this.dtInTime.Name = "dtInTime";
            this.dtInTime.Size = new System.Drawing.Size(153, 29);
            this.dtInTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(375, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "入场时间";
            // 
            // tbCardNum
            // 
            this.tbCardNum.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbCardNum.Location = new System.Drawing.Point(257, 30);
            this.tbCardNum.Name = "tbCardNum";
            this.tbCardNum.Size = new System.Drawing.Size(100, 29);
            this.tbCardNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(209, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "卡号";
            // 
            // tbCarNo
            // 
            this.tbCarNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbCarNo.Location = new System.Drawing.Point(83, 30);
            this.tbCarNo.Name = "tbCarNo";
            this.tbCarNo.Size = new System.Drawing.Size(120, 29);
            this.tbCarNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号码";
            // 
            // pCarPic
            // 
            this.pCarPic.Location = new System.Drawing.Point(3, 255);
            this.pCarPic.Name = "pCarPic";
            this.pCarPic.Size = new System.Drawing.Size(802, 215);
            this.pCarPic.TabIndex = 4;
            // 
            // pagingControl
            // 
            this.pagingControl.Location = new System.Drawing.Point(3, 512);
            this.pagingControl.Name = "pagingControl";
            this.pagingControl.Size = new System.Drawing.Size(818, 40);
            this.pagingControl.TabIndex = 5;
            // 
            // CentralPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pCarPic);
            this.Controls.Add(this.pagingControl);
            this.Name = "CentralPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CentralPaymentForm";
            this.Load += new System.EventHandler(this.CarInSideForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCardType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtOutTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtInTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCarNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pCarPic;
        private Controls.PagingControl pagingControl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnQuery;
    }
}