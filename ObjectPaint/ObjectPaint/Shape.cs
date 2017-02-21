﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace objectPaint
{
   public abstract class Shape
    {
        public abstract Bitmap Draw(Bitmap bmp);
    }

    class LineDrawer : Shape
    {
        public override Bitmap Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 10, 10, 150, 200);
            return bmp;

        }
    }

    class CircleDrawer : Shape
    {
        public override Bitmap Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Green);
            Rectangle rect = new Rectangle(100, 10, 100, 100);
            graph.DrawEllipse(pen, rect);
            return bmp;
        }
    }

    class SquareDrawer : Shape
    {
        public override Bitmap Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue);
            graph.DrawRectangle(pen,300, 10, 100, 100);
            return bmp;
        }
    }

    
    class TriangleDrawer : Shape
    {

        public override Bitmap Draw(Bitmap bmp)
        {
            Pen pen = new Pen(Color.Red);
            Point[] trianglePoints = { new Point(200, 10), new Point(150, 150), new Point(300, 150) };

            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawPolygon(pen, trianglePoints);

            return bmp;
        }
    }

    class PentagonDrawer : Shape
    {

        public override Bitmap Draw(Bitmap bmp)
        {
            Pen pen = new Pen(Color.DarkCyan);
            Point[] point = { new Point(300, 10), new Point(210, 100), new Point(230, 200), new Point(330, 200), new Point(400, 100) };

            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawPolygon(pen, point);

            return bmp;
        }
    }

    class HexagonDrawer : Shape
    {
        public override Bitmap Draw(Bitmap bmp)
        {
            Pen pen = new Pen(Color.Violet);
            Point[] point = { new Point(10, 10), new Point(100, 10), new Point(300, 250), new Point(400, 250), new Point(20, 100), new Point(150, 200) };

            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawPolygon(pen, point);

            return bmp;

        }
    }
  }
    

    
