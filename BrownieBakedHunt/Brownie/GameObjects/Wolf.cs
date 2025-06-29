using System.Drawing;
using System.Windows.Forms;

namespace Brownie.GameObjects
{
    public class Wolf : GameObject
    {
        private Point direction;

        public Wolf(Point position, Size size, Image sprite)
            : base(position, size, sprite, speed: 3)
        {
            // arah awal random: horizontal atau vertikal
            direction = new Point(1, 1);
        }

        public override void Move(Size boundary)
        {
            pictureBox.Left += direction.X * speed;
            pictureBox.Top += direction.Y * speed;

            if (pictureBox.Left < 0 || pictureBox.Right > boundary.Width)
                direction.X *= -1;
            if (pictureBox.Top < 0 || pictureBox.Bottom > boundary.Height)
                direction.Y *= -1;
        }
    }
}
