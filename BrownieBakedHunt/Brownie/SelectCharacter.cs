using Brownie.GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brownie
{
    public partial class SelectCharacter : Form
    {
        private MainForm mainForm;
        private string selectedCharacter = null;

        public SelectCharacter(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.ClientSize = new Size(600, 800);

            selectSky.Click += selectSky_Click;
            selectStar.Click += selectStar_Click;
        }

        private void SelectCharacter_Load(object sender, EventArgs e)
        {
            
        }

        private void selectStar_Click(object sender, EventArgs e)
        {
            selectedCharacter = "Star";
            HighlightSelected(selectStar);
        }

        private void selectSky_Click(object sender, EventArgs e)
        {
            selectedCharacter = "Sky";
            HighlightSelected(selectSky);
        }

        private void HighlightSelected(PictureBox selected)
        {
            selectSky.BorderStyle = BorderStyle.None;
            selectStar.BorderStyle = BorderStyle.None;

            selected.BorderStyle = BorderStyle.Fixed3D;
        }

        private void backButton_OnClick(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void nextButton_OnClick(object sender, EventArgs e)
        {
            if (selectedCharacter == null)
            {
                MessageBox.Show("Please select a character before proceeding.");
                return;
            }

            GameForm gameForm = new GameForm(selectedCharacter);
            gameForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
