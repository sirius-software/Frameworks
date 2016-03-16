namespace Bridge.Google.Maps.Drawing
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps.drawing")]
    public enum OverlayType
    {
        [Name("CIRCLE")]
        Circle,

        [Name("MARKER")]
        Marker,

        [Name("POLYGON")]
        Polygon,

        [Name("POLYLINE")]
        Polyline,

        [Name("RECTANGLE")]
        Rectangle
    }
}