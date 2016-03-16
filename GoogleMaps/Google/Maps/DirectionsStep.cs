namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DirectionsStep
    {
        public Distance Distance;

        public Duration Duration;

        [Name("end_location")]
        public LatLng EndLocation;

        public string Instructions;

        public LatLng[] Path;

        [Name("start_location")]
        public LatLng StartLocation;

        public DirectionsStep[] Steps;

        public TransitDetails Transit;

        public TravelMode TravelMode;
    }
}