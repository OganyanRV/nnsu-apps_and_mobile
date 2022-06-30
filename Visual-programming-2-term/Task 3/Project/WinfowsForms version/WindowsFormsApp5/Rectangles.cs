using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp5
{
    class Rectangles
    {
        private Point xy;
        private Size s;
        private Brush col;
        public
        Rectangles(Point _xy, Size _s, Brush _col)
        {
            xy = _xy;
            s = _s;
            col = _col;
        }
        internal bool Inside(int __x, int __y)
        {
            if (__x < xy.X || __x > xy.X + s.Width) return false;
            if (__y < xy.Y || __y > xy.Y + s.Height) return false;
            return true;
        }
        internal bool Cross(Rectangles _R)
        {

            return (new Rectangle(xy, s).IntersectsWith(new Rectangle(_R.xy, _R.s)));
        }
        internal void DrawRec(Graphics g)
        {
            g.FillRectangle(col, xy.X, xy.Y, s.Width, s.Height);
            g.DrawRectangle(Pens.Black, xy.X, xy.Y, s.Width, s.Height);
        }
      
    }
}
