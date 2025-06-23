namespace Brownie
{
    partial class SelectCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCharacter));
            label1 = new Label();
            backButton = new Button();
            nextButton = new Button();
            pictureBox1 = new PictureBox();
            selectSky = new PictureBox();
            selectStar = new PictureBox();
            skyLabel = new Label();
            starLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectSky).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectStar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 83);
            label1.Name = "label1";
            label1.Size = new Size(411, 51);
            label1.TabIndex = 0;
            label1.Text = "Select Your Character!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(32, 664);
            backButton.Name = "backButton";
            backButton.Size = new Size(137, 49);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_OnClick;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(413, 664);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(140, 49);
            nextButton.TabIndex = 2;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_OnClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sky;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(45, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // selectSky
            // 
            selectSky.BackColor = Color.Transparent;
            selectSky.Image = Properties.Resources.SelectSky;
            selectSky.Location = new Point(79, 239);
            selectSky.Name = "selectSky";
            selectSky.Size = new Size(173, 221);
            selectSky.TabIndex = 4;
            selectSky.TabStop = false;
            selectSky.Click += selectSky_Click;
            // 
            // selectStar
            // 
            selectStar.BackColor = Color.Transparent;
            selectStar.Image = Properties.Resources.SelectStar;
            selectStar.Location = new Point(343, 239);
            selectStar.Name = "selectStar";
            selectStar.Size = new Size(168, 221);
            selectStar.TabIndex = 5;
            selectStar.TabStop = false;
            selectStar.Click += selectStar_Click;
            // 
            // skyLabel
            // 
            skyLabel.AutoSize = true;
            skyLabel.BackColor = Color.Transparent;
            skyLabel.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel.ForeColor = Color.White;
            skyLabel.Location = new Point(123, 473);
            skyLabel.Name = "skyLabel";
            skyLabel.Size = new Size(77, 45);
            skyLabel.TabIndex = 6;
            skyLabel.Text = "Sky";
            // 
            // starLabel
            // 
            starLabel.AutoSize = true;
            starLabel.BackColor = Color.Transparent;
            starLabel.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            starLabel.ForeColor = Color.White;
            starLabel.Location = new Point(396, 473);
            starLabel.Name = "starLabel";
            starLabel.Size = new Size(90, 45);
            starLabel.TabIndex = 7;
            starLabel.Text = "Star";
            // 
            // SelectCharacter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(578, 744);
            Controls.Add(starLabel);
            Controls.Add(skyLabel);
            Controls.Add(selectStar);
            Controls.Add(selectSky);
            Controls.Add(pictureBox1);
            Controls.Add(nextButton);
            Controls.Add(backButton);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "SelectCharacter";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SelectCharacter_Load;
            Resize += OnFullScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectSky).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectStar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button backButton;
        private Button nextButton;
        private PictureBox pictureBox1;
        private PictureBox selectSky;
        private PictureBox selectStar;
        private Label skyLabel;
        private Label starLabel;
    }
}