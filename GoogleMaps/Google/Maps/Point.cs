namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class Point
    {
        public int X;

        public int Y;

        public extern Point(int x, int y);

        public extern bool Equals(Point other);

        public extern override string ToString();
    }
}