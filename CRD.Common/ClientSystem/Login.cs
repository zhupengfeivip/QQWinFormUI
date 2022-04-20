using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientSystem.China_Mobile;
using ClientSystem.ClientSystemServices;
using BaseFunction;
using CRD.WinUI.Forms;

namespace ClientSystem
{
    public partial class Login : Form
    {
        //客户端WebService
        private Service1SoapClient _ssc = new Service1SoapClient();

        private OfficeInfo _officeInfo = null;

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassPort frm = new PassPort();
            frm.ID = 1;
            frm.Show();
            this.Hide();
        }
        #region//鼠标经过改变指针形状
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            string loginName = this.textBox1.Text.Trim();
            string loginPwd = Encryptor.MD5EncryptStr(this.textBox2.Text.Trim());
            string machineMark = this.GetMachinemark();
            try
            {
                this._officeInfo = this._ssc.OfficeLogin(loginName, loginPwd, machineMark);
            }
            catch (Exception)
            {
                MessageBoxForm mbf = new MessageBoxForm("访问服务器时出错！", "系统提示", MessageBoxIcon.Error);
                mbf.ShowDialog();
                return;
            }

            if (this._officeInfo != null)
            {
                if (this._officeInfo.ofId != 0)
                {
                    Main main = new Main();
                    main.OfficeInfo = this._officeInfo;
                    CRD.WinUI.Shared.MainForm = main;
                    main.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBoxForm mbf = new MessageBoxForm("用户名或密码错误，登录失败！", "系统提示");
                    mbf.ShowDialog();
                }
            }
            else
            {
                MessageBoxForm mbf = new MessageBoxForm("登录服务器时出错。", "系统提示", MessageBoxIcon.Error);
                mbf.ShowDialog();
            }
            //Main frm = new Main();
            //frm.Show();
            //this.Hide();
        }

        /// <summary>
        /// 获取计算机标识
        /// </summary>
        /// <returns>计算机标识</returns>
        /// <remarks>
        /// Modifier: Xiaoliang Ge
        /// Modified Date: 2009-12-28
        /// </remarks>
        private string GetMachinemark()
        {
            string rtstr = System.Net.Dns.GetHostName() + "_";

            for (int i = 0; i < System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()).Length; i++)
            {
                rtstr += System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName())[i].ToString() + "_";
            }

            return rtstr;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            button1.lblText.Text = "登录";
            button2.lblText.Text = "退出";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //定义一下坐标
        private Point mouseOffset;
        //判断一下是否按下了左键默认的为False
        private bool isMouseDown = false;


        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //如果按下了左键
                if (isMouseDown)
                {
                    //前当的坐标==鼠标的位置
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                    Location = mousePos;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouseDown = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //X轴
                int xOffset;
                //Y轴
                int yOffset;
                //当按下左键时
                if (e.Button == MouseButtons.Left)
                {
                    //X轴为当前的位置加上窗体的长度
                    xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                    //Y轴为当前的位置加上窗体的高度
                    yOffset = -e.Y - SystemInformation.CaptionHeight -
                        SystemInformation.FrameBorderSize.Height;
                    //综合一下坐标
                    mouseOffset = new Point(xOffset, yOffset);
                    //表示按下了左键
                    isMouseDown = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
