namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum DistanceMatrixStatus
    {
        [Name("INVALID_REQUEST")]
        InvalidRequest,

        [Name("MAX_DIMENSIONS_EXCEEDED")]
        MaxDimensionsExceeded,

        [Name("MAX_ELEMENTS_EXCEEDED")]
        MaxElementsExceeded,

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
