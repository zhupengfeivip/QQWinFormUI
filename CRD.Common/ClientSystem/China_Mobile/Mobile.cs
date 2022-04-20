using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRD.WinUI.Forms;
using System.Threading;
using BaseFunction;
using ClientSystem.ClientSystemServices;

namespace ClientSystem.China_Mobile
{
    public partial class Mobile : CRD.WinUI.Forms.EnterFrom1
    {
        public OfficeInfo objoffceInFo = null;
        private int result;
        private Image image1 = null;
        //刷新数据的方法

        private ClientSystemServices.Service1SoapClient objcss = new ClientSystem.ClientSystemServices.Service1SoapClient();

        private  ClientSystem.ClientSystemServices.OrderMobile objordermobile = new ClientSystem.ClientSystemServices.OrderMobile();

        public void MobileRef()
        {
            try
            {
                //ClientSystemServices.Service1SoapClient objcss = new ClientSystem.ClientSystemServices.Service1SoapClient();
                DataTable table = objcss.selectSelectMobileByID(objoffceInFo.ofPara1, result.ToString().Trim());
                if (table.Rows.Count != 0)
                {
                    label7.Text = table.Rows[0]["scmName"].ToString().Trim();
                    if (label7.Text.ToString().Trim().Length > 4)
                    {
                        string strText = label7.Text.ToString().Trim();
                        label7.Text = label7.Text.ToString().Trim().Substring(0, 4);
                        toolTip1.SetToolTip(label7, strText.ToString().Trim());
                    }

                    label8.Text = table.Rows[0]["scmRemainAmount"].ToString().Trim();
                    label7.Visible = true;
                    label8.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }
        public Mobile(OfficeInfo objoff)
        {
            objoffceInFo = objoff;
            InitializeComponent();
        }

        //加载
        private void Mobile_Load(object sender, EventArgs e)
        {
            btnCard.lblText.Text = "充值卡";
            btnSelectNumber.lblText.Text = "手机选号";
            listView1.Columns.Add("编号", 40);
            listView1.Columns.Add("号码", 80);
            listView1.Columns.Add("充值金额", 80);
            listView1.Columns.Add("时间", 220);
            
            listView1.GridLines = true; //显示表格线
            listView1.View = View.Details;//显示表格细节
        }

        //查询余额
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (checkmobilenum() == false)
                return;

            //if (txtMobileNumber.Text.ToString().Trim() != textBox2.Text.ToString().Trim())
            //{
            //    MessageBoxForm objm = new MessageBoxForm("两次输入的号码不对应", "提示信息");
            //    objm.ShowDialog();
            //    return;
            //}

            //if (txtMobileNumber.Text.ToString().Trim() == null || txtMobileNumber.Text.ToString().Trim() == ""
            //    || textBox2.Text.ToString().Trim() == null || textBox2.Text.ToString().Trim() == "")
            //{
            //    MessageBoxForm objm = new MessageBoxForm("请输入号码", "提示信息");
            //    objm.ShowDialog();
            //    return;
            //}

            //if (PageValidate.isMobile(txtMobileNumber.Text.ToString().Trim()) == false)
            //{
            //    MessageBoxForm objm = new MessageBoxForm("你输入的不是正确的移动号码", "提示信息");
            //    objm.ShowDialog();
            //    return;
            //}

            //ClientSystemServices.Service1SoapClient objcss = new ClientSystem.ClientSystemServices.Service1SoapClient();
            ClientSystem.ClientSystemServices.SelectMobile objselectmobile = new ClientSystem.ClientSystemServices.SelectMobile();
            objselectmobile.scmOid = objoffceInFo.ofId;

            if (BaseFunction.Functions.IsNumeric(txtMobileNumber.Text.ToString().Trim()))
            {
                objselectmobile.scmNumber = txtMobileNumber.Text.ToString().Trim();
            }
            else
            {
                MessageBoxForm objm = new MessageBoxForm("号码必须是数字", "提示信息");
                objm.ShowDialog();
                return;
            }

            //生成一个对象添加记录
            objselectmobile.scmType = 1;
            objselectmobile.scmState = 7;
            objselectmobile.scSelectStart = "0";
            result = objcss.AddSystemModel(objoffceInFo.ofPara1, objselectmobile);
            if (result != 1)
            {
                btnSelect.Enabled = false;
                image1 = btnSelect.BackgroundImage;
                btnSelect.BackgroundImage = null;
                timer2.Enabled = true;
                button8.lblText.Text = "刷新";
                button8.Visible = true;
            }

            #region//号码归属地查询

            /// <summary>
            /// 获取手机号码归属地信息
            /// 函数原型：
            /// bool Query(string Mobile, out string Province, out string City, out string AreaCode, out string PostCode, out string Corp, 
            /// out string Card);
            /// 参数：
            /// Mobile: 待查询的手机号码。
            /// Province: 返回手机号码归属地的省份。
            /// City: 返回手机号码归属地的城市。
            /// AreaCode: 返回手机号码归属地的区号。
            /// PostCode: 返回手机号码归属地的邮编。
            /// Corp: 返回所属运营商。
            /// Card: 返回所属卡类型。
            /// 返回值：
            /// 返回 bool 值，表示用户输入的号码是否可识别。
            /// </summary>

            //号码归属地查询
            MobileService.MobileSoapClient objmobileservices = new ClientSystem.MobileService.MobileSoapClient();
            // 声明保存归属信息的变量 省份，城市，区号，邮编，所属运营商，属卡类型
            string city, province, areacode, postcode, corp, card;
            // 查询
            bool bQuery = objmobileservices.Query(txtMobileNumber.Text.ToString().Trim(), out province, out city, out areacode, out postcode, out corp, out card);

            if (bQuery)
            {
                label3.Text = province + " " + city;
                label9.Text = corp + card;
                label10.Text = areacode;
                label11.Text = postcode;
                label3.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
            }
            #endregion
        }

        //充值
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //生成移动交费订单信息表ordermobile对象
            //ClientSystem.ClientSystemServices.OrderMobile objordermobile = new ClientSystem.ClientSystemServices.OrderMobile();

            if (checkmobilenum() == false)
                return;

            if (BaseFunction.Functions.IsNumeric(txtMobileNumber.Text.ToString().Trim()))
            {
                objordermobile.ormNumber = txtMobileNumber.Text.ToString().Trim();
            }
            else
            {
                MessageBoxForm objm = new MessageBoxForm("号码必须是数字", "提示信息");
                objm.ShowDialog();
                return;
            }
            if (comboBox1.Text.ToString() == "")
                return;
            int  money = Convert.ToInt32(comboBox1.Text.ToString());
            decimal allmoney = 0;

            try
            {
                //查询用户余额
                allmoney = objcss.OfficeFinanceServices(objoffceInFo.ofPara1, objoffceInFo.ofId, false);
            }
            catch (Exception)
            {
                
                throw;
            }
            //客户余额验证
            if(Convert.ToDecimal(money)>allmoney) 
            {
                MessageBoxForm objm = new MessageBoxForm("您的余额不足，无法提交！", "提示信息");
                objm.ShowDialog();
                return;
            }
            //查询条数
            objordermobile.ormId = getnumsofordermobile();
            if (objordermobile.ormId == 0)
            {
                MessageBoxForm objm = new MessageBoxForm("业务ID查找失败，请重新提交" , "提示信息");
                objm.ShowDialog();
                return;
            }
            //客户端用户ID
            objordermobile.ormOid = objoffceInFo.ofId;
            
            //生成一个ordermobile添加对象
            objordermobile.ormType = 2;
            objordermobile.ormState = 1;
            objordermobile.ormPayPort ="0" ;
            //标识是否已经返利1未返
            objordermobile.ormNote3 = "1";
            //业务返点查找
            try
            {
                objordermobile.ormRebate = objcss.GetOfficeRebate(objoffceInFo.ofPara1, objoffceInFo.ofId, 0);
            }
            catch (Exception)
            {
                throw;
            }

            //if (objordermobile.ormRebate == 0)
            //{
            //    MessageBoxForm objm = new MessageBoxForm("业务返点查找失败，请重新提交", "提示信息");
            //    objm.ShowDialog();
            //    return;
            //}
            objordermobile.ormPayAmount=money;
            objordermobile.ormRemainAmount = allmoney;
            int id = 0;
            try
            {
                id = objcss.AddOrderMobileModel(objoffceInFo.ofPara1, objordermobile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (id == 0)
            {
                MessageBoxForm objm = new MessageBoxForm("信息提交失败，请重新提交", "提示信息");
                objm.ShowDialog();
                return;
            }
            else
            {
                MessageBoxForm objm = new MessageBoxForm("信息成功提交，请等待服务器响应", "提示信息");
                objm.ShowDialog();
                OrderMobileInfoRef(objordermobile.ormId);
            }
        }

        //移动交费信息加载的方法
        public void OrderMobileInfoRef(int ormId)
        {
            try
            {
                //ClientSystemServices.Service1SoapClient objcss = new ClientSystem.ClientSystemServices.Service1SoapClient();
                DataTable table = objcss.selectOrderMobileByID(objoffceInFo.ofPara1, ormId.ToString());
                if (table.Rows.Count != 0)
                {
                    ListViewItem[] listViewItem = new ListViewItem[1];
                    listViewItem[0] = new ListViewItem(new string[] { table.Rows[0]["ormId"].ToString(), table.Rows[0]["ormNumber"].ToString(), table.Rows[0]["ormPayAmount"].ToString() + "元", table.Rows[0]["ormSubTime"].ToString() });
                    listView1.Items.AddRange(listViewItem);
                    //Button btn=new Button();
                    //btn.Text="查看";
                    //btn.Name=table.Rows[0]["ormId"].ToString();
                    //btn.Click += new EventHandler(btn_Click);
                    //ListViewItem item = new ListViewItem("查看",btn);
                }
                
            }
            catch (Exception)
            {

            }
        }

        //刷新
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            timer3.Enabled = true;
            MobileRef();
        }


        int i = 10;
        int j = 1;
        //查询按钮
        private void timer2_Tick(object sender, EventArgs e)
        {
            btnSelect.Text = i.ToString();
            i--;
            if (i == -1)
            {
                timer2.Enabled = false;
                btnSelect.Enabled = true;
                btnSelect.BackgroundImage = image1;
                btnSelect.Text = "";
                i = 10;
            }
        }

        //刷新按钮
        private void timer3_Tick(object sender, EventArgs e)
        {
            button8.lblText.Text = j.ToString();
            j--;
            if (j == -1)
            {
                button8.Enabled = true;
                timer3.Enabled = false;
                button8.lblText.Text = "刷新";
                j = 1;
            }
        }
        //信息验证方法
        private bool checkmobilenum()
        {
            if (txtMobileNumber.Text.ToString().Trim() != textBox2.Text.ToString().Trim())
            {
                MessageBoxForm objm = new MessageBoxForm("两次输入的号码不对应", "提示信息");
                objm.ShowDialog();
                return false;
            }

            if (txtMobileNumber.Text.ToString().Trim() == null || txtMobileNumber.Text.ToString().Trim() == ""
                || textBox2.Text.ToString().Trim() == null || textBox2.Text.ToString().Trim() == "")
            {
                MessageBoxForm objm = new MessageBoxForm("请输入号码", "提示信息");
                objm.ShowDialog();
                return false;
            }

            if (PageValidate.isMobile(txtMobileNumber.Text.ToString().Trim()) == false)
            {
                MessageBoxForm objm = new MessageBoxForm("你输入的不是正确的移动号码", "提示信息");
                objm.ShowDialog();
                return false;
            }
           
            return true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
        }
        private int getnumsofordermobile()
        {

            //生成客户端WebService对象
            //ClientSystemServices.Service1SoapClient objcss = new ClientSystem.ClientSystemServices.Service1SoapClient();
            return objcss.getnumsofordermobile(objoffceInFo.ofPara1,0);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Text != "")
                {

                    int j = 0;
                    char[] chars = comboBox1.Text.ToCharArray();
                    for (int i = 0; i < comboBox1.Text.Length; i++)
                    {

                        if (chars[i] == '.')
                            j++;
                    }
                    if (j > 0)
                    {
                        MessageBoxForm objm = new MessageBoxForm("输入字符不正确", "提示信息");
                        objm.ShowDialog();
                        comboBox1.Text = "";
                        return;
                    }
                    if (Convert.ToInt32(comboBox1.Text.ToString().Trim()) == 0)
                    {
                        MessageBoxForm objm = new MessageBoxForm("输入不能为0", "提示信息");
                        return;
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string AstrictChar = "0123456789";//可以输入的字符

            //「BackSpace」「Delete」后退键正常删除操作
            if ((Keys)(e.KeyChar) == Keys.Back || (Keys)(e.KeyChar) == Keys.Delete)
            {
                return;
            }
            //「Ctrl+C」(3)「Ctrl+X」(24)特殊组合键正常
            //「Ctrl+Z」(26) 撤消组合键正常
            if ((e.KeyChar == 3) || (e.KeyChar == 24) || (e.KeyChar == 26))
            {
                return;
            }

            //允许输入的字符外
            if (AstrictChar.IndexOf(e.KeyChar.ToString()) == -1)
            {

                e.Handled = true;

                return;
            }
        }
        //private decimal getRebateofordermobile()
        //{
            
        //    //生成客户端WebService对象
        //    ClientSystemServices.Service1SoapClient objcss = new ClientSystem.ClientSystemServices.Service1SoapClient();
            
        //    return objcss.getrebateofordermobile(objoffceInFo.ofPara1,objoffceInFo.ofId.ToString(),"0");
        //}
    }
}
