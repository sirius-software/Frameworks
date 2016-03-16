namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TransitRoutePreference
    {
        [Name("FEWER_TRANSFERS")]
        FewerTransfers,

        [Name("LESS_WALKING")]
        LessWalking
    }
}
