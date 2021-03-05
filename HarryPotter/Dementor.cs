using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace HarryPotter
{
    class Dementor : PictureBox
    {
        private static Random randPos = new Random();
        public Dementor(int top, int left)
        {
            Top = top;
            Left = left;
            Size = new Size(40, 50);
            Image = Properties.Resources.dementor;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Dementor()
            : this(randPos.Next(0, 310), 600)
        {

        }
        public void MoveDementor()
        {
            Left -= 1;
        }
        public void Reset()
        {
            Left = 600;
            Top = randPos.Next(0, 310);
        }
        public bool HitTest(Rectangle bounds)
        {
            return Bounds.IntersectsWith(bounds);
        }
    }
}
