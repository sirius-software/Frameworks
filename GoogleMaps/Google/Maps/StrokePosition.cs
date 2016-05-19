namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum StrokePosition
    {
        [Name("CENTER")]
        Center,

        [Name("INSIDE")]
        Inside,

        [Name("OUTSIDE")]
        Outside,
    }
}
