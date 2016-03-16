namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum StreetViewStatus
    {
        [Name("OK")]
        Ok,

        [Name("UNKNOWN_ERROR")]
        UnknownError,

        [Name("ZERO_RESULTS")]
        ZeroResults
    }
}