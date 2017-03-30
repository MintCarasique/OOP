using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectPaint
{
    public abstract class Shape
    {
        public abstract Bitmap Draw(Bitmap bmp, int x, int y, int h, int w, Point first, Point second);
        public abstract void DrawE(int x, int y, int h, int w, Point first, Point second, PaintEventArgs e);

        public void Method()
        {
            C c = new C(); ;
            B b = new B();
            b = c;

        }
    }

    class A { }
    class B : A { }

    class C : B { }

    // C c;
    // B b = new A();
    // c = (C)b;

}



