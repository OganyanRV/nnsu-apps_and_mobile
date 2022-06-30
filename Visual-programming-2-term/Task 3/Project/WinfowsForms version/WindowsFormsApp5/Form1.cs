using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        Random ran;
        Brush[] Colors = { Brushes.Black, Brushes.White,Brushes.Yellow, Brushes.Red, Brushes.Blue,
            Brushes.Pink, Brushes.Pink, Brushes.Green, Brushes.Brown };
        List<Rectangles> Reclist;
        bool start = false;
        System.Timers.Timer time;
        // Задайте сложность.
        static int timedifficult = 500;
        int RectangleNumberDifficult = 8;
        // Задайте размер окна
        int xwidth = 1280;
        int yheight = 720;
        public Form1()
        {
            InitializeComponent();
            ran = new Random();
            this.Width = xwidth;
            this.Height = yheight;
            Reclist = new List<Rectangles>();
            time = new System.Timers.Timer(timedifficult);
            time.Elapsed += funtime;
            time.AutoReset = true;
            time.Enabled = true;

        }
        private void funtime(object sender, ElapsedEventArgs e)
        {
            if (Reclist.Count > RectangleNumberDifficult)
            {
                time.Stop();
                MessageBox.Show("Ха, слабак");
                Application.Exit();
            }
            if (start == true && Reclist.Count == 0)
            {
                time.Stop();
                MessageBox.Show("А ты не плох");
                Application.Exit();
            }
            Graphics g = this.CreateGraphics();
            switch (ran.Next(2)) // 0 - вертикальные прямоугольники, 1 - горизонтальные
            {
                case 0:
                    {
                        Rectangles knew = new Rectangles(new Point(ran.Next((int)(xwidth*0.765)),
                            ran.Next((int)(yheight + xwidth) / 20)), new Size(((yheight+xwidth)/35),
                            ran.Next((yheight + xwidth)/20, (int)((yheight + xwidth)*0.15))),
                            Colors[ran.Next(Colors.Length)]);
                        Reclist.Add(knew);
                        knew.DrawRec(g);
                    }
                    break;
                case 1:
                    {
                        Rectangles knew = new Rectangles(new Point(ran.Next((int)(yheight + xwidth) / 20), ran.Next((int)(yheight * 0.58))), new Size(ran.Next((yheight + xwidth) / 20, (int)((yheight + xwidth) * 0.15)),((yheight + xwidth) / 35)), Colors[ran.Next(Colors.Length)]);
                        Reclist.Add(knew);
                        knew.DrawRec(g);
                    }
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender,  PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            foreach (Rectangles rec in Reclist)
            {
                rec.DrawRec(g);
            }
        }
        private void Form1_MouseClick(object sender,  MouseEventArgs e)
        {
            // if (!start) start = true;
            if (Reclist.Count >= 0.5*RectangleNumberDifficult) start = true;
            if (start) {
                foreach (Rectangles rec in Reclist)
                {
                    if (rec.Inside(e.X, e.Y))
                    {
                        int i;
                        bool flag = false;
                        for (i = Reclist.IndexOf(rec) + 1; i < Reclist.Count; i++)
                        {
                            if (rec.Cross(Reclist[i]))
                            {
                                flag = true;
                                break;
                            }
                                
                        }
                        if (flag==false)
                        {
                            
                            Reclist.Remove(rec);
                            Invalidate();
                            break;
                        }
                           
                    }
                }
            }
        }
    }
}

           
