using System;
using System.Drawing;
using System.Windows.Forms;

namespace Brownie
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(800, 800);
        }

        private void CenterLabel()
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }

        private void CenterButtons()
        {
            int centerX = (this.ClientSize.Width - playButton.Width) / 2;
            int spacing = 20;

            playButton.Left = centerX;
            exitButton.Left = centerX;

            int totalHeight = playButton.Height + spacing + exitButton.Height;
            int startTop = (this.ClientSize.Height - totalHeight) / 2;

            playButton.Top = startTop;
            exitButton.Top = playButton.Bottom + spacing;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterLabel();
            CenterButtons();
        }

        private void OnFullScreen(object sender, EventArgs e)
        {
            CenterLabel();
            CenterButtons();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SelectCharacter selectCharacter = new SelectCharacter(this);
            selectCharacter.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
