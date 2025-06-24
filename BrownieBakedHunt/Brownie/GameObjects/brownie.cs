using System.Drawing;
using System.Windows.Forms;

namespace Brownie.GameObjects
{
    public class BrownieItem
    {
        private PictureBox pictureBox;

        public BrownieItem(Point location, Size size, Image sprite)
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
    }
}
