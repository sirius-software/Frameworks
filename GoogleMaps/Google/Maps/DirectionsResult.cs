namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DirectionsResult
    {
        [Name("geocoded_waypoints")]
        public DirectionsGeocodedWaypoint[] GeocodedWaypoints;

        public DirectionsRoute[] Routes;
    }
}