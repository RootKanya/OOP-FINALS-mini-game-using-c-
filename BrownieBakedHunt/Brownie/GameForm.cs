using Brownie.GameObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Brownie
{
    public partial class GameForm : Form
    {
        private Character character;
        private List<Wolf> wolves = new();
        private List<BrownieItem> brownies = new();
        private Random rng = new Random();
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreLabel;
        private int score = 0;
        private Button restartButton;
        private string selectedCharacterName;

        public GameForm(string selectedCharacter)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += OnKeyDown;
            this.KeyUp += OnKeyUp;
            this.ClientSize = new Size(600, 800);
            this.selectedCharacterName = selectedCharacter;

            // Load character sprite
            Image sprite = selectedCharacter switch
            {
                "Sky" => Properties.Resources.Sky,
                "Star" => Properties.Resources.Star,
                _ => Properties.Resources.Sky
            };

            character = new Character(new Point(400, 600), new Size(64, 64), sprite);
            this.Controls.Add(character.GetPictureBox());

            // Spawn wolf
            for(int i = 0; i < 7; i++)
            {
                SpawnWolves();
            }

            // Spawn brownies
            for (int i = 0; i < 5; i++)
            {
                SpawnBrownie();
            }

            // Score label
            scoreLabel = new Label
            {
                Text = "Score: 0",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(scoreLabel);

            // Restart button
            restartButton = new Button
            {
                Text = "Restart",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Size = new Size(120, 50),
                ForeColor = Color.White,
                Location = new Point((this.ClientSize.Width - 120) / 2, (this.ClientSize.Height - 50) / 2),
                Visible = false
            };
            restartButton.Click += RestartButton_Click;
            this.Controls.Add(restartButton);

            // Timer
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }

        private void SpawnBrownie()
        {
            Image brownieImg = Properties.Resources.Brownie;
            Point location = new Point(rng.Next(50, 750), rng.Next(50, 750));
            var brownie = new BrownieItem(location, new Size(64, 64), brownieImg);
            brownies.Add(brownie);
            this.Controls.Add(brownie.GetPictureBox());
        }

        private void SpawnWolves()
        {
            Image wolfSprite = Properties.Resources.Wolf;
            Point wolfSpawn = new Point(rng.Next(100, 700), rng.Next(100, 500));
            Wolf newWolf = new Wolf(wolfSpawn, new Size(64, 64), wolfSprite);
            wolves.Add(newWolf);
            this.Controls.Add(newWolf.GetPictureBox());
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp) Core.IsUp = true;
            if (e.KeyCode == Core.KeyDown) Core.IsDown = true;
            if (e.KeyCode == Core.KeyLeft) Core.IsLeft = true;
            if (e.KeyCode == Core.KeyRight) Core.IsRight = true;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp) Core.IsUp = false;
            if (e.KeyCode == Core.KeyDown) Core.IsDown = false;
            if (e.KeyCode == Core.KeyLeft) Core.IsLeft = false;
            if (e.KeyCode == Core.KeyRight) Core.IsRight = false;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            character.Move(this.ClientSize);
            foreach (var w in wolves)
            {
                w.Move(this.ClientSize);
            }

            //Game Over: Collision with wolf
            foreach (var w in wolves)
            {
                if (character.Bounds.IntersectsWith(w.Bounds))
                {
                    gameTimer.Stop();
                    MessageBox.Show("You were caught by the wolf! Game Over.", "Game Over");
                    restartButton.Visible = true;
                    return;
                }
            }

            // Brownie collection
            for (int i = brownies.Count - 1; i >= 0; i--)
            {
                if (character.Bounds.IntersectsWith(brownies[i].Bounds))
                {
                    Controls.Remove(brownies[i].GetPictureBox());
                    brownies.RemoveAt(i);
                    score++;
                    scoreLabel.Text = $"Score: {score}";

                    if (score >= 10)
                    {
                        gameTimer.Stop();
                        MessageBox.Show("You win! You collected 10 brownies.", "You Win!");
                        restartButton.Visible = true;
                        return;
                    }

                    SpawnBrownie();
                }
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.Show();
            this.Close();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
