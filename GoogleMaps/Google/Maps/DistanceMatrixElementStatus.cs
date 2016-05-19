namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum DistanceMatrixElementStatus
    {
        [Name("NOT_FOUND")]
        NotFound,

        [Name("OK")]
        Ok,

        [Name("ZERO_RESULTS")]
        ZeroResults
    }
}
