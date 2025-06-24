using System.Drawing;
using System.Windows.Forms;

namespace Brownie.GameObjects
{
    public class Character
    {
        private PictureBox pictureBox;
        private int speed = 5;

        public Character(Point location, Size size, Image sprite)
        {
            pictureBox = new PictureBox
            {
                Image = sprite,
                Size = size,
                Location = location,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        }

        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }

        public Rectangle Bounds => pictureBox.Bounds;

        public void Move(Size clientSize)
        {
            var newLocation = pictureBox.Location;

            if (Core.IsUp && newLocation.Y > 0)
                newLocation.Y -= speed;
            if (Core.IsDown && newLocation.Y + pictureBox.Height < clientSize.Height)
                newLocation.Y += speed;
            if (Core.IsLeft && newLocation.X > 0)
                newLocation.X -= speed;
            if (Core.IsRight && newLocation.X + pictureBox.Width < clientSize.Width)
                newLocation.X += speed;

            pictureBox.Location = newLocation;
        }
    }
}
