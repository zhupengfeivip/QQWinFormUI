namespace ClientSystem
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltop = new CRD.WinUI.Misc.panel();
            this.cbbfunction = new System.Windows.Forms.ComboBox();
            this.btnSearch = new CRD.WinUI.Misc.Button();
            this.dtend = new System.Windows.Forms.DateTimePicker();
            this.dtstart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new CRD.WinUI.Misc.Label();
            this.label3 = new CRD.WinUI.Misc.Label();
            this.label1 = new CRD.WinUI.Misc.Label();
            this.paneldown = new CRD.WinUI.Misc.panel();
            this.lmoney = new CRD.WinUI.Misc.Label();
            this.lallmoney = new CRD.WinUI.Misc.Label();
            this.lblmoney = new CRD.WinUI.Misc.Label();
            this.lblallmoney = new CRD.WinUI.Misc.Label();
            this.dgvhistory = new CRD.WinUI.Editors.DataGridView();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业务 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.交易金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.余额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.返利状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.查看 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlBackGroup.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.paneldown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackGroup
            // 
            this.pnlBackGroup.Controls.Add(this.paneldown);
            this.pnlBackGroup.Controls.Add(this.paneltop);
            this.pnlBackGroup.Location = new System.Drawing.Point(2, 0);
            this.pnlBackGroup.Size = new System.Drawing.Size(719, 496);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Transparent;
            this.paneltop.Controls.Add(this.lmoney);
            this.paneltop.Controls.Add(this.cbbfunction);
            this.paneltop.Controls.Add(this.lallmoney);
            this.paneltop.Controls.Add(this.btnSearch);
            this.paneltop.Controls.Add(this.lblmoney);
            this.paneltop.Controls.Add(this.dtend);
            this.paneltop.Controls.Add(this.lblallmoney);
            this.paneltop.Controls.Add(this.dtstart);
            this.paneltop.Controls.Add(this.label2);
            this.paneltop.Controls.Add(this.label3);
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.ImageTransparentColor = System.Drawing.Color.Empty;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(719, 70);
            this.paneltop.TabIndex = 0;
            // 
            // cbbfunction
            // 
            this.cbbfunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbfunction.FormattingEnabled = true;
            this.cbbfunction.Location = new System.Drawing.Point(106, 19);
            this.cbbfunction.Name = "cbbfunction";
            this.cbbfunction.Size = new System.Drawing.Size(121, 20);
            this.cbbfunction.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Caption = "查询";
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(591, 14);
            this.btnSearch.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.MouseDownImage")));
            this.btnSearch.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.MouseMoveImage")));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.NormalImage")));
            this.btnSearch.Size = new System.Drawing.Size(78, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.ToolTip = null;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtend
            // 
            this.dtend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtend.Location = new System.Drawing.Point(476, 19);
            this.dtend.Name = "dtend";
            this.dtend.Size = new System.Drawing.Size(95, 21);
            this.dtend.TabIndex = 2;
            // 
            // dtstart
            // 
            this.dtstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtstart.Location = new System.Drawing.Point(321, 19);
            this.dtstart.Name = "dtstart";
            this.dtstart.Size = new System.Drawing.Size(98, 21);
            this.dtstart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "相关业务：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(439, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "到";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(274, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间：";
            // 
            // paneldown
            // 
            this.paneldown.BackColor = System.Drawing.Color.Transparent;
            this.paneldown.Controls.Add(this.dgvhistory);
            this.paneldown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldown.ImageTransparentColor = System.Drawing.Color.Empty;
            this.paneldown.Location = new System.Drawing.Point(0, 70);
            this.paneldown.Name = "paneldown";
            this.paneldown.Size = new System.Drawing.Size(719, 426);
            this.paneldown.TabIndex = 1;
            // 
            // lmoney
            // 
            this.lmoney.AutoSize = true;
            this.lmoney.BackColor = System.Drawing.Color.Transparent;
            this.lmoney.Location = new System.Drawing.Point(237, 55);
            this.lmoney.Name = "lmoney";
            this.lmoney.Size = new System.Drawing.Size(11, 12);
            this.lmoney.TabIndex = 0;
            this.lmoney.Text = "0";
            // 
            // lallmoney
            // 
            this.lallmoney.AutoSize = true;
            this.lallmoney.BackColor = System.Drawing.Color.Transparent;
            this.lallmoney.Location = new System.Drawing.Point(90, 55);
            this.lallmoney.Name = "lallmoney";
            this.lallmoney.Size = new System.Drawing.Size(11, 12);
            this.lallmoney.TabIndex = 0;
            this.lallmoney.Text = "0";
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.BackColor = System.Drawing.Color.Transparent;
            this.lblmoney.Location = new System.Drawing.Point(141, 55);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(89, 12);
            this.lblmoney.TabIndex = 0;
            this.lblmoney.Text = "实际消费金额：";
            // 
            // lblallmoney
            // 
            this.lblallmoney.AutoSize = true;
            this.lblallmoney.BackColor = System.Drawing.Color.Transparent;
            this.lblallmoney.Location = new System.Drawing.Point(34, 55);
            this.lblallmoney.Name = "lblallmoney";
            this.lblallmoney.Size = new System.Drawing.Size(53, 12);
            this.lblallmoney.TabIndex = 0;
            this.lblallmoney.Text = "总金额：";
            // 
            // dgvhistory
            // 
            this.dgvhistory.AllowUserToAddRows = false;
            this.dgvhistory.AllowUserToDeleteRows = false;
            this.dgvhistory.AllowUserToOrderColumns = true;
            this.dgvhistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvhistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhistory.ColumnHeadersHeight = 26;
            this.dgvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvhistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.业务,
            this.号码,
            this.交易金额,
            this.时间,
            this.状态,
            this.余额,
            this.返利状态,
            this.查看});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvhistory.EnableHeadersVisualStyles = false;
            this.dgvhistory.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvhistory.Location = new System.Drawing.Point(0, 0);
            this.dgvhistory.Name = "dgvhistory";
            this.dgvhistory.ReadOnly = true;
            this.dgvhistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvhistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvhistory.RowTemplate.Height = 23;
            this.dgvhistory.Size = new System.Drawing.Size(719, 426);
            this.dgvhistory.TabIndex = 0;
            this.dgvhistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhistory_CellClick);
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "hid";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            this.编号.Width = 60;
            // 
            // 业务
            // 
            this.业务.DataPropertyName = "hname";
            this.业务.HeaderText = "业务";
            this.业务.Name = "业务";
            this.业务.ReadOnly = true;
            this.业务.Width = 70;
            // 
            // 号码
            // 
            this.号码.DataPropertyName = "hnumber";
            this.号码.HeaderText = "号码";
            this.号码.Name = "号码";
            this.号码.ReadOnly = true;
            this.号码.Width = 80;
            // 
            // 交易金额
            // 
            this.交易金额.DataPropertyName = "hmoney";
            this.交易金额.HeaderText = "交易金额";
            this.交易金额.Name = "交易金额";
            this.交易金额.ReadOnly = true;
            this.交易金额.Width = 70;
            // 
            // 时间
            // 
            this.时间.DataPropertyName = "htime";
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            this.时间.ReadOnly = true;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "hstate";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.Width = 70;
            // 
            // 余额
            // 
            this.余额.DataPropertyName = "hallmoney";
            this.余额.HeaderText = "余额";
            this.余额.Name = "余额";
            this.余额.ReadOnly = true;
            this.余额.Width = 60;
            // 
            // 返利状态
            // 
            this.返利状态.DataPropertyName = "htype";
            this.返利状态.HeaderText = "返利状态";
            this.返利状态.Name = "返利状态";
            this.返利状态.ReadOnly = true;
            this.返利状态.Width = 70;
            // 
            // 查看
            // 
            this.查看.DataPropertyName = "operate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "查看";
            this.查看.DefaultCellStyle = dataGridViewCellStyle2;
            this.查看.HeaderText = "查看";
            this.查看.Name = "查看";
            this.查看.ReadOnly = true;
            this.查看.Text = "查看";
            this.查看.Width = 50;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.Controls.SetChildIndex(this.pnlBackGroup, 0);
            this.pnlBackGroup.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.paneldown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CRD.WinUI.Misc.panel paneltop;
        private CRD.WinUI.Misc.panel paneldown;
        private CRD.WinUI.Misc.Label label1;
        private CRD.WinUI.Misc.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtend;
        private System.Windows.Forms.DateTimePicker dtstart;
        private CRD.WinUI.Misc.Label label2;
        private CRD.WinUI.Misc.Label label3;
        private CRD.WinUI.Editors.DataGridView dgvhistory;
        private System.Windows.Forms.ComboBox cbbfunction;
        private CRD.WinUI.Misc.Label lmoney;
        private CRD.WinUI.Misc.Label lallmoney;
        private CRD.WinUI.Misc.Label lblmoney;
        private CRD.WinUI.Misc.Label lblallmoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业务;
        private System.Windows.Forms.DataGridViewTextBoxColumn 号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交易金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 余额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 返利状态;
        private System.Windows.Forms.DataGridViewButtonColumn 查看;
    }
}
