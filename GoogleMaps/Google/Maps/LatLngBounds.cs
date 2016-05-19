namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class LatLngBounds
    {
        public extern LatLngBounds(LatLng sw = null, LatLng ne = null);

        public extern bool Contains(LatLng latLng);

        public extern bool Equals(LatLngBounds other);

        public extern LatLngBounds Extend(LatLng point);

        public extern LatLng GetCenter();

        public extern LatLng GetNorthEast();

        public extern LatLng GetSouthWest();

        public extern bool Intersects(LatLngBounds other);

        public extern bool IsEmpty();

        public extern LatLng ToSpan();

        public extern override string ToString();

        public extern string ToUrlValue(double precision = 0);

        public extern LatLngBounds Union(LatLngBounds other);
    }
}