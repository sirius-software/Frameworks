namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class LatLng
    {
        public extern LatLng(double lat, double lng, bool noWrap = false);

        public extern bool Equals(LatLng other);

        public extern double Lat();

        public extern double Lng();

        public extern override string ToString();

        public extern string ToUrlValue(double precision = 0);
    }
}