namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class StreetViewLocationRequest
    {
        public Any<LatLng, LatLngLiteral> Location;

        public StreetViewPreference Preference;

        public double Radius;

        public StreetViewSource Source;
    }
}
