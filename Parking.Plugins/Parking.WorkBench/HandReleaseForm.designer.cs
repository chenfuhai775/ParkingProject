namespace Parking.WorkBench
{
    partial class HandReleaseForm
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
            this.cbChannelCode = new System.Windows.Forms.ComboBox();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.lbInOutTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbCarNo = new Parking.Controls.CarNo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCarNo);
            this.groupBox1.Controls.Add(this.cbChannelCode);
            this.groupBox1.Controls.Add(this.cmbCarType);
            this.groupBox1.Controls.Add(this.lbInOutTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbInOut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbChannelCode
            // 
            this.cbChannelCode.FormattingEnabled = true;
            this.cbChannelCode.Location = new System.Drawing.Point(90, 134);
            this.cbChannelCode.Name = "cbChannelCode";
            this.cbChannelCode.Size = new System.Drawing.Size(121, 20);
            this.cbChannelCode.TabIndex = 7;
            // 
            // cmbCarType
            // 
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.Location = new System.Drawing.Point(93, 21);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(121, 20);
            this.cmbCarType.TabIndex = 6;
            // 
            // lbInOutTime
            // 
            this.lbInOutTime.AutoSize = true;
            this.lbInOutTime.Location = new System.Drawing.Point(91, 99);
            this.lbInOutTime.Name = "lbInOutTime";
            this.lbInOutTime.Size = new System.Drawing.Size(35, 12);
            this.lbInOutTime.TabIndex = 5;
            this.lbInOutTime.Text = "- - -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "通道名称：";
            // 
            // lbInOut
            // 
            this.lbInOut.AutoSize = true;
            this.lbInOut.Location = new System.Drawing.Point(19, 100);
            this.lbInOut.Name = "lbInOut";
            this.lbInOut.Size = new System.Drawing.Size(65, 12);
            this.lbInOut.TabIndex = 2;
            this.lbInOut.Text = "入场时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "车牌号码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车辆类型：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(229, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(333, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbCarNo
            // 
            this.tbCarNo.CarNO = "";
            this.tbCarNo.Location = new System.Drawing.Point(90, 56);
            this.tbCarNo.Name = "tbCarNo";
            this.tbCarNo.Size = new System.Drawing.Size(291, 40);
            this.tbCarNo.TabIndex = 8;
            // 
            // HandReleaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 294);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "HandReleaseForm";
            this.Text = "HandReleaseForm";
            this.Load += new System.EventHandler(this.HandReleaseForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbInOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInOutTime;
        private System.Windows.Forms.ComboBox cbChannelCode;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private Controls.CarNo tbCarNo;
    }
}