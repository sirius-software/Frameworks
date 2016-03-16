namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DistanceMatrixResponseElement
    {
        public Distance Distance;

        public Duration Duration;

        [Name("duration_in_traffic")]
        public Duration DurationInTraffic;

        public TransitFare Fare;

        public DistanceMatrixElementStatus Status;
    }
}
