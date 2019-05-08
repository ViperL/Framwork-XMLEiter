namespace XMLEditer
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreat = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPDayRe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOutPut = new System.Windows.Forms.Button();
            this.btnSreach = new System.Windows.Forms.Button();
            this.txtSreachId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPDay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreat
            // 
            this.btnCreat.Location = new System.Drawing.Point(625, 26);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(93, 39);
            this.btnCreat.TabIndex = 0;
            this.btnCreat.Text = "创建";
            this.btnCreat.UseVisualStyleBackColor = true;
            this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(625, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(625, 116);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 39);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(625, 161);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(93, 39);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Total,
            this.Day});
            this.DataView.Location = new System.Drawing.Point(12, 26);
            this.DataView.Name = "DataView";
            this.DataView.RowTemplate.Height = 23;
            this.DataView.Size = new System.Drawing.Size(598, 279);
            this.DataView.TabIndex = 1;
            this.DataView.DoubleClick += new System.EventHandler(this.DataView_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.Name = "Id";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "总金额";
            this.Total.Name = "Total";
            this.Total.Width = 200;
            // 
            // Day
            // 
            this.Day.DataPropertyName = "Day";
            this.Day.HeaderText = "日期";
            this.Day.Name = "Day";
            this.Day.Width = 255;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(255, 313);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "总金额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "查询日期：";
            // 
            // DTPDayRe
            // 
            this.DTPDayRe.Location = new System.Drawing.Point(311, 25);
            this.DTPDayRe.Name = "DTPDayRe";
            this.DTPDayRe.Size = new System.Drawing.Size(200, 21);
            this.DTPDayRe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(43, 313);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-200, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID：";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(625, 207);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 39);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "同步";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Location = new System.Drawing.Point(625, 253);
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(93, 39);
            this.btnOutPut.TabIndex = 6;
            this.btnOutPut.Text = "导出";
            this.btnOutPut.UseVisualStyleBackColor = true;
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // btnSreach
            // 
            this.btnSreach.Location = new System.Drawing.Point(622, 15);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.Size = new System.Drawing.Size(93, 39);
            this.btnSreach.TabIndex = 6;
            this.btnSreach.Text = "查找";
            this.btnSreach.UseVisualStyleBackColor = true;
            this.btnSreach.Click += new System.EventHandler(this.btnSreach_Click);
            // 
            // txtSreachId
            // 
            this.txtSreachId.Location = new System.Drawing.Point(68, 25);
            this.txtSreachId.Multiline = true;
            this.txtSreachId.Name = "txtSreachId";
            this.txtSreachId.Size = new System.Drawing.Size(100, 21);
            this.txtSreachId.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "查询ID：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSreach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSreachId);
            this.groupBox1.Controls.Add(this.DTPDayRe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询模组";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "日期：";
            // 
            // DTPDay
            // 
            this.DTPDay.Location = new System.Drawing.Point(424, 313);
            this.DTPDay.Name = "DTPDay";
            this.DTPDay.Size = new System.Drawing.Size(200, 21);
            this.DTPDay.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOutPut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.DTPDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCreat);
            this.Name = "Form1";
            this.Text = "获取";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPDayRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.Button btnOutPut;
        private System.Windows.Forms.Button btnSreach;
        private System.Windows.Forms.TextBox txtSreachId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPDay;
    }
}

