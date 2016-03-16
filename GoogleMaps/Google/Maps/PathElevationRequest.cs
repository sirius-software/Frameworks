namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class PathElevationRequest
    {
        public LatLng[] Path;

        public int Samples;
    }
}