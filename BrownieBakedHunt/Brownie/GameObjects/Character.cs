using System.Drawing;
using System.Windows.Forms;

namespace Brownie.GameObjects
{
    public class Character : GameObject
    {
        public Character(Point position, Size size, Image sprite)
            : base(position, size, sprite, speed: 5)
        {
        }

        public override void Move(Size clientSize)
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
