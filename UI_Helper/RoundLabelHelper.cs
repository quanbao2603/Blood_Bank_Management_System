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
    internal class RoundLabelHelper
    {
        public static void Apply(Label label, int radius)
        {
            if (label.Width == 0 || label.Height == 0) return;

            GraphicsPath path = new GraphicsPath();
            Rectangle rect = label.ClientRectangle;
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90); // top-left
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90); // top-right
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90); // bottom-right
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90); // bottom-left
            path.CloseFigure();

            label.Region = new Region(path);
        }
    }
}
