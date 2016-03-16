namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class Symbol
    {
        public Point Anchor;

        public string FillColor;

        public double FillOpacity;

        public Point LabelOrigin;

        public Any<SymbolPath, string> Path;

        public double Rotation;

        public double Scale;

        public string StrokeColor;

        public double StrokeOpacity;

        public double StrokeWeight;
    }
}