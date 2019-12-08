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
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            // cmbCardType
            // 
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Location = new System.Drawing.Point(83, 77);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(121, 20);
            this.cmbCardType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "卡类型";
            // 
            // dtOutTime
            // 
            this.dtOutTime.Location = new System.Drawing.Point(605, 31);
            this.dtOutTime.Name = "dtOutTime";
            this.dtOutTime.Size = new System.Drawing.Size(119, 21);
            this.dtOutTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "至";
            // 
            // dtInTime
            // 
            this.dtInTime.Location = new System.Drawing.Point(431, 31);
            this.dtInTime.Name = "dtInTime";
            this.dtInTime.Size = new System.Drawing.Size(118, 21);
            this.dtInTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "入场时间";
            // 
            // tbCardNum
            // 
            this.tbCardNum.Location = new System.Drawing.Point(255, 31);
            this.tbCardNum.Name = "tbCardNum";
            this.tbCardNum.Size = new System.Drawing.Size(100, 21);
            this.tbCardNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "卡号";
            // 
            // tbCarNo
            // 
            this.tbCarNo.Location = new System.Drawing.Point(83, 34);
            this.tbCarNo.Name = "tbCarNo";
            this.tbCarNo.Size = new System.Drawing.Size(100, 21);
            this.tbCarNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
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
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(374, 75);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(474, 75);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.Text = "CentralPaymentForm";
            this.Load += new System.EventHandler(this.CarInSideForm_Load);
            this.Controls.SetChildIndex(this.pagingControl, 0);
            this.Controls.SetChildIndex(this.pCarPic, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
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