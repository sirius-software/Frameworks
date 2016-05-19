namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class ImageMapTypeOptions
    {
        public string Alt;

        public GetTileUrlDelegate GetTileUrl;

        public int MaxZoom;

        public int MinZoom;

        public string Name;

        public double Opacity;

        public Size TileSize;
    }
}