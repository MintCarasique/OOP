using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectPaint
{
    public partial class mainForm : Form
    {
        private Bitmap Bmp;
        public List<Shape> shp = new List<Shape>();
        private bool press = false;
        private Point one;
        private Point two;
        private Color Current = Color.Black;
        private Shape figure;
        private int x, y, w, h;
        private int penWidth = 1;

        private void shapePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (figure != null && press)
            {
                two = e.Location;
                if (figure is DrawPencil)
                {                    
                    figure.Draw(Bmp, x, y, h, w, one, two);
                    shapePictureBox.Image = Bmp;
                    one = two;
                }
                shapePictureBox.Refresh();
            }
        }

        private void shapePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (figure != null && press)
            {                
                if (!(figure is DrawPencil))
                {
                    countCanvasPoints();
                    figure.DrawE(x, y, h, w, one, two, e);
                }
            }
        }

        private void pencilButton_Click(object sender, EventArgs e)
        {
            DrawPencil temp = new DrawPencil(Current, penWidth);
            this.figure = temp;

            //string temp1 = "ghu";
            //int figure1 = temp1;
        }

        private void shapePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                press = false;
                Bmp = figure.Draw(Bmp, x, y, h, w, one, two);
                shapePictureBox.Image = Bmp;
            }
        }

        private void shapePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                press = true;
                one = e.Location;
            }
        }

        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            penWidth = widthTrackBar.Value;            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            shapePictureBox.Image = null;
            Bmp.Dispose();
            shp.Clear();
            Bitmap bmp = new Bitmap(shapePictureBox.Width, shapePictureBox.Height);
            Bmp = bmp;
        }

        private void lineButton_Click_1(object sender, EventArgs e)
        {
            DrawStraightLine temp = new DrawStraightLine(Current, penWidth);
            this.figure = temp;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            figure = new DrawRectangle(Current, penWidth);
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            DrawCircle temp = new DrawCircle(Current, penWidth);
            this.figure = temp;
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            DrawTriangle temp = new DrawTriangle(Current, penWidth);
            this.figure = temp;
        }

        private void curveButton_Click(object sender, EventArgs e)
        {
            DrawCurve temp = new DrawCurve(Current, penWidth);
            this.figure = temp;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }
        
        public mainForm()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(shapePictureBox.Width, shapePictureBox.Height);
            Bmp = bmp;
        }
        public void countCanvasPoints()
        {
            x = Math.Min(one.X, two.X);
            y = Math.Min(one.Y, two.Y);
            h = Math.Abs(one.X - two.X);
            w = Math.Abs(one.Y - two.Y);            
        }
    }
}
