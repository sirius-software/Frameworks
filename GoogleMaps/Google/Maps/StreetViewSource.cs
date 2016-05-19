namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum StreetViewSource
    {
        [Name("DEFAULT")]
        Default,

        [Name("OUTDOOR")]
        Outdoor
    }
}