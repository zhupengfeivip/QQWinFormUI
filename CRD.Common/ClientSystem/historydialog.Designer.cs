namespace ClientSystem
{
    partial class historydialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historydialog));
            this.label1 = new CRD.WinUI.Misc.Label();
            this.lid = new CRD.WinUI.Misc.Label();
            this.label2 = new CRD.WinUI.Misc.Label();
            this.label3 = new CRD.WinUI.Misc.Label();
            this.label4 = new CRD.WinUI.Misc.Label();
            this.label5 = new CRD.WinUI.Misc.Label();
            this.label6 = new CRD.WinUI.Misc.Label();
            this.label7 = new CRD.WinUI.Misc.Label();
            this.label8 = new CRD.WinUI.Misc.Label();
            this.lname = new CRD.WinUI.Misc.Label();
            this.lnum = new CRD.WinUI.Misc.Label();
            this.lmoney = new CRD.WinUI.Misc.Label();
            this.ltime = new CRD.WinUI.Misc.Label();
            this.lstate = new CRD.WinUI.Misc.Label();
            this.lallmoney = new CRD.WinUI.Misc.Label();
            this.ltype = new CRD.WinUI.Misc.Label();
            this.btnok = new CRD.WinUI.Misc.Button();
            this.ptbBottomMiddle.SuspendLayout();
            this.pnlBackGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbBottomMiddle
            // 
            this.ptbBottomMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbBottomMiddle.BackgroundImage")));
            this.ptbBottomMiddle.Controls.Add(this.btnok);
            this.ptbBottomMiddle.Size = new System.Drawing.Size(423, 37);
            // 
            // pnlBackGroup
            // 
            this.pnlBackGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackGroup.BackgroundImage")));
            this.pnlBackGroup.Controls.Add(this.ltype);
            this.pnlBackGroup.Controls.Add(this.lallmoney);
            this.pnlBackGroup.Controls.Add(this.lstate);
            this.pnlBackGroup.Controls.Add(this.ltime);
            this.pnlBackGroup.Controls.Add(this.lmoney);
            this.pnlBackGroup.Controls.Add(this.lnum);
            this.pnlBackGroup.Controls.Add(this.lname);
            this.pnlBackGroup.Controls.Add(this.label8);
            this.pnlBackGroup.Controls.Add(this.label7);
            this.pnlBackGroup.Controls.Add(this.label6);
            this.pnlBackGroup.Controls.Add(this.label5);
            this.pnlBackGroup.Controls.Add(this.label4);
            this.pnlBackGroup.Controls.Add(this.label3);
            this.pnlBackGroup.Controls.Add(this.label2);
            this.pnlBackGroup.Controls.Add(this.lid);
            this.pnlBackGroup.Controls.Add(this.label1);
            this.pnlBackGroup.Location = new System.Drawing.Point(0, 31);
            this.pnlBackGroup.Size = new System.Drawing.Size(443, 313);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.BackColor = System.Drawing.Color.Transparent;
            this.lid.Location = new System.Drawing.Point(116, 23);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(41, 12);
            this.lid.TabIndex = 1;
            this.lid.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "业务：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(44, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(44, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(44, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "余额：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "是否返利：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(44, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "时间：";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.Color.Transparent;
            this.lname.Location = new System.Drawing.Point(116, 59);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(41, 12);
            this.lname.TabIndex = 9;
            this.lname.Text = "label9";
            // 
            // lnum
            // 
            this.lnum.AutoSize = true;
            this.lnum.BackColor = System.Drawing.Color.Transparent;
            this.lnum.Location = new System.Drawing.Point(116, 95);
            this.lnum.Name = "lnum";
            this.lnum.Size = new System.Drawing.Size(47, 12);
            this.lnum.TabIndex = 10;
            this.lnum.Text = "label10";
            // 
            // lmoney
            // 
            this.lmoney.AutoSize = true;
            this.lmoney.BackColor = System.Drawing.Color.Transparent;
            this.lmoney.Location = new System.Drawing.Point(116, 129);
            this.lmoney.Name = "lmoney";
            this.lmoney.Size = new System.Drawing.Size(47, 12);
            this.lmoney.TabIndex = 11;
            this.lmoney.Text = "label11";
            // 
            // ltime
            // 
            this.ltime.AutoSize = true;
            this.ltime.BackColor = System.Drawing.Color.Transparent;
            this.ltime.Location = new System.Drawing.Point(116, 167);
            this.ltime.Name = "ltime";
            this.ltime.Size = new System.Drawing.Size(47, 12);
            this.ltime.TabIndex = 12;
            this.ltime.Text = "label12";
            // 
            // lstate
            // 
            this.lstate.AutoSize = true;
            this.lstate.BackColor = System.Drawing.Color.Transparent;
            this.lstate.Location = new System.Drawing.Point(116, 204);
            this.lstate.Name = "lstate";
            this.lstate.Size = new System.Drawing.Size(47, 12);
            this.lstate.TabIndex = 13;
            this.lstate.Text = "label13";
            // 
            // lallmoney
            // 
            this.lallmoney.AutoSize = true;
            this.lallmoney.BackColor = System.Drawing.Color.Transparent;
            this.lallmoney.Location = new System.Drawing.Point(116, 239);
            this.lallmoney.Name = "lallmoney";
            this.lallmoney.Size = new System.Drawing.Size(47, 12);
            this.lallmoney.TabIndex = 14;
            this.lallmoney.Text = "label14";
            // 
            // ltype
            // 
            this.ltype.AutoSize = true;
            this.ltype.BackColor = System.Drawing.Color.Transparent;
            this.ltype.Location = new System.Drawing.Point(116, 276);
            this.ltype.Name = "ltype";
            this.ltype.Size = new System.Drawing.Size(47, 12);
            this.ltype.TabIndex = 15;
            this.ltype.Text = "label15";
            // 
            // btnok
            // 
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnok.Caption = "确定";
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnok.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnok.Location = new System.Drawing.Point(315, 5);
            this.btnok.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnok.MouseDownImage")));
            this.btnok.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("btnok.MouseMoveImage")));
            this.btnok.Name = "btnok";
            this.btnok.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnok.NormalImage")));
            this.btnok.Size = new System.Drawing.Size(78, 30);
            this.btnok.TabIndex = 0;
            this.btnok.ToolTip = null;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // historydialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 381);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "historydialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.historydialog_Load);
            this.Controls.SetChildIndex(this.pnlBackGroup, 0);
            this.ptbBottomMiddle.ResumeLayout(false);
            this.pnlBackGroup.ResumeLayout(false);
            this.pnlBackGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CRD.WinUI.Misc.Label label1;
        private CRD.WinUI.Misc.Label lid;
        private CRD.WinUI.Misc.Label label6;
        private CRD.WinUI.Misc.Label label5;
        private CRD.WinUI.Misc.Label label4;
        private CRD.WinUI.Misc.Label label3;
        private CRD.WinUI.Misc.Label label2;
        private CRD.WinUI.Misc.Label ltype;
        private CRD.WinUI.Misc.Label lallmoney;
        private CRD.WinUI.Misc.Label lstate;
        private CRD.WinUI.Misc.Label ltime;
        private CRD.WinUI.Misc.Label lmoney;
        private CRD.WinUI.Misc.Label lnum;
        private CRD.WinUI.Misc.Label lname;
        private CRD.WinUI.Misc.Label label8;
        private CRD.WinUI.Misc.Label label7;
        private CRD.WinUI.Misc.Button btnok;
    }
}
