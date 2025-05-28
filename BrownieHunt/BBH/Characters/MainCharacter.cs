using System.Drawing;
using System.Windows.Forms;

namespace SpriteAnimation.Characters
{
    public abstract class MainCharacter
    {
        protected PictureBox _spriteBox;
        protected Image[] _walkFrames;
        protected int _currentFrame;
        protected Point _position;
        protected int _step = 10;
        protected Keys _currentDirection;
        protected bool _isWalking;

        public MainCharacter(Point startPosition)
        {
            _position = startPosition;
            _spriteBox = new PictureBox
            {
                Location = _position,
                Size = new Size(64, 64), // adjust to your sprite size
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            LoadSprites();
            UpdateSprite();
        }

        public PictureBox GetPictureBox() => _spriteBox;

        protected abstract void LoadSprites(); // to be implemented in derived classes

        public void Animate()
        {
            if (_isWalking)
            {
                _currentFrame = (_currentFrame + 1) % _walkFrames.Length;
                UpdateSprite();
                MoveInDirection();
            }
        }

        private void UpdateSprite()
        {
            _spriteBox.Image = _walkFrames[_currentFrame];
        }

        public void Walk(Keys direction, Size boundary)
        {
            _currentDirection = direction;
            _isWalking = true;
        }

        public void StopWalking()
        {
            _isWalking = false;
            _currentFrame = 0;
            UpdateSprite();
        }

        private void MoveInDirection()
        {
            Point newPosition = _spriteBox.Location;

            switch (_currentDirection)
            {
                case Keys.Left:
                    newPosition.X -= _step;
                    break;
                case Keys.Right:
                    newPosition.X += _step;
                    break;
                case Keys.Up:
                    newPosition.Y -= _step;
                    break;
                case Keys.Down:
                    newPosition.Y += _step;
                    break;
            }

            // Optional: boundary check
            newPosition.X = Math.Max(0, Math.Min(newPosition.X, 800 - _spriteBox.Width));
            newPosition.Y = Math.Max(0, Math.Min(newPosition.Y, 600 - _spriteBox.Height));

            _spriteBox.Location = newPosition;
        }
    }
}