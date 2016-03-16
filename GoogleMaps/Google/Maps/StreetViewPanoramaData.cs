namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class StreetViewPanoramaData
    {
        public string Copyright;

        public string ImageData;

        public StreetViewLink[] Links;

        public StreetViewLocation Location;

        public StreetViewTileData Tiles;
    }
}