namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    public delegate Node GetTileDelegate(Point tileCoord, int zoom, dynamic ownerDocument);

    [External]
    public interface MapType
    {
        [FieldProperty]
        string Alt { get; set; }

        [FieldProperty]
        int MaxZoom { get; set; }

        [FieldProperty]
        int MinZoom { get; set; }

        [FieldProperty]
        string Name { get; set; }

        [FieldProperty]
        Projection Projection { get; set; }

        [FieldProperty]
        double Radius { get; set; }

        [FieldProperty]
        Size TileSize { get; set; }

        // TODO depends on usage can be field or method
        [FieldProperty]
        GetTileDelegate GetTile { get; set; }

        void ReleaseTile(Node tile);
    }
}
