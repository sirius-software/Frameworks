namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class Size
    {
        public int Height;

        public int Width;

        public extern Size(int width, int height, string widthUnit = null, string heightUnit = null);

        public extern bool Equals(Size other);

        public extern override string ToString();
    }
}