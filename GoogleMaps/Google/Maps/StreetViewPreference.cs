namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum StreetViewPreference
    {
        [Name("BEST")]
        Best,

        [Name("NEAREST")]
        Nearest
    }
}
