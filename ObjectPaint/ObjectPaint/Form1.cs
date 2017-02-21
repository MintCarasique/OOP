using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objectPaint;

namespace ObjectPaint
{
    public partial class mainForm : Form
    {
        private Bitmap Bmp;
        public mainForm()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(shapePictureBox.Width, shapePictureBox.Height);
            Bmp = bmp;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            LineDrawer line = new LineDrawer();
            Bmp = line.Draw(Bmp);
            shapePictureBox.Image = Bmp;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            CircleDrawer circle = new CircleDrawer();
            Bmp = circle.Draw(Bmp);
            shapePictureBox.Image = Bmp;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            SquareDrawer square = new SquareDrawer();
            Bmp = square.Draw(Bmp);
            shapePictureBox.Image = Bmp;
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            TriangleDrawer triangle = new TriangleDrawer();
            Bmp = triangle.Draw(Bmp);
            shapePictureBox.Image = Bmp;
        }

        private void pentagonButton_Click(object sender, EventArgs e)
        {
            PentagonDrawer pentagon = new PentagonDrawer();
            Bmp = pentagon.Draw(Bmp);
            shapePictureBox.Image = Bmp;
        }

        private void hexagonButton_Click(object sender, EventArgs e)
        {
            HexagonDrawer hexagon = new HexagonDrawer();
            Bmp = hexagon.Draw(Bmp);
            shapePictureBox.Image = Bmp;
        }
    }
}
