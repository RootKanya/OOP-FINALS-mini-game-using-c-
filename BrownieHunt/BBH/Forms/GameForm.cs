using System;
using System.Drawing;
using System.Windows.Forms;
using BrownieBakedHunt.Characters;

namespace BrownieBakedHunt
{
    public class GameForm : Form
    {
        private Character player;
        private Timer animationTimer;

        public GameForm()
        {
            this.Text = "Game";
            this.Size = new Size(800, 600);
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitGame();
        }

        private void InitGame()
        {
            // Buat karakter sesuai pilihan
            switch (GameData.SelectedCharacter)
            {
                case "Sky":
                    player = new Sky();
                    break;
                case "Star":
                    player = new Star();
                    break;
            }

            player.Position = new Point(100, 300);
            player.LoadSprites();

            animationTimer = new Timer();
            animationTimer.Interval = 150;
            animationTimer.Tick += (s, e) =>
            {
                player.NextFrame();
                this.Invalidate();
            };
            animationTimer.Start();

            this.KeyDown += GameForm_KeyDown;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                player.Move(-10, 0);
            else if (e.KeyCode == Keys.Right)
                player.Move(10, 0);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (player != null)
            {
                e.Graphics.DrawImage(player.GetCurrentFrame(), player.Position);
            }
        }
    }
}