using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientSystem;
using ClientSystem.ClientSystemServices;

namespace ClientSystem
{
    public partial class PassPort : Form
    {
        public int ID;
        private ClientSystemServices.Service1SoapClient user = new ClientSystem.ClientSystemServices.Service1SoapClient();
        public OfficeInfo OfficeInfo { get; set; }
        public PassPort()
        {
            InitializeComponent();
            label4.Text = "密保卡对应" + "\n" + "坐标密码：";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PassPort_Load(object sender, EventArgs e)
        {
            string X = user.GetX(this.OfficeInfo.ofPara1,this.OfficeInfo.ofId);
            textBox1.Text = X.Substring(0,2);
            textBox2.Text = X.Substring(2,2);
            textBox3.Text = X.Substring(4,2);
        }
        #region//点击确认按键
        private void button1_Click(object sender, EventArgs e)
        {
            string n1 = textBox1.Text.ToString().Trim();
            string n2 = textBox2.Text.ToString().Trim();
            string n3 = textBox3.Text.ToString().Trim();
            string valation1 = textBox4.Text.ToString().Trim();
            string valation2 = textBox5.Text.ToString().Trim();
            string valation3 = textBox6.Text.ToString().Trim();
            int UserId = ID;
            bool PassOrNot = user.PassOrNot(this.OfficeInfo.ofPara1,ID,valation1,valation2,valation3,n1,n2,n3);
            if (PassOrNot==true)
            {
                Main frm = new Main();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！");
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
            }
        }
        #endregion
        #region//鼠标经过改变指针形状
        //鼠标经过时鼠标指针变为.Hand
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        //鼠标离开时鼠标指针变为.Arrow
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        #endregion
    }
}
