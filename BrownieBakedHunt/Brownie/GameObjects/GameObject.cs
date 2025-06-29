using System.Drawing;
using System.Windows.Forms;

namespace Brownie.GameObjects
{
    public abstract class GameObject
    {
        protected PictureBox pictureBox;
        protected int speed;

        public GameObject(Point startPosition, Size size, Image sprite, int speed = 5)
        {
            this.speed = speed;

            pictureBox = new PictureBox
            {
                Size = size,
                Location = startPosition,
                Image = sprite,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
        }

        public PictureBox GetPictureBox() => pictureBox;

        public Rectangle Bounds => pictureBox.Bounds;

        public abstract void Move(Size boundary);
    }
}
