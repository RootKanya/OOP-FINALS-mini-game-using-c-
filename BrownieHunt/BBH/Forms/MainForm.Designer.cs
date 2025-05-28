using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrownieBakedHunt.Forms
{
    public class MainForm : Form
    {
        private Button startGameButton;
        private Button exitButton;

        public MainForm()
        {
            InitializeForm();
            InitializeControls();
        }

        private void InitializeForm()
        {
            this.Text = "Main Menu";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeControls()
        {
            startGameButton = new Button
            {
                Text = "Start",
                Location = new Point(150, 80),
                Size = new Size(100, 40)
            };
            startGameButton.Click += StartGameButton_Click;
            this.Controls.Add(startGameButton);

            exitButton = new Button
            {
                Text = "Exit",
                Location = new Point(150, 140),
                Size = new Size(100, 40)
            };
            exitButton.Click += (s, e) => Application.Exit();
            this.Controls.Add(exitButton);
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectCharacter selectCharacter = new SelectCharacter();
            selectCharacter.Show();
        }
    }
}