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
    class Knob
    {
        private
        int speed;
        Point xy;
        Pen p = new Pen(Color.Black, 5);
        Pen p2 = new Pen(Color.Brown, 5);
        Brush b = new SolidBrush(Color.DarkOrange);
        Brush b2 = new SolidBrush(Color.LightGreen);
        public Knob(Point xy, int speed)
        {
            this.xy = xy;
            this.speed = speed;
        }
        internal bool isInsideblock1(int x, int y)
        {
            if ((x >= (int)(xy.X * 0.2)) && (y >= (int)(0.714 * xy.Y)) && (x <= (int)(xy.X * 0.7)) && (y <= (int)(0.794 * xy.Y)))
                return true;
            return false;
        }
        internal bool isInsideblock2(int x, int y)
        {
            if ((x >= (int)(xy.X * 0.2)) && (y >= (int)(0.814 * xy.Y)) && (x <= (int)(xy.X * 0.7)) && (y <= (int)(0.894 * xy.Y)))
                return true;
            return false;
        }
        internal void rejimone(Graphics g)
        {
            int line = (int)(0.1 * xy.X);
            g.DrawRectangle(Pens.Black, (int)(xy.X * 0.37),
                    (int)(xy.Y * 0.13), (int)(xy.X * 0.18), (int)(xy.Y * 0.11) - line);
            g.FillRectangle(Brushes.Yellow, (int)(xy.X * 0.37),
                    (int)(xy.Y * 0.13), (int)(xy.X * 0.18), (int)(xy.Y * 0.11) - line);
            g.DrawString("Режим 1", new Font("Arial", (int)(0.04 * xy.X),
                    GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.37),
                    (int)(xy.Y * 0.13), (int)(xy.X * 0.45), (int)(xy.Y * 0.6) - line));

        }
        internal void rejimtwo(Graphics g)
        {
            int line = (int)(0.1 * xy.X);
            g.DrawRectangle(Pens.Black, (int)(xy.X * 0.37),
                    (int)(xy.Y * 0.13), (int)(xy.X * 0.18), (int)(xy.Y * 0.11) - line);
            g.FillRectangle(Brushes.Pink, (int)(xy.X * 0.37),
                    (int)(xy.Y * 0.13), (int)(xy.X * 0.18), (int)(xy.Y * 0.11) - line);
            g.DrawString("Режим 2", new Font("Arial", (int)(0.04 * xy.X),
                    GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.37),
                    (int)(xy.Y * 0.13), (int)(xy.X * 0.45), (int)(xy.Y * 0.6) - line));
        }

        internal void Draw(Graphics g)
        {
            int line = (int)(0.1 * xy.X);
            g.DrawRectangle(p, 0, 0, (int)(0.9 * xy.X), (int)(0.9 * xy.Y)); //Основая рамка
                                                                            //окружность в центре
            g.DrawEllipse(p, (int)(0.1 * xy.X), (int)(0.1 * xy.Y), (int)(0.7 * xy.X), (int)(0.5 * xy.Y));
            g.FillRectangle(b, 0, 0, (int)(0.9 * xy.X), (int)(0.9 * xy.Y));
            g.FillEllipse(b2, (int)(0.1 * xy.X), (int)(0.1 * xy.Y), (int)(0.7 * xy.X), (int)(0.5 * xy.Y));
            g.DrawEllipse(p, (int)(0.1 * xy.X), (int)(0.1 * xy.Y), (int)(0.7 * xy.X), (int)(0.5 * xy.Y));
            //деления
            g.DrawLine(p, (int)(xy.X * 0.1), (int)(xy.Y * 0.357), (int)(xy.X * 0.1) + line, (int)(xy.Y * 0.357));
            g.DrawLine(p, (int)(xy.X * 0.8), (int)(xy.Y * 0.357), (int)(xy.X * 0.8) - line, (int)(xy.Y * 0.357));
            g.DrawLine(p, (int)(xy.X * 0.45), (int)(xy.Y * 0.6), (int)(xy.X * 0.45), (int)(xy.Y * 0.6) - line);
            g.DrawLine(p, (int)(xy.X * 0.2), (int)(xy.Y * 0.175), (int)(xy.X * 0.2 + line * Math.Cos(0.785398)), (int)(xy.Y * 0.175 + line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.7), (int)(xy.Y * 0.175), (int)(xy.X * 0.7 - line * Math.Cos(0.785398)), (int)(xy.Y * 0.175 + line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.2), (int)(xy.Y * 0.525), (int)(xy.X * 0.2 + line * Math.Cos(0.785398)), (int)(xy.Y * 0.525 - line * Math.Sin(0.785398)));
            g.DrawLine(p, (int)(xy.X * 0.7), (int)(xy.Y * 0.525), (int)(xy.X * 0.7 - line * Math.Cos(0.785398)), (int)(xy.Y * 0.525 - line * Math.Sin(0.785398)));

            Rectangle block1 = new Rectangle((int)(xy.X * 0.2), (int)(0.714 * xy.Y), (int)(xy.X * 0.5), (int)(0.08 * xy.Y));
            Rectangle block2 = new Rectangle((int)(xy.X * 0.2), (int)(0.814 * xy.Y), (int)(xy.X * 0.5), (int)(0.08 * xy.Y));

            g.DrawRectangle(p, block1);
            g.FillRectangle(Brushes.DarkBlue, block1);
            g.DrawRectangle(p, block2);
            g.FillRectangle(Brushes.LightBlue, block2);
        }
        internal void DrawNumbers(Graphics g)
        {
            int line = (int)(0.1 * xy.X);
            g.DrawString(0 + "", new Font("Arial", (int)(0.055 * xy.X),
                   GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.7),
                   (int)(xy.Y * 0.14), (int)(xy.X * 0.7 - line * Math.Cos(0.785398)),
                   (int)(xy.Y * 0.175 + line * Math.Sin(0.785398))));
            g.DrawString(speed + "", new Font("Arial", (int)(0.055 * xy.X),
                   GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.1),
                   (int)(xy.Y * 0.14), (int)(xy.X * 0.35 - line * Math.Cos(0.785398)),
                   (int)(xy.Y * 0.17 + line * Math.Sin(0.785398))));
            g.DrawString(speed / 2 + "", new Font("Arial", (int)(0.055 * xy.X),
                   GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.4),
                   (int)(xy.Y * 0.6), (int)(xy.X * 0.45), (int)(xy.Y * 0.6) - line));
            g.DrawString(speed * 5 / 6 + "", new Font("Arial", (int)(0.055 * xy.X),
                  GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(0),
                  (int)(xy.Y * 0.337), (int)(xy.X * 0.1) + line, (int)(xy.Y * 0.357)));
            g.DrawString(speed * 1 / 6 + "", new Font("Arial", (int)(0.055 * xy.X),
                 GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.8),
                 (int)(xy.Y * 0.33), (int)(xy.X * 0.1) + line, (int)(xy.Y * 0.357)));
            g.DrawString(speed * 4 / 6 + "", new Font("Arial", (int)(0.055 * xy.X),
                 GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.1),
                 (int)(xy.Y * 0.525), (int)(xy.X * 0.2 + line * Math.Cos(0.785398)),
                 (int)(xy.Y * 0.525 - line * Math.Sin(0.785398))));
            g.DrawString(speed * 2 / 6 + "", new Font("Arial", (int)(0.055 * xy.X),
                 GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.68),
                 (int)(xy.Y * 0.525), (int)(xy.X * 0.2 + line * Math.Cos(0.785398)),
                 (int)(xy.Y * 0.525 - line * Math.Sin(0.785398))));
            g.DrawString("СПИДОМЕТР", new Font("Arial", (int)(0.055 * xy.X),
                GraphicsUnit.Pixel), Brushes.Black, new RectangleF((int)(xy.X * 0.28),
                (int)(xy.Y * 0.05), (int)(xy.X * 0.45), (int)(xy.Y * 0.6) - line));

        }
    }
}
