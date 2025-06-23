using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brownie.GameObjects
{
    public class Wolf
    {
        private PictureBox pictureBox;
        private int speed = 3;
        private Point direction;
        private Random rng = new Random();

        public Wolf(Point startPos, Size size, Image sprite)
        {
            pictureBox = new PictureBox
            {
                Location = startPos,
                Size = size,
                Image = sprite,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };

            ChangeDirection();
        }

        public PictureBox GetPictureBox() => pictureBox;

        public void Move(Size boundary)
        {
            // Update posisi
            pictureBox.Left += direction.X * speed;
            pictureBox.Top += direction.Y * speed;

            // Cek batas window
            if (pictureBox.Left < 0 || pictureBox.Right > boundary.Width)
                direction.X *= -1;
            if (pictureBox.Top < 0 || pictureBox.Bottom > boundary.Height)
                direction.Y *= -1;
        }

        public void ChangeDirection()
        {
            // Arah acak: (-1, 0, 1)
            direction = new Point(rng.Next(-1, 2), rng.Next(-1, 2));

            // Hindari diam total
            if (direction.X == 0 && direction.Y == 0)
                direction = new Point(1, 0);
        }
    }
}
