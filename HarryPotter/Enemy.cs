using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HarryPotter
{
    class Enemy : PictureBox
    {
        private static Random randomGen = new Random();
        public int XCo { get; set; }
        public int YCo { get; set; }
        public Enemy(int top, int left)
        {
            Top = top;
            Left = left;
            Size = new Size(50, 70);
            Image = Properties.Resources.voldemort;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Enemy()
            : this (randomGen.Next(0,310), randomGen.Next(300, 550))
        {

        }
        public void SetCoordinates()
        {
            YCo = randomGen.Next(0, 310);
            XCo = randomGen.Next(10, 540);
        }
        public void MoveEnemy()
        {
            
            if (Top < YCo)
            {
                Top += 5;
            }
            else if (Top > YCo)
            {
                Top -= 5;
            }
            if (Left < XCo)
            {
                Left += 5;
            }
            else if(Left > XCo)
            {
                Left -= 5;
            }
        }
        public bool HitTest(Rectangle bounds)
        {
            return Bounds.IntersectsWith(bounds);
        }
    }
}
