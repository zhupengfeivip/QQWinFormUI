using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClientSystem.ClientSystemServices;
using System.Windows.Forms;
using CRD.WinUI.Forms;

namespace ClientSystem
{
    public partial class ChangePwd : CRD .WinUI.Forms.EntryForm
    {
      private readonly ClientSystemServices.Service1SoapClient objClientSystemServices = new ClientSystem.ClientSystemServices.Service1SoapClient();
        public ChangePwd()
        {
            InitializeComponent();
        }
        //营业厅完整信息
        public OfficeInfo OfficeInfo { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

            #region//密码非空验证
            string Pwd = objClientSystemServices.Get_UserPwd(this.OfficeInfo.ofPara1, this.OfficeInfo.ofId);
            if (BaseFunction.Encryptor.MD5EncryptStr(textBox1.Text.ToString().Trim())!=Pwd)
            {
                MessageBoxForm objm = new MessageBoxForm("原密码错误！", "温馨提示：",MessageBoxIcon.Error);
                objm.ShowDialog();
                return;
            }
            if (textBox1.Text.ToString().Trim() == "" || textBox2.Text.ToString().Trim() == "" || textBox3.Text.ToString().Trim() == "")
            {
                MessageBoxForm objm = new MessageBoxForm("密码不能为空！", "温馨提示：",MessageBoxIcon.Error);
                objm.ShowDialog();
                return;
            }
            if (textBox2.Text.ToString().Trim() !=textBox3.Text.ToString().Trim())
            {
                MessageBoxForm objm = new MessageBoxForm("密码不一致！", "温馨提示：",MessageBoxIcon.Error);
                objm.ShowDialog();   
                 return;
            }
            #endregion
            ClientSystemServices.OfficeInfo objOfficeInfo = new ClientSystem.ClientSystemServices.OfficeInfo();

            objOfficeInfo.ofId = this.OfficeInfo.ofId;
            objOfficeInfo.ofPwd =BaseFunction.Encryptor.MD5EncryptStr(textBox2.Text.ToString().Trim());


            if (objClientSystemServices.UpdateOfficeInfo(this.OfficeInfo.ofPara1, objOfficeInfo))
            {
                MessageBoxForm objm = new MessageBoxForm("恭喜您，密码已修改！", "温馨提示：",MessageBoxIcon.Information);
                objm.ShowDialog();   
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                this.Close();
            }
            else
            {
                MessageBoxForm objm = new MessageBoxForm("连接服务器超时，请稍后再试！", "温馨提示：",MessageBoxIcon.Error);
                objm.ShowDialog();   
            }
        }

        private void ChangePwd_Load(object sender, EventArgs e)
        {
            button1.lblText.Text = "确定";
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
