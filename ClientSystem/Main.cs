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

namespace ClientSystem
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class Main : CRD.WinUI.Forms.MainForm
    {
        
        public static readonly string c = System.Configuration.ConfigurationSettings.AppSettings["cc"].ToString().Trim();

        /// <summary>
        /// 构造方法
        /// </summary>
        public Main()
        {
            //刷新当前的皮肤
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
        }

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
                if (objTabControl.TabPages.ContainsKey(MainTabControlKey.ToString().Trim()) == false)
                {
                    //声明一个选项卡对象
                    TabPage tabPage = new TabPage();
                    tabPage.ImageIndex = 1;
                    //选项卡的名称
                    tabPage.Name = MainTabControlKey;
                    //选项卡的文本
                    tabPage.Text = MainTabControlName;
                    //向选项卡集合添加新选项卡
                    objTabControl.Controls.Add(tabPage);
                    objfrm.Dock = DockStyle.Fill;
                    //子窗体显示
                    objfrm.Show();
                    //子窗体大小设置为选项卡大小
                    objfrm.Size = tabPage.Size;
                    //将子窗体添加到选项卡中
                    tabPage.Controls.Add(objfrm);
                    //设置当前选项卡为新增选项卡
                    objTabControl.SelectTab(MainTabControlKey);
                }
                else
                {
                    //设为当前选中的选项
                    objTabControl.SelectTab(MainTabControlKey);
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm objm = new MessageBoxForm("添加选项卡时出错，请检查是否正确连接数据" + ex.Message.ToString());
                objm.ShowDialog();
            }
        }

        //Construction left
        public void bindtree()
        {
            
        }

        //Controls for the skin into the implementation of the
        public override void ChangeSkinColor(CRD.WinUI.SkinColor skinColor)
        {
            //设置皮肤
            base.ChangeSkinColor(skinColor);
            //Tree面板
            //Tree
            treeView1.BackColor = this.MainFormBorderColor;
            panel1.BackColor = this.MainFormBorderColor;
            panel3.BackColor = this.MainFormBorderColor;
            panel4.BackColor = this.MainFormBorderColor;
            panel5.BackColor = this.MainFormBorderColor;
        }

        //Loaded
        private void Main_Load(object sender, EventArgs e)
        {

            //清空控件
            this.MainTabControl.TabPages.Clear();
            //绘制的方式OwnerDrawFixed表示由窗体绘制大小也一样
            this.MainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
           
            //Tree面板

            //指定菜单
            this.SkinContextMenuStrip1 = contextMenuStrip2;
            //Tree
            treeView1.BackColor = this.MainFormBorderColor;
           
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //delete
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainTabControl.TabPages.Remove(MainTabControl.SelectedTab);
            }
            catch (Exception)
            {

            }
        }

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
                        addTabControl(CurrentNode.Text, CurrentNode.Text, MainTabControl, new UserControl1());

                    }
                }
            }
            catch (Exception)
            {
                MessageBoxForm objform = new MessageBoxForm("提交超时", "提示信息");
                objform.ShowDialog();
            }
        }

        //In addition to all closed
        private void 除此之外全部关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TabPage objtabpage = MainTabControl.TabPages[MainTabControl.SelectedIndex];
                MainTabControl.TabPages.Clear();
                MainTabControl.TabPages.Add(objtabpage);
            }
            catch (Exception ex)
            {
                MessageBoxForm objf = new MessageBoxForm(ex.Message.ToString());
                objf.ShowDialog();
            }
        }

       
    }
}
