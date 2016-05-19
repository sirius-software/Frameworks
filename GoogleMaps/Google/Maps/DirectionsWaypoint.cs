namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DirectionsWaypoint
    {
        public Any<string, LatLng, Place> Location;

        public bool Stopover;
    }
}