namespace ClientSystem
{
    partial class ChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePwd));
            this.label1 = new CRD.WinUI.Misc.Label();
            this.label2 = new CRD.WinUI.Misc.Label();
            this.label3 = new CRD.WinUI.Misc.Label();
            this.textBox1 = new CRD.WinUI.Misc.TextBox();
            this.textBox2 = new CRD.WinUI.Misc.TextBox();
            this.textBox3 = new CRD.WinUI.Misc.TextBox();
            this.button1 = new CRD.WinUI.Misc.Button();
            this.button2 = new CRD.WinUI.Misc.Button();
            this.pnlBackGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbBottomMiddle
            // 
            this.ptbBottomMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbBottomMiddle.BackgroundImage")));
            this.ptbBottomMiddle.Size = new System.Drawing.Size(391, 37);
            // 
            // pnlBackGroup
            // 
            this.pnlBackGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackGroup.BackgroundImage")));
            this.pnlBackGroup.Controls.Add(this.button2);
            this.pnlBackGroup.Controls.Add(this.button1);
            this.pnlBackGroup.Controls.Add(this.textBox3);
            this.pnlBackGroup.Controls.Add(this.textBox2);
            this.pnlBackGroup.Controls.Add(this.textBox1);
            this.pnlBackGroup.Controls.Add(this.label3);
            this.pnlBackGroup.Controls.Add(this.label2);
            this.pnlBackGroup.Controls.Add(this.label1);
            this.pnlBackGroup.Size = new System.Drawing.Size(407, 184);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(57, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(57, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox1.Location = new System.Drawing.Point(152, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 29);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox2.Location = new System.Drawing.Point(152, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(159, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("宋体", 14F);
            this.textBox3.Location = new System.Drawing.Point(152, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(159, 29);
            this.textBox3.TabIndex = 5;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Caption = "确  认";
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(64, 145);
            this.button1.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("button1.MouseDownImage")));
            this.button1.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("button1.MouseMoveImage")));
            this.button1.Name = "button1";
            this.button1.NormalImage = ((System.Drawing.Image)(resources.GetObject("button1.NormalImage")));
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 6;
            this.button1.ToolTip = null;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Caption = "取 消";
            this.button2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button2.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(225, 145);
            this.button2.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("button2.MouseDownImage")));
            this.button2.MouseMoveImage = ((System.Drawing.Image)(resources.GetObject("button2.MouseMoveImage")));
            this.button2.Name = "button2";
            this.button2.NormalImage = ((System.Drawing.Image)(resources.GetObject("button2.NormalImage")));
            this.button2.Size = new System.Drawing.Size(78, 30);
            this.button2.TabIndex = 7;
            this.button2.ToolTip = null;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 252);
            this.Location = new System.Drawing.Point(272, 260);
            this.Name = "ChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ChangePwd_Load);
            this.Controls.SetChildIndex(this.pnlBackGroup, 0);
            this.pnlBackGroup.ResumeLayout(false);
            this.pnlBackGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CRD.WinUI.Misc.Label label1;
        private CRD.WinUI.Misc.Button button1;
        private CRD.WinUI.Misc.TextBox textBox3;
        private CRD.WinUI.Misc.TextBox textBox2;
        private CRD.WinUI.Misc.TextBox textBox1;
        private CRD.WinUI.Misc.Label label3;
        private CRD.WinUI.Misc.Label label2;
        private CRD.WinUI.Misc.Button button2;
    }
}