using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientSystem.ClientSystemServices;
using CRD.WinUI.Forms;

namespace ClientSystem
{
    public partial class History : CRD.WinUI.Forms.EnterFrom1
    {
        private ClientSystemServices.Service1SoapClient objcss=new Service1SoapClient(); 
        private OfficeInfo objoffceInFo = null;
        public History(OfficeInfo off)
        {
            objoffceInFo = off;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = null;

            List<historyorderInfo> tmpList = null;
            string funId = "";
            DateTime dts = new DateTime();
            DateTime dte=new DateTime();
            if (cbbfunction.Text != "" && dtstart.Value.ToString() != "")
            {
                funId = cbbfunction.SelectedValue.ToString();
                dts = dtstart.Value;
                dte = dtend.Value.Date.AddDays(1);
                if (dts > dte)
                {
                    
                    MessageBoxForm objm = new MessageBoxForm("请选择正确的查询日期！", "提示信息");
                    objm.ShowDialog();
                    return;
                    
                }
            }
            else
            {
                MessageBoxForm objm = new MessageBoxForm("请选择查询条件！", "提示信息");
                objm.ShowDialog();
                return;
            }
            try
            {
                dt = objcss.SelectHistoryOfOrder(objoffceInFo.ofPara1, objoffceInFo.ofId.ToString(), funId, dts, dte);
            }
            catch (Exception)
            {
                
               
            }
            if (dt == null)
            {
                MessageBoxForm objm = new MessageBoxForm("没有找到相关数据！", "提示信息");
                objm.ShowDialog();
                return;
            }
            tmpList = ToReceiveDataEventArgs(dt);
            dgvhistory.DataSource = tmpList;
            moneydatabind();
        }

        private void History_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            try
            {
                cbbfunction.DisplayMember = "fiName";
                cbbfunction.ValueMember = "fiId";
                dt = objcss.SelectFunctionInfo(objoffceInFo.ofPara1);
                cbbfunction.DataSource = dt;
            }
            catch (Exception )
            {
                
            }
       }
        private void moneydatabind()
        {
            if (dgvhistory.Rows.Count > 0)
            {   
                decimal money=0;
                decimal allmoney = 0;
                for (int i = 0; i < dgvhistory.Rows.Count; i++)
                {
                    if (dgvhistory.Rows[i].Cells["状态"].Value.ToString() == "充值成功" || dgvhistory.Rows[i].Cells["状态"].Value.ToString() == "冲正失败")
                    {
                        if (dgvhistory.Rows[i].Cells["交易金额"].Value.ToString().Contains("元"))
                        {
                            money += Convert.ToDecimal(dgvhistory.Rows[i].Cells["交易金额"].Value.ToString().Substring(0, dgvhistory.Rows[i].Cells["交易金额"].Value.ToString().IndexOf("元")));
                        }
                        else
                            money += Convert.ToDecimal(dgvhistory.Rows[i].Cells["交易金额"].Value.ToString());
                        allmoney += money;
                    }
                    else if (dgvhistory.Rows[i].Cells["状态"].Value.ToString() == "提交充值" || dgvhistory.Rows[i].Cells["状态"].Value.ToString() == "正在充值" || dgvhistory.Rows[i].Cells["状态"].Value.ToString() == "提交冲正" || dgvhistory.Rows[i].Cells["状态"].Value.ToString() == "充值失败")
                    {
                        if (dgvhistory.Rows[i].Cells["交易金额"].Value.ToString().Contains("元"))
                        {
                            allmoney += Convert.ToDecimal(dgvhistory.Rows[i].Cells["交易金额"].Value.ToString().Substring(0, dgvhistory.Rows[i].Cells["交易金额"].Value.ToString().IndexOf("元")));
                        }
                        else
                            allmoney += Convert.ToDecimal(dgvhistory.Rows[i].Cells["交易金额"].Value.ToString());
                    }
                    else
                    {
                    }
                }
                lallmoney.Text = allmoney.ToString()+"元";
                lmoney.Text = money.ToString()+"元";
            }
        }

        /// <summary>
        /// 获取历史记录信息并将其转换为统一信息类
        /// </summary>
        /// <param name="mrlist">历史信息</param>
        /// <returns></returns>
        private List<historyorderInfo> ToReceiveDataEventArgs(DataTable dt)
        {
            List<historyorderInfo> rtlist = new List<historyorderInfo>();
            try
            {
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rtlist.Add(new historyorderInfo()
                        {
                            hid = dt.Rows[i]["orId"].ToString(),
                            hnumber = dt.Rows[i]["orTel"].ToString(),
                            hmoney = dt.Rows[i]["orMoney"].ToString(),
                            hallmoney=dt.Rows[i]["orRementMoney"].ToString(),
                            htime = Convert.ToDateTime(dt.Rows[i]["orTime"].ToString()),
                            hstate = dt.Rows[i]["orState"].ToString(),
                            hname = dt.Rows[i]["funName"].ToString(),
                            htype=dt.Rows[i]["ortype"].ToString(),
                            operate = "查看"

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return rtlist;
        }

        //历史记录信息类
        public class historyorderInfo : EventArgs
        {
            public DateTime htime { get; set; }

            public string hid { get; set; }

            public string hstate { get; set; }

            public string hnumber { get; set; }

            public string hmoney { get; set; }

            public string hallmoney { get; set; }

            public string hname { get; set; }

            public string htype { get; set; }

            public string operate { get; set; }

        }

        private void dgvhistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                historydialog spd = new historydialog(
                    dgvhistory.Rows[e.RowIndex].Cells["编号"].Value.ToString(),
                    dgvhistory.Rows[e.RowIndex].Cells["业务"].Value.ToString(),
                    dgvhistory.Rows[e.RowIndex].Cells["号码"].Value.ToString(),
                    dgvhistory.Rows[e.RowIndex].Cells["交易金额"].Value.ToString(),
                    dgvhistory.Rows[e.RowIndex].Cells["时间"].Value.ToString(),
                    dgvhistory.Rows[e.RowIndex].Cells["状态"].Value.ToString(),
                    dgvhistory.Rows[e.RowIndex].Cells["余额"].Value.ToString(),
                    dgvhistory.Rows[e.RowIndex].Cells["返利状态"].Value.ToString()
                    );
                spd.ShowDialog();
            }
        }
    }
}
