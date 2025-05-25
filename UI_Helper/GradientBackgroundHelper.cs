using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.UI_Helper
{
    internal class GradientBackgroundHelper
    {
        public static void DrawDefaultGradient(object sender, PaintEventArgs e)
        {
            if (sender is Control control)
            {
                Rectangle rect = control.ClientRectangle;

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect,
                    ColorTranslator.FromHtml("#FA4848"), 
                    ColorTranslator.FromHtml("#820000"),
                    LinearGradientMode.Vertical          
                ))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }

        public static void DrawGradientOnControl(Control ctrl, PaintEventArgs e)
        {
            Rectangle rect = ctrl.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                ColorTranslator.FromHtml("#FA4848"),
                ColorTranslator.FromHtml("#820000"),
                LinearGradientMode.Vertical
            ))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        public static void DrawRightPanelGradient(Control ctrl, PaintEventArgs e)
        {
            Rectangle rect = ctrl.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                ColorTranslator.FromHtml("#FFFFFF"),
                ColorTranslator.FromHtml("#FFE4D4"),
                LinearGradientMode.Vertical
            ))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        // Optional: gradient tùy chọn màu
        public static void DrawCustomGradient(Control ctrl, PaintEventArgs e, string colorStartHex, string colorEndHex, LinearGradientMode direction)
        {
            Rectangle rect = ctrl.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                ColorTranslator.FromHtml(colorStartHex),
                ColorTranslator.FromHtml(colorEndHex),
                direction
            ))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }
    }
}
