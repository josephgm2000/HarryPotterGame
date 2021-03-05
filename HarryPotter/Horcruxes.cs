using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HarryPotter
{
    class Horcruxes : PictureBox
    {
        private static Random randomPos = new Random();
        public Horcruxes(int top, int left)
        {
            Top = top;
            Left = left;
            Size = new Size(40, 40);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Horcruxes()
            : this(0, randomPos.Next(50, 560))
        {

        }
        public void MoveHorcrux()
        {
            Top += 1;
        }
        public void Reset()
        {
            Top = 0;
        }
        public void ChooseHorcrux()
        {
            int choice = randomPos.Next(1, 4);
            if(choice == 1)
            {
                Image = Properties.Resources.ring;
            }
            else if(choice == 2)
            {
                Image = Properties.Resources.locket;
            }
            else if(choice == 3)
            {
                Image = Properties.Resources.cup;
            }
            else if(choice == 4)
            {
                Image = Properties.Resources.diadem;
            }
        }
        
    }
}
