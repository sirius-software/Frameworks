namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum Animation
    {
        [Name("BOUNCE")]
        Bounce,

        [Name("DROP")]
        Drop,
    }
}
