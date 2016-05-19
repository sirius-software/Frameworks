namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TransitMode
    {
        [Name("BUS")]
        Bus,

        [Name("RAIL")]
        Rail,

        [Name("SUBWAY")]
        Subway,

        [Name("TRAIN")]
        Train,

        [Name("TRAM")]
        Tram,
    }
}
