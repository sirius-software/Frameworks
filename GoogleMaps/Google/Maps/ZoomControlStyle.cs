namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum ZoomControlStyle
    {
        [Name("DEFAULT")]
        Default,

        [Name("LARGE")]
        Large,

        [Name("SMALL")]
        Small
    }
}
