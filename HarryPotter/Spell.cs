using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HarryPotter
{
    class Spell : PictureBox
    {
        public Spell(int top, int left)
        {
            Top = top;
            Left = left;
            Size = new Size(50, 20);
            Image = Properties.Resources.spell;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Spell()
            : this(0, 0)
        {

        }

        public void MoveSpell()
        {
            Left += 10;
        }
        public void MoveDarkSpell()
        {
            Left -= 10;
        }
        public void AvadaKedavra()
        {
            Image = Properties.Resources.kill;
        }
        public void Patronus()
        {
            Image = Properties.Resources.expecto;
            Size = new Size(50, 40);
        }
        public void MovePatronus()
        {
            Left += 5;
        }
        public void Protego()
        {
            Image = Properties.Resources.protego;
            Size = new Size(50, 50);
        }
        public bool HitTest(Rectangle bounds)
        {
            return Bounds.IntersectsWith(bounds);
        }
    }
}
