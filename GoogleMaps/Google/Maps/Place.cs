namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class Place
    {
        public Any<LatLng, LatLngLiteral> Location;

        public string PlaceId;

        public string Query;
    }
}