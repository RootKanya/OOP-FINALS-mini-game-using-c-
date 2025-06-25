using System;
using System.Drawing;
using System.Windows.Forms;

namespace Brownie.GameObjects
{
    public class Wolf
    {
        private PictureBox pictureBox;
        private int speed = 2;
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

        // ✅ This exposes the Bounds property correctly
        public Rectangle Bounds => pictureBox.Bounds;

        public void Move(Size boundary)
        {
            pictureBox.Left += direction.X * speed;
            pictureBox.Top += direction.Y * speed;

            if (pictureBox.Left < 0 || pictureBox.Right > boundary.Width)
                direction.X *= -1;
            if (pictureBox.Top < 0 || pictureBox.Bottom > boundary.Height)
                direction.Y *= -1;
        }

        public void ChangeDirection()
        {
            direction = new Point(rng.Next(-1, 2), rng.Next(-1, 2));
            if (direction.X == 0 && direction.Y == 0)
                direction = new Point(1, 0);
        }
    }
}
