namespace Gm.NET
{
    using System.Drawing;
    public static class CenterForm
    {
        public static Point Function(int Width, int pCWidth)
        {
            int x = Width / 2;
            int x1 = pCWidth / 2;
            int resp = x - x1;
            return new Point(resp, 0);
        }
    }
}
