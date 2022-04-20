﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CRD.WinUI.Misc
{
   
    public class ToolStripRenderer : ToolStripProfessionalRenderer
    {
        public ToolStripRenderer()
            : base()
        {

        }

        public ToolStripRenderer(ProfessionalColorTable ColorTable)
            : base(ColorTable)
        {
            ColorTable = new ProfessionalColorTable();
            ColorTable.UseSystemColors = true;

        }

        protected override void Initialize(ToolStrip toolStrip)
        {
            base.Initialize(toolStrip);

        }
        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            SolidBrush checkBrush = new SolidBrush(Color.Black);
            Font font = new Font(e.Item.Font, FontStyle.Bold | FontStyle.Italic);
            e.Graphics.DrawString("√", font, checkBrush, 5, 5);
        }

        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
        {

            //   base.OnRenderItemBackground(e);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            if ((e.ToolStrip is ContextMenuStrip) ||
                 (e.ToolStrip is ToolStripDropDownMenu))
            {
                using (Pen lightPen = new Pen(Color.FromArgb(208, 234, 247)), darkPen = new Pen(Color.FromArgb(219, 238, 252)))
                {
                    DrawSeparator(e.Graphics, e.Vertical, new Rectangle(0, 0, e.Item.Width - 5, 3), lightPen, darkPen, 31, (e.ToolStrip.RightToLeft == RightToLeft.Yes));
                }
            }
            else if (e.ToolStrip is System.Windows.Forms.StatusStrip)
            {
                using (Pen lightPen = new Pen(ColorTable.SeparatorLight), darkPen = new Pen(ColorTable.SeparatorDark))
                {
                    DrawSeparator(e.Graphics, e.Vertical, e.Item.Bounds, lightPen, darkPen, 0, false);
                }
            }
            else
            {
                base.OnRenderSeparator(e);
            }
        }

        private void DrawSeparator(Graphics g, bool vertical, Rectangle rect, Pen lightPen, Pen darkPen, int horizontalInset, bool rtl)
        {
            if (vertical)
            {
                int l = rect.Width / 2;
                int t = rect.Y;
                int b = rect.Bottom;
                g.DrawLine(darkPen, l, t, l, b);
                g.DrawLine(lightPen, l + 1, t, l + 1, b);
            }
            else
            {
                int y = rect.Height / 2;
                int l = rect.X + (rtl ? 0 : horizontalInset);
                int r = rect.Right - (rtl ? horizontalInset : 0);

                g.DrawLine(darkPen, l, y, r, y);
                g.DrawLine(lightPen, l, y + 1, r, y + 1);
            }
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderMenuItemBackground(e);
            if (e.Item.Selected)
            {
                e.Item.ForeColor = Color.White;

                e.Graphics.FillRectangle(new SolidBrush(Shared.MainForm.MainFormBackGroundColor2), new Rectangle(5, 1, e.Item.Width - 2 * SystemInformation.BorderSize.Width - 6, e.Item.Height - 2));
                e.Graphics.DrawPath(new Pen(Shared.MainForm.MainFormBackGroundColor), CreateRoundedRectanglePath(new Rectangle(4, 1, e.Item.Width - 2 * SystemInformation.BorderSize.Width - 5, e.Item.Height - 2), 3));
            }
            else
            {
                e.Item.ForeColor = Color.Black;

            }
            // base.OnRenderMenuItemBackground(e);


        }

        internal static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }
    }
}
