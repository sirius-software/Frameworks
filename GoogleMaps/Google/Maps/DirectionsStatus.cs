namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum DirectionsStatus
    {
        [Name("INVALID_REQUEST")]
        InvalidRequest,

        [Name("MAX_WAYPOINTS_EXCEEDED")]
        MaxWaypointsExceeded,

        [Name("NOT_FOUND")]
        NotFound,

        [Name("OK")]
        Ok,

        [Name("OVER_QUERY_LIMIT")]
        OverQueryLimit,

        [Name("REQUEST_DENIED")]
        RequestDenied,

        [Name("UNKNOWN_ERROR")]
        UnknownError,

        [Name("ZERO_RESULTS")]
        ZeroResults,
    }
}
