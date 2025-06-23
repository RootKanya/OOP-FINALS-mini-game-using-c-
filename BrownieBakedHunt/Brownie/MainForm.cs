namespace Brownie
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void CenterLabel()
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
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

            int spacing = 100;
            int startTop = this.ClientSize.Height - 600;
            playButton.Top = startTop;
            exitButton.Top = startTop + playButton.Height + spacing;

        }

        private void CenterButtons()
        {
            int centerX = (this.ClientSize.Width - playButton.Width) / 2;

            playButton.Left = centerX;
            exitButton.Left = centerX;
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
