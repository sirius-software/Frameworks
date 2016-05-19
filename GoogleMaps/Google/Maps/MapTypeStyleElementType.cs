namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum MapTypeStyleElementType
    {
        [Name("all")]
        All,

        [Name("geometry")]
        Geometry,

        [Name("geometry.fill")]
        GeometryFill

        // TODO
    }
}
