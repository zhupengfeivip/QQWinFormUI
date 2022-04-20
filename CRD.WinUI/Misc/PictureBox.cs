using System;
using System.Collections.Generic;

using System.Text;

namespace CRD.WinUI.Misc
{
   public class PictureBox:System.Windows.Forms.PictureBox
    {
       public PictureBox()
           : base()
       {
           this.BackColor = System.Drawing.Color.Transparent;
       }

       protected override void WndProc(ref System.Windows.Forms.Message m)
       {
           base.WndProc(ref m);
           if (m.Msg == 0xf || m.Msg == 0x133)
           {
               Shared.ResetBorderColor(m, this);
           }
       }
    }
}
