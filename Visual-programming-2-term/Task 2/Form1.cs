using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgaanyanTask2
{
    public partial class Form1 : Form
    {
        static int x = 800, y = 1100;
        static int speed = 180;
        int flag = 0;
        Arrow a = new Arrow(new Point(x, y), 0, (int)(x * 0.45), (int)(y * 0.1));
        Knob c = new Knob(new Point(x, y), speed);
        public Form1()
        {
            InitializeComponent();
            this.Width = x;
            this.Height = y;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            c.Draw(g);
            c.DrawNumbers(g);


        }
        int dx;
        int dy;
        private void Form1_MouseClick(Object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            if (flag == 2)
            { a.HelpArrowtwo(g, dx, dy); }
            if (flag == 1)
            { a.HelpArrowone(g, dx, dy, a.AreaReference(g, dx, dy)); }
            if (c.isInsideblock1(e.X, e.Y))
            { c.rejimone(g); flag = 1; }
            if (c.isInsideblock2(e.X, e.Y))
            { c.rejimtwo(g); flag = 2; }
            if (flag == 1)
            {
                a.DrawArrowone(g, a.AreaReference(g, e.X, e.Y)); dx = e.X;
                dy = e.Y;
            }
            if (flag == 2)
            {
                a.DrawArrowtwo(g, e.X, e.Y); dx = e.X;
                dy = e.Y;
            }

        }

    }
}
