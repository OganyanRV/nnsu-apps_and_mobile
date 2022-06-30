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
    class Arrow
    {
        List<int> numbers = new List<int>();
        double deg;
        Point xy;
        int xx, yy;
        Pen p = new Pen(Color.Black, 5);
        Pen p2 = new Pen(Color.Brown, 5);
        Brush b = new SolidBrush(Color.DarkOrange);
        Pen kostil = new Pen(Color.LightGreen, 5);
        public Arrow(Point xy, double deg, int xx, int yy)
        {
            this.xy = xy;
            this.deg = deg;
            this.xx = xx;
            this.yy = yy;
        }
        internal int AreaReference(Graphics g, int xx, int yy)
        {
            if (xx >= (int)(0.62 * xy.X) && xx <= (int)(0.74 * xy.X) && yy >= (int)(0.157 * xy.Y) && yy <= (int)(0.228 * xy.Y))
                return 1;
            else if (xx >= (int)(0.7 * xy.X) && xx <= (int)(0.82 * xy.X) && yy >= (int)(0.314 * xy.Y) && yy <= (int)(0.392 * xy.Y))
                return 2;
            else if (xx >= (int)(0.62 * xy.X) && xx <= (int)(0.74 * xy.X) && yy >= (int)(0.465 * xy.Y) && yy <= (int)(0.542 * xy.Y))
                return 3;
            else if (xx >= (int)(0.39 * xy.X) && xx <= (int)(0.51 * xy.X) && yy >= (int)(0.364 * xy.Y) && yy <= (int)(0.444 * xy.Y))
                return 4;
            else if (xx >= (int)(0.17 * xy.X) && xx <= (int)(0.29 * xy.X) && yy >= (int)(0.465 * xy.Y) && yy <= (int)(0.542 * xy.Y))
                return 5;
            else if (xx >= (int)(0.09 * xy.X) && xx <= (int)(0.21 * xy.X) && yy >= (int)(0.314 * xy.Y) && yy <= (int)(0.392 * xy.Y))
                return 6;
            else if (xx >= (int)(0.17 * xy.X) && xx <= (int)(0.29 * xy.X) && yy >= (int)(0.157 * xy.Y) && yy <= (int)(0.228 * xy.Y))
                return 7;


            return 0;
        }
        internal void DrawArrowone(Graphics g, int a)
        {
            switch (a)
            {
                case 1:
                    g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.7), (int)(xy.Y * 0.175));
                    break;
                case 2:
                    g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.8), (int)(xy.Y * 0.357));
                    break;
                case 3:
                    g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.7), (int)(xy.Y * 0.525));
                    break;
                case 4:
                    g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.45), (int)(xy.Y * 0.6));
                    break;
                case 5:
                    g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.2), (int)(xy.Y * 0.525));
                    break;
                case 6:
                    g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.1), (int)(xy.Y * 0.357));
                    break;
                case 7:
                    g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.2), (int)(xy.Y * 0.175));
                    break;
                default:
                    break;


            }
        }
        internal void HelpArrowone(Graphics g, int xx, int yy, int a)
        {
            int line = (int)(0.1 * xy.X);
            switch (a)
            {
                case 1:
                    // g.DrawLine(p, (int)(xy.X * 0.7), (int)(xy.Y * 0.175), (int)(xy.X * 0.7 - line * Math.Cos(0.785398)), (int)(xy.Y * 0.175 + line * Math.Sin(0.785398)));
                    g.DrawLine(kostil, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.7), (int)(xy.Y * 0.175));
                    break;
                case 2:
                    g.DrawLine(kostil, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.8), (int)(xy.Y * 0.357));
                    break;
                case 3:
                    g.DrawLine(kostil, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.7), (int)(xy.Y * 0.525));
                    break;
                case 4:
                    g.DrawLine(kostil, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.45), (int)(xy.Y * 0.6));
                    break;
                case 5:
                    g.DrawLine(kostil, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.2), (int)(xy.Y * 0.525));
                    break;
                case 6:
                    g.DrawLine(kostil, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.1), (int)(xy.Y * 0.357));
                    break;
                case 7:
                    g.DrawLine(kostil, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)(xy.X * 0.2), (int)(xy.Y * 0.175));
                    break;
                default:
                    break;


            }
            g.DrawEllipse(p, (int)(0.1 * xy.X), (int)(0.1 * xy.Y), (int)(0.7 * xy.X), (int)(0.5 * xy.Y));
            g.DrawLine(p, (int)(xy.X * 0.1), (int)(xy.Y * 0.357), (int)(xy.X * 0.1) + line, (int)(xy.Y * 0.357));
            g.DrawLine(p, (int)(xy.X * 0.8), (int)(xy.Y * 0.357), (int)(xy.X * 0.8) - line, (int)(xy.Y * 0.357));
            g.DrawLine(p, (int)(xy.X * 0.45), (int)(xy.Y * 0.6), (int)(xy.X * 0.45), (int)(xy.Y * 0.6) - line);
            g.DrawLine(p, (int)(xy.X * 0.2), (int)(xy.Y * 0.175), (int)(xy.X * 0.2 + line * Math.Cos(0.785398)), (int)(xy.Y * 0.175 + line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.7), (int)(xy.Y * 0.175), (int)(xy.X * 0.7 - line * Math.Cos(0.785398)), (int)(xy.Y * 0.175 + line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.2), (int)(xy.Y * 0.525), (int)(xy.X * 0.2 + line * Math.Cos(0.785398)), (int)(xy.Y * 0.525 - line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.7), (int)(xy.Y * 0.525), (int)(xy.X * 0.7 - line * Math.Cos(0.785398)), (int)(xy.Y * 0.525 - line * Math.Sin(0.785398)));

        }
        internal void HelpArrowtwo(Graphics g, int xx, int yy)
        {
            int line = (int)(0.1 * xy.X);
            g.DrawEllipse(p, (int)(0.1 * xy.X), (int)(0.1 * xy.Y), (int)(0.7 * xy.X), (int)(0.5 * xy.Y));
            int r = (int)(0.25 * xy.Y);
            double errormax = Math.Pow((xx - (int)xy.X * 0.45), 2) + Math.Pow((yy - (int)xy.Y * 0.357), 2);
            if (errormax <= r * r * 1.02 && errormax >= 0.95 * r * r)
                g.DrawLine(kostil, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), xx, yy);
            g.DrawLine(p, (int)(xy.X * 0.1), (int)(xy.Y * 0.357), (int)(xy.X * 0.1) + line, (int)(xy.Y * 0.357));
            g.DrawLine(p, (int)(xy.X * 0.8), (int)(xy.Y * 0.357), (int)(xy.X * 0.8) - line, (int)(xy.Y * 0.357));
            g.DrawLine(p, (int)(xy.X * 0.45), (int)(xy.Y * 0.6), (int)(xy.X * 0.45), (int)(xy.Y * 0.6) - line);
            g.DrawLine(p, (int)(xy.X * 0.2), (int)(xy.Y * 0.175), (int)(xy.X * 0.2 + line * Math.Cos(0.785398)), (int)(xy.Y * 0.175 + line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.7), (int)(xy.Y * 0.175), (int)(xy.X * 0.7 - line * Math.Cos(0.785398)), (int)(xy.Y * 0.175 + line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.2), (int)(xy.Y * 0.525), (int)(xy.X * 0.2 + line * Math.Cos(0.785398)), (int)(xy.Y * 0.525 - line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.7), (int)(xy.Y * 0.525), (int)(xy.X * 0.7 - line * Math.Cos(0.785398)), (int)(xy.Y * 0.525 - line * Math.Sin(0.785398)));
        }
        internal void DrawArrowtwo(Graphics g, int xx, int yy)
        {
            int d1 = xx;
            int d2 = yy;
            int r = (int)(0.25 * xy.Y);
            double errormax = Math.Pow((xx - (int)xy.X * 0.45), 2) + Math.Pow((yy - (int)xy.Y * 0.357), 2);
            if (errormax <= r * r * 1.02 && errormax >= 0.95 * r * r)
                g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), xx, yy);

        }
        internal void DrawArrow(Graphics g)
        {
            int r = (int)(0.25 * xy.Y);
            int line = (int)(0.1 * xy.X);
            double coss = Math.Cos(deg);
            double sinn = Math.Sin(deg);
            g.DrawLine(p2, (int)(xy.X * 0.45), (int)(xy.Y * 0.357), (int)((xy.X * 0.45) - (sinn * r)), (int)((xy.Y * 0.357) - (coss * r)));
        }

    }
}
