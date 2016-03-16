namespace Bridge.Google.Maps.Geometry
{
    using Bridge;
    using Bridge.Google.Maps;

    [External]
    [Name("google.maps.geometry.poly")]
    [Namespace(false)]
    public static class Poly
    {
        public static extern bool ContainsLocation(LatLng location, Polygon poly);

        public static extern bool IsLocationOnEdge(LatLng point, Any<Polygon, Polyline> poly, double tolerance = 0);
    }
}