namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    public delegate string GetTileUrlDelegate(Point tileCoord, int zoom);

    [External]
    [Namespace("google.maps")]
    public class ImageMapType : MVCObject, MapType
    {
        [FieldProperty]
        public string Alt { get; set; }

        [FieldProperty]
        public int MaxZoom { get; set; }

        [FieldProperty]

        public int MinZoom { get; set; }

        [FieldProperty]
        public string Name { get; set; }

        [FieldProperty]
        public Projection Projection { get; set; }

        [FieldProperty]
        public double Radius { get; set; }

        [FieldProperty]
        public Size TileSize { get; set; }

        public extern ImageMapType(ImageMapTypeOptions opts);

        public extern double GetOpacity();

        // TODO depends on usage can be field or method
        [FieldProperty]
        public extern GetTileDelegate GetTile { get; set; }

        public extern void ReleaseTile(Node tile);

        public extern void SetOpacity(double opacity);
    }
}
