namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DirectionsLeg
    {
        [Name("arrival_time")]
        public Time ArrivalTime;

        [Name("departure_time")]
        public Time DepartureTime;

        public Distance Distance;

        public Duration Duration;

        [Name("duration_in_traffic")]
        public Duration DurationInTraffic;

        [Name("end_address")]
        public string EndAddress;

        [Name("end_location")]
        public LatLng EndLocation;

        [Name("start_address")]
        public string StartAddress;

        [Name("start_location")]
        public LatLng StartLocation;

        public DirectionsStep[] Steps;

        [Name("via_waypoints")]
        public LatLng[] ViaWaypoints;
    }
}