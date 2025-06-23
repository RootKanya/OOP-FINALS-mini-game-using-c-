using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brownie.GameObjects
{
    public class Character
    {
        private PictureBox _playerPictureBox;
        private Image _sprite;

        public Character(Point startPosition, Size size, Image sprite)
        {
            _sprite = sprite;

            _playerPictureBox = new PictureBox
            {
                Size = size,
                Location = startPosition,
                Image = _sprite,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
        }

        public PictureBox GetPictureBox() => _playerPictureBox;

        public void Move(Size boundary)
        {
            int speed = 5;

            if (Core.IsLeft && _playerPictureBox.Left > 0)
                _playerPictureBox.Left -= speed;

            if (Core.IsRight && _playerPictureBox.Right < boundary.Width)
                _playerPictureBox.Left += speed;

            if (Core.IsUp && _playerPictureBox.Top > 0)
                _playerPictureBox.Top -= speed;

            if (Core.IsDown && _playerPictureBox.Bottom < boundary.Height)
                _playerPictureBox.Top += speed;
        }

    }

}
