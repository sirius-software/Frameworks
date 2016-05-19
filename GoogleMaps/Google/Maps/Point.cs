namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class Point
    {
        public double X;

        public double Y;

        public extern Point(double x, double y);

        public extern bool Equals(Point other);

        public extern override string ToString();
    }
}
