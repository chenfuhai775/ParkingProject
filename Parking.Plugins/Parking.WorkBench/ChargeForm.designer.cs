namespace Parking.WorkBench
{
    partial class ChargeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgDiscount = new System.Windows.Forms.DataGridView();
            this.优惠项目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.策略名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小票编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.优惠金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.优惠类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.优惠额度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbCarNo = new System.Windows.Forms.Label();
            this.lbInTime = new System.Windows.Forms.Label();
            this.lbOutTime = new System.Windows.Forms.Label();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.lbDueMoney = new System.Windows.Forms.Label();
            this.lbAlreadyPaid = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbPreMoney = new System.Windows.Forms.Label();
            this.lbChargeMoney = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbPreMoney = new System.Windows.Forms.TextBox();
            this.tbQRcode = new System.Windows.Forms.TextBox();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReCharging = new System.Windows.Forms.Button();
            this.btnReSound = new System.Windows.Forms.Button();
            this.btnFree = new System.Windows.Forms.Button();
            this.cbPayType = new System.Windows.Forms.ComboBox();
            this.lbOperator = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "车牌号码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "入场时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "出场时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "停车时长：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(26, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "应缴金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(26, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "已缴金额：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "付款方式：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(26, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "二维码号：";
            // 
            // dgDiscount
            // 
            this.dgDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDiscount.BackgroundColor = System.Drawing.Color.White;
            this.dgDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.优惠项目,
            this.策略名称,
            this.小票编码,
            this.优惠金额,
            this.优惠类型,
            this.优惠额度,
            this.操作});
            this.dgDiscount.Location = new System.Drawing.Point(30, 430);
            this.dgDiscount.Name = "dgDiscount";
            this.dgDiscount.RowHeadersVisible = false;
            this.dgDiscount.RowTemplate.Height = 23;
            this.dgDiscount.Size = new System.Drawing.Size(636, 83);
            this.dgDiscount.TabIndex = 9;
            // 
            // 优惠项目
            // 
            this.优惠项目.HeaderText = "优惠项目";
            this.优惠项目.Name = "优惠项目";
            // 
            // 策略名称
            // 
            this.策略名称.HeaderText = "策略名称";
            this.策略名称.Name = "策略名称";
            // 
            // 小票编码
            // 
            this.小票编码.HeaderText = "小票编码";
            this.小票编码.Name = "小票编码";
            // 
            // 优惠金额
            // 
            this.优惠金额.HeaderText = "优惠金额";
            this.优惠金额.Name = "优惠金额";
            // 
            // 优惠类型
            // 
            this.优惠类型.HeaderText = "优惠类型";
            this.优惠类型.Name = "优惠类型";
            // 
            // 优惠额度
            // 
            this.优惠额度.HeaderText = "优惠额度";
            this.优惠额度.Name = "优惠额度";
            // 
            // 操作
            // 
            this.操作.HeaderText = "操作";
            this.操作.Name = "操作";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel2.Location = new System.Drawing.Point(30, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 1);
            this.panel2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(350, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "车辆类型：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(350, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "收费人员：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(350, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "账单数量：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(350, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 22);
            this.label12.TabIndex = 14;
            this.label12.Text = "优惠金额：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(350, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 22);
            this.label13.TabIndex = 15;
            this.label13.Text = "实收金额：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(350, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 22);
            this.label14.TabIndex = 16;
            this.label14.Text = "手工优惠：";
            // 
            // lbCarNo
            // 
            this.lbCarNo.AutoSize = true;
            this.lbCarNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCarNo.Location = new System.Drawing.Point(145, 78);
            this.lbCarNo.Name = "lbCarNo";
            this.lbCarNo.Size = new System.Drawing.Size(41, 22);
            this.lbCarNo.TabIndex = 17;
            this.lbCarNo.Text = "- - -";
            // 
            // lbInTime
            // 
            this.lbInTime.AutoSize = true;
            this.lbInTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInTime.Location = new System.Drawing.Point(145, 129);
            this.lbInTime.Name = "lbInTime";
            this.lbInTime.Size = new System.Drawing.Size(41, 22);
            this.lbInTime.TabIndex = 18;
            this.lbInTime.Text = "- - -";
            // 
            // lbOutTime
            // 
            this.lbOutTime.AutoSize = true;
            this.lbOutTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOutTime.Location = new System.Drawing.Point(145, 177);
            this.lbOutTime.Name = "lbOutTime";
            this.lbOutTime.Size = new System.Drawing.Size(41, 22);
            this.lbOutTime.TabIndex = 19;
            this.lbOutTime.Text = "- - -";
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalTime.Location = new System.Drawing.Point(145, 215);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(41, 22);
            this.lbTotalTime.TabIndex = 20;
            this.lbTotalTime.Text = "- - -";
            // 
            // lbDueMoney
            // 
            this.lbDueMoney.AutoSize = true;
            this.lbDueMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDueMoney.ForeColor = System.Drawing.Color.Red;
            this.lbDueMoney.Location = new System.Drawing.Point(145, 258);
            this.lbDueMoney.Name = "lbDueMoney";
            this.lbDueMoney.Size = new System.Drawing.Size(20, 22);
            this.lbDueMoney.TabIndex = 21;
            this.lbDueMoney.Text = "0";
            // 
            // lbAlreadyPaid
            // 
            this.lbAlreadyPaid.AutoSize = true;
            this.lbAlreadyPaid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAlreadyPaid.ForeColor = System.Drawing.Color.Red;
            this.lbAlreadyPaid.Location = new System.Drawing.Point(145, 298);
            this.lbAlreadyPaid.Name = "lbAlreadyPaid";
            this.lbAlreadyPaid.Size = new System.Drawing.Size(20, 22);
            this.lbAlreadyPaid.TabIndex = 22;
            this.lbAlreadyPaid.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(222, 258);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 22);
            this.label21.TabIndex = 23;
            this.label21.Text = "元";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(222, 298);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 22);
            this.label22.TabIndex = 24;
            this.label22.Text = "元";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(529, 238);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 22);
            this.label23.TabIndex = 25;
            this.label23.Text = "元";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(529, 280);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 22);
            this.label24.TabIndex = 26;
            this.label24.Text = "元";
            // 
            // lbPreMoney
            // 
            this.lbPreMoney.AutoSize = true;
            this.lbPreMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPreMoney.ForeColor = System.Drawing.Color.Red;
            this.lbPreMoney.Location = new System.Drawing.Point(466, 238);
            this.lbPreMoney.Name = "lbPreMoney";
            this.lbPreMoney.Size = new System.Drawing.Size(20, 22);
            this.lbPreMoney.TabIndex = 27;
            this.lbPreMoney.Text = "0";
            // 
            // lbChargeMoney
            // 
            this.lbChargeMoney.AutoSize = true;
            this.lbChargeMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChargeMoney.ForeColor = System.Drawing.Color.Red;
            this.lbChargeMoney.Location = new System.Drawing.Point(466, 280);
            this.lbChargeMoney.Name = "lbChargeMoney";
            this.lbChargeMoney.Size = new System.Drawing.Size(20, 22);
            this.lbChargeMoney.TabIndex = 28;
            this.lbChargeMoney.Text = "0";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrderNum.ForeColor = System.Drawing.Color.Red;
            this.lblOrderNum.Location = new System.Drawing.Point(466, 189);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(20, 22);
            this.lblOrderNum.TabIndex = 29;
            this.lblOrderNum.Text = "0";
            this.lblOrderNum.Click += new System.EventHandler(this.lblOrderNum_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(529, 189);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 22);
            this.label28.TabIndex = 30;
            this.label28.Text = "笔";
            // 
            // tbPreMoney
            // 
            this.tbPreMoney.Location = new System.Drawing.Point(455, 332);
            this.tbPreMoney.Name = "tbPreMoney";
            this.tbPreMoney.Size = new System.Drawing.Size(100, 21);
            this.tbPreMoney.TabIndex = 32;
            this.tbPreMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPreMoney_KeyUp);
            // 
            // tbQRcode
            // 
            this.tbQRcode.Location = new System.Drawing.Point(136, 369);
            this.tbQRcode.Name = "tbQRcode";
            this.tbQRcode.Size = new System.Drawing.Size(419, 21);
            this.tbQRcode.TabIndex = 33;
            this.tbQRcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbQRcode_KeyUp);
            // 
            // cbCarType
            // 
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Location = new System.Drawing.Point(455, 90);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(121, 20);
            this.cbCarType.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(588, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReCharging
            // 
            this.btnReCharging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btnReCharging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReCharging.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReCharging.ForeColor = System.Drawing.Color.White;
            this.btnReCharging.Location = new System.Drawing.Point(588, 194);
            this.btnReCharging.Name = "btnReCharging";
            this.btnReCharging.Size = new System.Drawing.Size(120, 50);
            this.btnReCharging.TabIndex = 37;
            this.btnReCharging.Text = "重新计费";
            this.btnReCharging.UseVisualStyleBackColor = false;
            this.btnReCharging.Click += new System.EventHandler(this.btnReCharging_Click);
            // 
            // btnReSound
            // 
            this.btnReSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btnReSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReSound.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReSound.ForeColor = System.Drawing.Color.White;
            this.btnReSound.Location = new System.Drawing.Point(588, 254);
            this.btnReSound.Name = "btnReSound";
            this.btnReSound.Size = new System.Drawing.Size(120, 50);
            this.btnReSound.TabIndex = 38;
            this.btnReSound.Text = "重报语音";
            this.btnReSound.UseVisualStyleBackColor = false;
            this.btnReSound.Click += new System.EventHandler(this.btnReSound_Click);
            // 
            // btnFree
            // 
            this.btnFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btnFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFree.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFree.ForeColor = System.Drawing.Color.White;
            this.btnFree.Location = new System.Drawing.Point(588, 314);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(120, 50);
            this.btnFree.TabIndex = 39;
            this.btnFree.Text = "免费放行";
            this.btnFree.UseVisualStyleBackColor = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // cbPayType
            // 
            this.cbPayType.FormattingEnabled = true;
            this.cbPayType.Location = new System.Drawing.Point(136, 335);
            this.cbPayType.Name = "cbPayType";
            this.cbPayType.Size = new System.Drawing.Size(121, 20);
            this.cbPayType.TabIndex = 40;
            this.cbPayType.SelectedIndexChanged += new System.EventHandler(this.cbPayType_SelectedIndexChanged);
            // 
            // lbOperator
            // 
            this.lbOperator.AutoSize = true;
            this.lbOperator.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOperator.Location = new System.Drawing.Point(466, 141);
            this.lbOperator.Name = "lbOperator";
            this.lbOperator.Size = new System.Drawing.Size(41, 22);
            this.lbOperator.TabIndex = 41;
            this.lbOperator.Text = "- - -";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(588, 377);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(35, 12);
            this.lbMessage.TabIndex = 42;
            this.lbMessage.Text = "- - -";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(588, 74);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 50);
            this.btnOK.TabIndex = 35;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 545);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbOperator);
            this.Controls.Add(this.cbPayType);
            this.Controls.Add(this.btnFree);
            this.Controls.Add(this.btnReSound);
            this.Controls.Add(this.btnReCharging);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.tbQRcode);
            this.Controls.Add(this.tbPreMoney);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lbChargeMoney);
            this.Controls.Add(this.lbPreMoney);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbAlreadyPaid);
            this.Controls.Add(this.lbDueMoney);
            this.Controls.Add(this.lbTotalTime);
            this.Controls.Add(this.lbOutTime);
            this.Controls.Add(this.lbInTime);
            this.Controls.Add(this.lbCarNo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChargeForm";
            this.Text = "ChargeForm";
            this.Load += new System.EventHandler(this.ChargeForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dgDiscount, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.lbCarNo, 0);
            this.Controls.SetChildIndex(this.lbInTime, 0);
            this.Controls.SetChildIndex(this.lbOutTime, 0);
            this.Controls.SetChildIndex(this.lbTotalTime, 0);
            this.Controls.SetChildIndex(this.lbDueMoney, 0);
            this.Controls.SetChildIndex(this.lbAlreadyPaid, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.label23, 0);
            this.Controls.SetChildIndex(this.label24, 0);
            this.Controls.SetChildIndex(this.lbPreMoney, 0);
            this.Controls.SetChildIndex(this.lbChargeMoney, 0);
            this.Controls.SetChildIndex(this.lblOrderNum, 0);
            this.Controls.SetChildIndex(this.label28, 0);
            this.Controls.SetChildIndex(this.tbPreMoney, 0);
            this.Controls.SetChildIndex(this.tbQRcode, 0);
            this.Controls.SetChildIndex(this.cbCarType, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnReCharging, 0);
            this.Controls.SetChildIndex(this.btnReSound, 0);
            this.Controls.SetChildIndex(this.btnFree, 0);
            this.Controls.SetChildIndex(this.cbPayType, 0);
            this.Controls.SetChildIndex(this.lbOperator, 0);
            this.Controls.SetChildIndex(this.lbMessage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn 优惠项目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 策略名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小票编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 优惠金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 优惠类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 优惠额度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbCarNo;
        private System.Windows.Forms.Label lbInTime;
        private System.Windows.Forms.Label lbOutTime;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.Label lbDueMoney;
        private System.Windows.Forms.Label lbAlreadyPaid;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbPreMoney;
        private System.Windows.Forms.Label lbChargeMoney;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbPreMoney;
        private System.Windows.Forms.TextBox tbQRcode;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReCharging;
        private System.Windows.Forms.Button btnReSound;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.ComboBox cbPayType;
        private System.Windows.Forms.Label lbOperator;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnOK;
    }
}