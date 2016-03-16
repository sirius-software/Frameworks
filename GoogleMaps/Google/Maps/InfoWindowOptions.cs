namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class InfoWindowOptions
    {
        public object Content;

        public bool DisableAutoPan;

        public int MaxWidth;

        public Size PixelOffset;

        public Any<LatLng, LatLngLiteral> Position;

        public int ZIndex;
    }
}