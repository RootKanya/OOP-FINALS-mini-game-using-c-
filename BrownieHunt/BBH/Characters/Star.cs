using System.Drawing;
using BrownieBakedHunt.Characters;

namespace BrownieBakedHunt.Characters
{
    public class Star : MainCharacter
    {
        public Star(Point startPosition) : base(startPosition) { }

        protected override void LoadSprites()
        {
            _walkFrames = new Image[]
            {
                Image.FromFile("Assets/Sky/frame1.png"),
                Image.FromFile("Assets/Sky/frame2.png"),
            };
        }
    }
}