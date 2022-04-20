using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRD.WinUI.Forms;
using ClientSystem.TTdetails;
using ClientSystem.China_Mobile;
using ClientSystem.ClientSystemServices;
using System.Diagnostics;

namespace ClientSystem
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class Main : CRD.WinUI.Forms.MainForm
    {
        public static readonly string c = System.Configuration.ConfigurationSettings.AppSettings["cc"].ToString().Trim();

        //营业厅完整信息
        public OfficeInfo OfficeInfo { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public Main()
        {
            //刷新当前的皮肤
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
        }
        #region//添加选项卡
        /// <summary>
        /// 添加一个选项卡
        /// </summary>
        /// <param name="MainTabControlKey">选项卡的键值</param>
        /// <param name="MainTabControlName">选项卡要显示的名称</param>
        /// <param name="objTabControl">要添加到的TabControl对象</param>
        /// <param name="objfrm">要被添加到选项卡的用户控件对象</param>
        private void addTabControl(string MainTabControlKey, string MainTabControlName, TabControl objTabControl, UserControl objfrm)
        {

            try
            {

                if (objTabControl.Controls.Contains(objTabControl.TabPages[MainTabControlName]) == false)
                {
                    //声明新的TabPage对象tabpage
                    TabPage tabpage = new TabPage();
                    //选项卡的名称
                    tabpage.Text = MainTabControlName;
                    tabpage.Name = MainTabControlKey;
                    ////添加tabPage标签图片
                    switch (tabpage.Text.ToString().Trim())
                    {
                        case "中国移动":
                            tabpage.ImageIndex = 1;
                            break;
                        case "中国联通":
                            tabpage.ImageIndex = 2;
                            break;
                        case "中国电信":
                            tabpage.ImageIndex = 3;
                            break;
                        case "信用卡还贷":
                            tabpage.ImageIndex = 4;
                            break;
                        case "生活缴费":
                            tabpage.ImageIndex = 5;
                            break;
                        case "游戏币充值":
                            tabpage.ImageIndex = 6;
                            break;
                        case "彩票卖场":
                            tabpage.ImageIndex = 7;
                            break;
                        case "机票订购":
                            tabpage.ImageIndex = 8;
                            break;
                        case "全国充值":
                            tabpage.ImageIndex = 9;
                            break;

                    }
                    //使得objfrm充满整个父窗体
                    objfrm.Dock = DockStyle.Fill;
                    //tabpage添加panel
                    Panel tabpanel = new Panel();
                    tabpanel.Dock = DockStyle.Fill;
                    tabpanel.Controls.Add(objfrm);
                    //在tabpage中添加panel
                    tabpage.Controls.Add(tabpanel);
                    //添加tabpage
                    objTabControl.Controls.Add(tabpage);
                    //使得tabpage为选中状态
                    objTabControl.SelectedTab = tabpage;
                }
                else
                {
                    //设为当前选中的选项
                    objTabControl.SelectedTab = objTabControl.TabPages[MainTabControlName];

                }
            }
            catch (Exception ex)
            {
                MessageBoxForm objm = new MessageBoxForm("添加选项卡时出错，请检查是否正确连接数据" + ex.Message.ToString());
                objm.ShowDialog();
            }
        }
        #endregion
        //Construction left
        public void bindtree()
        {
            treeView1.Nodes.Clear();
            int i = 0;
            ClientSystemServices.Service1SoapClient obj3g = new ClientSystem.ClientSystemServices.Service1SoapClient();
            for (int t = 0; t <= 6; t++)
            {
                DataTable BT = obj3g.BT(this.OfficeInfo.ofPara1, c, t.ToString());
                DataTable ST = obj3g.ST(this.OfficeInfo.ofPara1, c, t.ToString());
                DataRow[] drs = BT.Select("");
                foreach (DataRow r in drs)
                {
                    treeView1.Nodes.Add(r["TTname"].ToString());
                    treeView1.Nodes[0].Expand();
                    //填充节点的图标
                    switch (r["TTname"].ToString())
                    {
                        case "电话缴费":
                            treeView1.Nodes[i].ImageIndex = 0;
                            treeView1.Nodes[i].SelectedImageIndex = 0;
                            break;
                        case "信用卡还贷":
                            treeView1.Nodes[i].ImageIndex = 4;
                            treeView1.Nodes[i].SelectedImageIndex = 4;
                            break;
                        case "生活缴费":
                            treeView1.Nodes[i].ImageIndex = 5;
                            treeView1.Nodes[i].SelectedImageIndex = 5;
                            break;
                        case "游戏充值":
                            treeView1.Nodes[i].ImageIndex = 6;
                            treeView1.Nodes[i].SelectedImageIndex = 6;
                            break;
                        case "彩票卖场":
                            treeView1.Nodes[i].ImageIndex = 7;
                            treeView1.Nodes[i].SelectedImageIndex = 7;
                            break;
                        case "机票订购":
                            treeView1.Nodes[i].ImageIndex = 8;
                            treeView1.Nodes[i].SelectedImageIndex = 8;
                            break;

                        default:
                            break;
                    }
                    //填充树枝的内容
                    int j = 0;
                    DataRow[] drsr = ST.Select("TTid = " + r["TTid"].ToString());
                    foreach (DataRow rw in drsr)
                    {
                        treeView1.Nodes[i].Nodes.Add(rw["TIname"].ToString());
                        treeView1.Nodes[i].Nodes[j].ToolTipText = rw["TInote"].ToString();
                        treeView1.Nodes[i].Nodes[j].Name = rw["TIname"].ToString();
                        //填充树枝节点的图标
                        switch (rw["TIname"].ToString())
                        {
                            case "中国移动":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 1;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 1;
                                break;
                            case "中国联通":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 2;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 2;
                                break;
                            case "中国电信":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 3;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 3;
                                break;
                            case "信用卡还贷":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 4;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 4;
                                break;
                            case "生活缴费":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 5;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 5;
                                break;
                            case "游戏币充值":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 6;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 6;
                                break;
                            case "彩票卖场":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 7;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 7;
                                break;
                            case "机票订购":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 8;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 8;
                                break;
                            case "全国充值":
                                treeView1.Nodes[i].Nodes[j].ImageIndex = 9;
                                treeView1.Nodes[i].Nodes[j].SelectedImageIndex = 9;
                                break;

                            default:
                                break;
                        }
                        j++;
                    }
                    i++;
                }
            }
        }

        //Controls for the skin into the implementation of the
        public override void ChangeSkinColor(CRD.WinUI.SkinColor skinColor)
        {
            //设置皮肤
            base.ChangeSkinColor(skinColor);
            //Tree面板
            //Tree
            treeView1.BackColor = this.MainFormBorderColor;

            panel3.BackColor = this.MainFormBorderColor;
            panel4.BackColor = this.MainFormBorderColor;
            panel5.BackColor = this.MainFormBorderColor;
        }

        #region//页面初始化
        //Loaded
        private void Main_Load(object sender, EventArgs e)
        {
            //获取用户余额
            ClientSystemServices.Service1SoapClient user = new Service1SoapClient();
            label4.Text = user.OfficeFinanceServices(this.OfficeInfo.ofPara1, this.OfficeInfo.ofId, false).ToString().Trim();
            label2.Text = this.OfficeInfo.ofLogin;
            bindtree();
            //Tree面板
            //指定菜单
            this.SkinContextMenuStrip1 = contextMenuStrip2;
            //Tree
            treeView1.BackColor = this.MainFormBorderColor;

            //===Editor:沙建文
            //Edit Date:2009-12-09
            //MainTabControl初始化
            MainTabControl.ImageList = imageList2;

            //初始化ListView1==================================================================
            listView1.Columns.Add("", 90);
            listView1.Columns.Add("", 250);
            listView1.Columns.Add("", 80);
            ListViewItem item0 = new ListViewItem(new string[] { "【系统公告】", "综合缴费系统4.0已推出，请营业厅及时更新", "2009-12-09" });
            ListViewItem item1 = new ListViewItem(new string[] { "【中国移动】", "综合缴费系统4.0已推出，请营业厅及时更新", "2009-12-09" });
            ListViewItem item2 = new ListViewItem(new string[] { "【中国联通】", "综合缴费系统4.0已推出，请营业厅及时更新", "2009-12-09" });
            ListViewItem item3 = new ListViewItem(new string[] { "【中国电信】", "综合缴费系统4.0已推出，请营业厅及时更新", "2009-12-09" });
            listView1.Items.AddRange(new ListViewItem[] { item0, item1, item2, item3 });
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].ForeColor = Color.Red;
                listView1.Items[i].UseItemStyleForSubItems = false;
                listView1.Items[i].SubItems[2].ForeColor = Color.Gray;
            }
            //===================================================================================
            //初始化DataGridView1
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Insert(0, new string[] { "2009-12-11", "13592629663", "沙建文", "100.00" });
            dataGridView1.Rows.Insert(1, new string[] { "2009-12-11", "13592629663", "沙建文", "100.00" });
            //设置单元格及标题内容居中显示
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //创建单元格样式实例
            DataGridViewCellStyle cellstyle1 = new DataGridViewCellStyle();
            cellstyle1.ForeColor = Color.Red;
            //DataGridView中偶数列字体颜色为红色
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j % 2 == 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style = cellstyle1;
                    }
                }
            }
            //取消DataGridView1的默认选择
            dataGridView1.ClearSelection();
            //只显示DataGridView中水平单行边框
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

        }
        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        #region//点击Tree事件
        //button's click Tree
        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point ClickPoint = new Point(e.X, e.Y);
                    TreeNode CurrentNode = treeView1.GetNodeAt(ClickPoint);
                    if (CurrentNode != null)//判断你点的是不是一个节点
                    {
                        treeView1.SelectedNode = CurrentNode;//选中这个节点
                    }
                    //如果是上层节点则展开之
                    if (treeView1.SelectedNode.Parent == null)
                    {
                        if (treeView1.SelectedNode.IsExpanded == false)
                        {
                            treeView1.SelectedNode.Expand();
                        }
                    }
                    else
                    {
                        addTabControl(CurrentNode.Text, CurrentNode.Text, MainTabControl, new Mobile(OfficeInfo));
                    }
                }
            }
            catch (Exception)
            {
                MessageBoxForm objform = new MessageBoxForm("提交超时", "提示信息");
                objform.ShowDialog();
            }
        }
        #endregion

        #region//ContextMenuStrip2事件
        //In addition to all closed
        private void 除此之外全部关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                int i = 2;
                //获取当前选项卡的名称
                string clickPageName = this.MainTabControl.SelectedTab.Name;
                //如果选中的TabPage为“MyCenter”，则循环到剩下"1"个TabPage结束。否则剩余2个TabPage结束循环。
                if (clickPageName == "MyCenter")
                {
                    i = 1;
                }
                do
                {
                    if (this.MainTabControl.Controls.Count > i)
                    {
                        foreach (Control con in this.MainTabControl.Controls)
                        {
                            TabPage tabPage = (TabPage)con;
                            //将“MyCenter”和选中的TabPage留下，其余循环关闭。
                            if (tabPage.Name != clickPageName && tabPage.Name != "MyCenter")
                            {
                                this.MainTabControl.Controls.Remove((Control)con);
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                } while (1 == 1);
            }
            catch (Exception ex)
            {
                MessageBoxForm objf = new MessageBoxForm(ex.Message.ToString());
                objf.ShowDialog();
            }
        }
        //delete
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedTab.Text == "我的中心")
            {
                return;
            }
            else
            {
                try
                {
                    MainTabControl.TabPages.Remove(MainTabControl.SelectedTab);
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        #region//刷新报表
        //Editor:沙建文
        //Edited Date:2009-12-09
        //鼠标经过事件，改变鼠标指针形状（刷新今日报表）
        private void label9_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        //鼠标离开后恢复为系统指针形状（刷新今日报表）
        private void label9_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        //鼠标经过事件，改变鼠标指针形状（查看昨日报表）
        private void label10_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        //鼠标离开后恢复为系统指针形状（查看昨日报表）
        private void label10_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void listView1_MouseEnter(object sender, EventArgs e)
        {
            this.listView1.Cursor = Cursors.Hand;
        }

        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            this.listView1.Cursor = Cursors.Arrow;
        }
        #endregion

        //关闭Main窗口
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Listview中点击连接网站信息。
        private void listView1_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems[0].Text.Contains("移动"))
            {
                Process.Start("iexplore.exe", "http://www.chinamobile.com/");
            }
            else if (this.listView1.SelectedItems[0].Text.Contains("联通"))
            {
                Process.Start("iexplore.exe", "http://www.10010.com/");
            }
            else if (this.listView1.SelectedItems[0].Text.Contains("电信"))
            {
                Process.Start("iexplore.exe", "http://www.ct10000.com/");
            }
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePwd frm = new ChangePwd();
            frm.OfficeInfo = this.OfficeInfo;
            frm.Show();
        }

        /// <summary>
        /// 历史记录查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnhistory_Click(object sender, EventArgs e)
        {
            addTabControl("历史记录", "历史记录", MainTabControl, new History(OfficeInfo));

        }


    }
}
