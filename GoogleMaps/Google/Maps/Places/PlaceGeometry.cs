namespace Bridge.Google.Maps.Places
{
    using Bridge;
    using Bridge.Google.Maps;

    [External]
    [ObjectLiteral]
    public class PlaceGeometry
    {
        public LatLng Location;

        public LatLngBounds Viewport;
    }
}