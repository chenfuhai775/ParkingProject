namespace Parking.WorkBench
{
    partial class OccupyRecordInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdInOutsInfo = new System.Windows.Forms.DataGridView();
            this.车牌号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入场时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出场时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdInOutsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInOutsInfo
            // 
            this.grdInOutsInfo.BackgroundColor = System.Drawing.Color.White;
            this.grdInOutsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInOutsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grdInOutsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInOutsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.车牌号码,
            this.入场时间,
            this.出场时间});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdInOutsInfo.DefaultCellStyle = dataGridViewCellStyle23;
            this.grdInOutsInfo.GridColor = System.Drawing.Color.White;
            this.grdInOutsInfo.Location = new System.Drawing.Point(8, 49);
            this.grdInOutsInfo.Name = "grdInOutsInfo";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInOutsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.grdInOutsInfo.RowHeadersVisible = false;
            this.grdInOutsInfo.RowTemplate.Height = 23;
            this.grdInOutsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInOutsInfo.Size = new System.Drawing.Size(633, 233);
            this.grdInOutsInfo.TabIndex = 1;
            // 
            // 车牌号码
            // 
            this.车牌号码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.车牌号码.DataPropertyName = "VEHICLE_NO";
            this.车牌号码.HeaderText = "车牌号码";
            this.车牌号码.Name = "车牌号码";
            // 
            // 入场时间
            // 
            this.入场时间.DataPropertyName = "IN_TIME";
            this.入场时间.HeaderText = "入场时间";
            this.入场时间.Name = "入场时间";
            this.入场时间.Width = 200;
            // 
            // 出场时间
            // 
            this.出场时间.DataPropertyName = "OUT_TIME";
            this.出场时间.HeaderText = "出场时间";
            this.出场时间.Name = "出场时间";
            this.出场时间.Width = 200;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(230)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(542, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OccupyRecordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdInOutsInfo);
            this.Name = "OccupyRecordInfo";
            this.Text = "OccupyRecordInfo";
            ((System.ComponentModel.ISupportInitialize)(this.grdInOutsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInOutsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入场时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出场时间;
        private System.Windows.Forms.Button btnCancel;
    }
}