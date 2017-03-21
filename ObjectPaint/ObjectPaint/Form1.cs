using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private Shape temp;
        private int x, y, w, h;
        private int penWidth = 1;
        private void shapePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp != null && press)
            {
                two = e.Location;
                if (temp is DrawPencil)
                {
                    temp.Draw(Bmp, x, y, h, w, one, two);
                    shapePictureBox.Image = Bmp;
                    one = two;
                }
                shapePictureBox.Refresh();
            }
        }

        private void shapePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (temp != null && press)
            {
                if (!(temp is DrawPencil))
                {
                    countCanvasPoints();
                    temp.DrawE(x, y, h, w, one, two, e);
                }
            }
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            DrawPencil temp = new DrawPencil(Current, penWidth);
            this.temp = temp;
        }

        private void shapePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (temp != null)
            {
                press = false;
                Bmp = temp.Draw(Bmp, x, y, h, w, one, two);
                shapePictureBox.Image = Bmp;
            }
        }

        private void shapePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (temp != null)
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
