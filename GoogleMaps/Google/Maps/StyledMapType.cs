namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    [Namespace("google.maps")]
    public class StyledMapType : MVCObject, MapType
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

        public extern StyledMapType(MapTypeStyle[] styles, StyledMapTypeOptions options = null);

        [FieldProperty]
        public extern GetTileDelegate GetTile { get; set; }

        public extern void ReleaseTile(Node tile);
    }
}
