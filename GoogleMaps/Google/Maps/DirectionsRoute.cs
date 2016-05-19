namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DirectionsRoute
    {
        public LatLngBounds Bounds;

        public string Copyrights;

        public TransitFare Fare;

        public DirectionsLeg[] Legs;

        [Name("overview_path")]
        public LatLng[] OverviewPath;

        [Name("overview_polyline")]
        public string OverviewPolyline;

        public string[] Warnings;

        [Name("waypoint_order")]
        public int[] WaypointOrder;
    }
}