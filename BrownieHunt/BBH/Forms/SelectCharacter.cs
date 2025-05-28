using BrownieBakedHunt.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrownieBakedHunt.Forms
{
    public class SelectCharacter : Form
    {
        private Button sky;
        private Button star;

        public SelectCharacter()
        {
            InitializeForm();
            InitializeControls();
        }

        private void InitializeForm()
        {
            this.Text = "Select Your Character!";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeControls()
        {
            sky = new Button
            {
                Text = "Sky",
                Location = new Point(150, 80),
                Size = new Size(100, 40)
            };
            sky.Click += (s, e) =>
            {
                GameData.SelectedCharacter = "Sky";
                StartGame();
            };
            this.Controls.Add(sky);

            star = new Button
            {
                Text = "Star",
                Location = new Point(150, 140),
                Size = new Size(100, 40)
            };
            star.Click += (s, e) =>
            {
                GameData.SelectedCharacter = "Star";
                StartGame();
            };
            this.Controls.Add(star);
        }

        private void StartGame()
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.FormClosed += (s, args) => Application.Exit();
            gameForm.Show();
        }
    }
}