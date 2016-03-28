namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    [ObjectLiteral]
    public class InfoWindowOptions
    {
        public Any<string, Node> Content;

        public bool DisableAutoPan;

        public int MaxWidth;

        public Size PixelOffset;

        public Any<LatLng, LatLngLiteral> Position;

        public int ZIndex;
    }
}
