namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum ElevationStatus
    {
        [Name("INVALID_REQUEST")]
        InvalidRequest,

        [Name("OK")]
        Ok,

        [Name("OVER_QUERY_LIMIT")]
        OverQueryLimit,

        [Name("REQUEST_DENIED")]
        RequestDenied,

        [Name("UNKNOWN_ERROR")]
        UnknownError
    }
}
