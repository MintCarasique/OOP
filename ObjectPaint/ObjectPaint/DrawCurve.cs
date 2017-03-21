using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectPaint
{
    class DrawCurve : Shape
    {
        private Color clr;
        private int pWidth;

        public DrawCurve (Color clr, int pWidth)
        {
            this.clr = clr;
            this.pWidth = pWidth;
        }
        public override Bitmap Draw(Bitmap bmp, int x, int y, int h, int w, Point first, Point second)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            Point[] point = { new Point(first.X, first.Y), new Point(second.X, first.Y), new Point(second.X, second.Y), new Point(first.X, second.Y) };
            Graphics graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graph.DrawClosedCurve(pen, point);
            graph.Save();
            return bmp;
        }
        public override void DrawE(int x, int y, int h, int w, Point first, Point second, PaintEventArgs e)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            PointF[] point = { new Point(first.X, first.Y), new Point(second.X, first.Y), new Point(second.X, second.Y), new Point(first.X, second.Y) };
            e.Graphics.DrawClosedCurve(pen, point);
        }
    }
}
