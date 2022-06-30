using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random ran;
        Brush[] Colors = { Brushes.Black,Brushes.Yellow, Brushes.Red, Brushes.Blue,
            Brushes.Pink, Brushes.Pink, Brushes.Green, Brushes.Brown };
        List<Rectangle> Reclist;
        bool start = false;
        DispatcherTimer dispatcherTimer;
        // Задайте сложность.
        static int timedifficult = 500;
        int RectangleNumberDifficult = 8;
        // Задайте размер окна
        int xwidth = 640;
        int yheight = 480;
        public MainWindow()
        {
            InitializeComponent();

            ran = new Random();
            this.Width = xwidth;
            this.Height = yheight;
            Reclist = new List<Rectangle>();
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
           
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (Reclist.Count > RectangleNumberDifficult)
            {
                dispatcherTimer.Stop();
                MessageBox.Show("Ха, слабак");
                App.Current.MainWindow.Close();
            }
            if (start == true && Reclist.Count == 0)
            {
                dispatcherTimer.Stop();
                MessageBox.Show("А ты не плох");
                App.Current.MainWindow.Close();
            }
            switch (ran.Next(2)) // 0 - вертикальные прямоугольники, 1 - горизонтальные
            {
                case 0:
                    {
                        Rectangle knew = new Rectangle();
                        knew.Margin = new Thickness(ran.Next(0,(int)(xwidth * 0.765)), 
                            ran.Next(0, (int)((yheight + xwidth) / 35)), 0, 0);
                        knew.Height = ran.Next((yheight + xwidth) /20, (int)((yheight + xwidth) * 0.15));
                        knew.Width = ((yheight + xwidth) / 35);
                        knew.Stroke = Brushes.Black;
                        knew.Fill = Colors[ran.Next(Colors.Length)];  
                        knew.MouseDown += OnMouseDown;
                        Reclist.Add(knew);
                        Grid1.Children.Add(knew);
                        break;
                    }
                case 1:
                    {
                        Rectangle knew = new Rectangle();
                        knew.Margin = new Thickness(ran.Next(0, (int)((yheight + xwidth) / 20)), ran.Next(0, (int)(xwidth * 0.765)), 0, 0);
                        knew.Height = ((yheight + xwidth) / 35) ;
                        knew.Width = ran.Next((yheight + xwidth) / 20, (int)((yheight + xwidth) * 0.15));
                        knew.Stroke = Brushes.Black;
                        knew.Fill = Colors[ran.Next(Colors.Length)];
                        knew.MouseDown += OnMouseDown;
                        Reclist.Add(knew);
                        Grid1.Children.Add(knew);
                    }
                    break;
            }
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rec = sender as Rectangle;
            if (Reclist.Count >= 0.5 * RectangleNumberDifficult) start = true;
            if (start)
            {
                int i, j = 0;
                bool flag = false;
                for (i = Reclist.IndexOf(rec) + 1; i < Reclist.Count; i++)
                {
                    if (new Rect(rec.TranslatePoint(new Point(0, 0), Grid1), new Size(rec.Width, rec.Height)).
                        IntersectsWith(new Rect(Reclist[i].
                        TranslatePoint(new Point(0, 0), Grid1), new Size(Reclist[i].Width, Reclist[i].Height)))) 
                    {
                        flag = true;
                        break;
                    }
                }
            
                if (!flag)
                {
                    Grid1.Children.Remove(rec);
                    Reclist.Remove(rec);
                }
                
                }

            }
        }
    }
