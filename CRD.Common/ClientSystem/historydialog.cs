using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientSystem
{
    public partial class historydialog :CRD.WinUI.Forms.EntryForm
    {
        public historydialog(string laid, string laname, string lanum, string lamoney, string latime, string lastate, string laallmoney, string latype)
        {
            InitializeComponent();
            this.lid.Text = laid.ToString();
            this.lname.Text = laname.ToString();
            this.lmoney.Text = lamoney;
            this.lallmoney.Text = laallmoney;
            this.lstate.Text = lastate;
            this.ltype.Text = latype;
            this.ltime.Text = latime.ToString();
            this.lnum.Text = lanum.ToString();
            this.Text = "历史记录查询";
        }

        private void historydialog_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
