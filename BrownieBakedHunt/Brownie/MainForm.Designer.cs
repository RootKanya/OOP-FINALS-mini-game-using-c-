namespace Brownie
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            playButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            playButton.Location = new Point(189, 309);
            playButton.Name = "playButton";
            playButton.Size = new Size(220, 70);
            playButton.TabIndex = 2;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            exitButton.Location = new Point(189, 423);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(220, 70);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            BackgroundImage = Properties.Resources.Start_Page;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(578, 744);
            Controls.Add(exitButton);
            Controls.Add(playButton);
            DoubleBuffered = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
    }
}
