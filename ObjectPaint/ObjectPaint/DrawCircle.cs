﻿using System.Drawing;
using System.Windows.Forms;

namespace ObjectPaint
{
    class DrawCircle : Shape
    {
        private Color clr;
        private int pWidth;
        public DrawCircle(Color clr, int pWidth)
        {
            this.clr = clr;
            this.pWidth = pWidth;
        }
        public override Bitmap Draw(Bitmap bmp, int x, int y, int h, int w, Point first, Point second)
        {
            Graphics graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            Rectangle rect = new Rectangle(x, y, h, w);
            graph.DrawEllipse(pen, rect);
            graph.Save();
            return bmp;
        }
        public override void DrawE(int x, int y, int h, int w, Point first, Point second, PaintEventArgs e)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            Rectangle rect = new Rectangle(x, y, h, w);
            e.Graphics.DrawEllipse(pen, rect);
        }
    }
}
