using System.Windows.Forms;

namespace Brownie
{
    public static class Core
    {
        public readonly static Keys KeyUp = Keys.W;
        public readonly static Keys KeyDown = Keys.S;
        public readonly static Keys KeyLeft = Keys.A;
        public readonly static Keys KeyRight = Keys.D;

        public static bool IsUp = false;
        public static bool IsDown = false;
        public static bool IsLeft = false;
        public static bool IsRight = false;
    }
}
