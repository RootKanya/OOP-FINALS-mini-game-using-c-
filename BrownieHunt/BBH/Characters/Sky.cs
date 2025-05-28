using System.Drawing;
using BrownieBakedHunt.Characters;

namespace BrownieBakedHunt.Characters
{
    public class Sky : MainCharacter
    {
        public Sky(Point startPosition) : base(startPosition) { }

        protected override void LoadSprites()
        {
            _walkFrames = new Image[]
            {
                Image.FromFile("Assets/Sky/frame1.png"),
                Image.FromFile("Assets/Sky/frame2.png"),
                // Add more frames if needed
            };
        }
    }
}