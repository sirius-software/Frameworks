namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum UnitSystem
    {
        [Name("IMPERIAL")]
        Imperial,

        [Name("METRIC")]
        Metric
    }
}
