namespace Bridge.Google.Maps.Geometry
{
    using Bridge;
    using Bridge.Google.Maps;

    [External]
    [Name("google.maps.geometry.encoding")]
    [Namespace(false)]
    public static class Encoding
    {
        public static extern LatLng[] DecodePath(string input);

        public static extern string EncodePath(Any<MVCArray<LatLng>, LatLng[]> path);
    }
}
