using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarryPotter
{
    public partial class Form1 : Form
    {
        private Player HarryPotter;
        private int PlayerHealth;
        private Enemy Voldemort;
        private int EnemyHealth;
        private Dementor Dementor;
        private Horcruxes Horcrux;
        private List<Spell> Spells = new List<Spell>();
        private List<Spell> DarkSpells = new List<Spell>();
        private List<Spell> Patronuses = new List<Spell>();
        private Spell Shield;
        private bool ShieldUp;
        private bool lastLevel;
        private int HorcruxCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HarryPotter = new Player();
            PlayerHealth = 100;
            EnemyHealth = 100;
            Controls.Add(HarryPotter);
            Voldemort = new Enemy();
            Controls.Add(Voldemort);
            ShieldUp = false;
            HealthLabel.Text = EnemyHealth.ToString();
            PHealthLabel.Text = PlayerHealth.ToString();
            var gameSong = new SoundPlayer(Properties.Resources.startM);
            gameSong.Play();
            HorcruxCount = 0;

            
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            var returnVal = false;
            switch (keyData)
            {
                case Keys.W:
                    HarryPotter.MoveUp();
                    returnVal = true;
                    break;
                case Keys.A:
                    HarryPotter.MoveLeft();
                    returnVal = true;
                    break;
                case Keys.S:
                    HarryPotter.MoveDown();
                    returnVal = true;
                    break;
                case Keys.D:
                    HarryPotter.MoveRight();
                    returnVal = true;
                    break;
                case Keys.H:
                    PlayerShoot();
                    returnVal = true;
                    break;
                case Keys.J:
                    if (!(ShieldUp))
                    {
                        PlayerShield();
                    }
                    returnVal = true;
                    break;
                case Keys.K:
                    ExpectoPatronum();
                    returnVal = true;
                    break;
            }
            return returnVal;
        }
        private void ExpectoPatronum()
        {
            Spell patronus = new Spell(HarryPotter.Top + 20, HarryPotter.Left + 50);
            patronus.Patronus();
            Controls.Add(patronus);
            Patronuses.Add(patronus);
        }
        private void PlayerShoot()
        {
            Spell spell = new Spell(HarryPotter.Top + 30, HarryPotter.Left + 50);
            Controls.Add(spell);
            Spells.Add(spell);
        }
        private void PlayerShield()
        {
            Shield = new Spell(HarryPotter.Top, HarryPotter.Left + 55);
            Shield.Protego();
            Controls.Add(Shield);
            ShieldUp = true;
            
        }
        private void EnemyShoot()
        {
            Spell spell = new Spell(Voldemort.Top + 30, Voldemort.Left);
            spell.AvadaKedavra();
            Controls.Add(spell);
            DarkSpells.Add(spell);
        }
        private void RenderScores()
        {
            HealthLabel.Text = EnemyHealth.ToString();
            PHealthLabel.Text = PlayerHealth.ToString();
            HorcruxesLabel.Text = HorcruxCount.ToString();
        }
        private void GameOver()
        {
            HarryPotter.Image = Properties.Resources.death;
            GameTimer.Enabled = false;
            EnemyTimer.Enabled = false;
            MoveTimer.Enabled = false;
            var endSound = new SoundPlayer(Properties.Resources.lose);
            endSound.Play();
            var gameOver = MessageBox.Show("The Dark Lord has Won", "Game Over :(", MessageBoxButtons.OK);  // Game over message box
            if (gameOver == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void GameWon()
        {
            GameTimer.Enabled = false;
            EnemyTimer.Enabled = false;
            MoveTimer.Enabled = false;
            var gameOver = MessageBox.Show("The Dark Lord has been defeated", "Click OK to exit", MessageBoxButtons.OK);
            if (gameOver == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            var goodBounds = from spell in Spells
                         where spell.Left >= 600
                         select spell;
            var goodBoundsList = goodBounds.ToList();
            var darkBounds = from spell in DarkSpells
                             where spell.Left <= 0
                             select spell;
            var darkBoundsList = darkBounds.ToList();
            foreach (var spell in goodBoundsList)
            {
                Controls.Remove(spell);
                Spells.Remove(spell);
            }
            foreach (var spell in darkBoundsList)
            {
                Controls.Remove(spell);
                DarkSpells.Remove(spell);
            }
            var playerHits = from spell in DarkSpells
                             where spell.HitTest(HarryPotter.Bounds)
                             select spell;
            var playerHitsList = playerHits.ToList();
            foreach (var spell in playerHitsList)
            {
                if (HarryPotter.HitTest(spell.Bounds))
                {
                    PlayerHealth -= 10;
                    Controls.Remove(spell);
                    DarkSpells.Remove(spell);
                }
            }
            var enemyHits = from spell in Patronuses
                            where spell.HitTest(Dementor.Bounds)
                            select spell;

            var enemyHitsList = enemyHits.ToList();
            foreach (var spell in enemyHitsList)
            {
                if (Dementor.HitTest(spell.Bounds))
                {
                    Dementor.Reset();
                    Controls.Remove(spell);
                    Spells.Remove(spell);
                }
               
            }
            var voldyHits = from spell in Spells
                            where spell.HitTest(Voldemort.Bounds)
                            select spell;
            var voldyHitsList = voldyHits.ToList();
            foreach (var hit in voldyHitsList)
            {
                if (Voldemort.HitTest(hit.Bounds))
                {
                    EnemyHealth -= 1;
                }
            }
            if (ShieldUp)
            {
                var shieldHits = from spell in DarkSpells
                                 where spell.HitTest(Shield.Bounds)
                                 select spell;
                var shieldHitsList = shieldHits.ToList();
                foreach (var spell in shieldHitsList)
                {
                    if (Shield.HitTest(spell.Bounds))
                    {
                        Controls.Remove(Shield);
                        Controls.Remove(spell);
                        DarkSpells.Remove(spell);
                        ShieldUp = false;
                    }
                }
            }
            
            foreach (var spell in Spells)
            {
                spell.MoveSpell();
            }
            foreach (var spell in DarkSpells)
            {
                spell.MoveDarkSpell();
            }
            foreach (var spell in Patronuses)
            {
                spell.MovePatronus();
            }
            RenderScores();
            if(PlayerHealth <= 0)
            {
                GameOver();
            }
            else if(EnemyHealth <= 0)
            {
                GameWon();
            }
            if(Dementor.Left <= -40)
            {
                Dementor.Reset();
            }
            if (Dementor.HitTest(HarryPotter.Bounds))
            {
                PlayerHealth -= 40;
                Dementor.Reset();
                
            }
            Dementor.MoveDementor();
            Horcrux.MoveHorcrux();
            if (HarryPotter.HitTest(Horcrux.Bounds))
            {
                HorcruxCount++;
                Controls.Remove(Horcrux);
                if(HorcruxCount < 7)
                {
                    Horcrux = new Horcruxes();
                    Horcrux.ChooseHorcrux();
                    Controls.Add(Horcrux);
                }
            }
            if (Voldemort.HitTest(HarryPotter.Bounds))
            {
                GameOver();
            }
            if(HorcruxCount == 7)
            {
                lastLevel = true;
            }
            if(Horcrux.Top >= Height)
            {
                Horcrux.Reset();
            }

            
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            Voldemort.SetCoordinates();
            if (lastLevel)
            {
                EnemyShoot();
            }
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            Voldemort.SetCoordinates();
            Dementor = new Dementor();
            lastLevel = false;
            Horcrux = new Horcruxes();
            Horcrux.ChooseHorcrux();
            Controls.Add(Horcrux);
            Controls.Add(Dementor);
            GameTimer.Enabled = true;
            EnemyTimer.Enabled = true;
            MoveTimer.Enabled = true;
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Voldemort.MoveEnemy();
           
        }
    }
}
