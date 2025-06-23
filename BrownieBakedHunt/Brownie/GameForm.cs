using Brownie.GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Brownie
{
    public partial class GameForm : Form
    {
        private Character character;
        private Wolf wolf;
        private Random rng = new Random();
        private System.Windows.Forms.Timer gameTimer;

        public GameForm(string selectedCharacter)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += OnKeyDown;
            this.KeyUp += OnKeyUp;

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();


            Image sprite = selectedCharacter switch
            {
                "Sky" => Properties.Resources.Sky,
                "Star" => Properties.Resources.Star
            };

            character = new Character(new Point(210, 580), new Size(32, 32), sprite);
            this.Controls.Add(character.GetPictureBox());

            Image wolfSprite = Properties.Resources.Werewolf; // sesuaikan dengan gambar musuh kamu
            Point wolfSpawn = new Point(rng.Next(100, 500), rng.Next(100, 300));

            wolf = new Wolf(wolfSpawn, new Size(32, 32), wolfSprite);
            this.Controls.Add(wolf.GetPictureBox());
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
            {
                Core.IsUp = true;
            }
            else if (e.KeyCode == Core.KeyDown)
            {
                Core.IsDown = true;
            }
            else if (e.KeyCode == Core.KeyLeft)
            {
                Core.IsLeft = true;
            }
            else if (e.KeyCode == Core.KeyRight)
            {
                Core.IsRight = true;
            }

        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
            {
                Core.IsUp = false;
            }
            else if (e.KeyCode == Core.KeyDown)
            {
                Core.IsDown = false;
            }
            else if (e.KeyCode == Core.KeyLeft)
            {
                Core.IsLeft = false;
            }
            else if (e.KeyCode == Core.KeyRight)
            {
                Core.IsRight = false;
            }

        }

        private void GameLoop(object sender, EventArgs e)
        {
            character.Move(this.ClientSize);
            wolf.Move(this.ClientSize);
        }
    }
}
