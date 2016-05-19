namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MapTypeStyler
    {
        public string Color;

        public double Gamma;

        public string Hue;

        [Name("invert_lightness")]
        public bool InvertLightness;

        public double Lightness;

        public double Saturation;

        public string Visibility;

        public double Weight;
    }
}