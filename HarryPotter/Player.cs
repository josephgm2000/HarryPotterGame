using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarryPotter
{
    class Player : PictureBox
    {
        public Player(int top, int left)
        {
            Top = top;
            Left = left;
            Image = Properties.Resources.HP;
            Size = new Size(50, 50);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Player()
            : this(250, 30)
        {

        }
        public void MoveLeft()
        {
            if (Left >= 10)
            {
                Left -= 20;
            }
        }
        public void MoveRight()
        {
            if (Left < 540)
            {
                Left += 20;
            }
        }
        public void MoveUp()
        {
            if (Top >= 10)
            {
                Top -= 20;
            }
        }
        public void MoveDown()
        {
            if(Top < 310)
            {
                Top += 20;
            }
        }

        public bool HitTest(Rectangle bounds)
        {
            return Bounds.IntersectsWith(bounds);
        }
    }
}
