namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class StreetViewTileData
    {
        // TODO depends on usage can be field or method
        public extern string GetTileUrl(string pano, int tileZoom, int tileX, int tileY);

        public double CenterHeading;

        public Size TileSize;

        public Size WorldSize;
    }
}
