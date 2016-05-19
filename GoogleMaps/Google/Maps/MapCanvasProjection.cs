namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class MapCanvasProjection : MVCObject
    {
        public extern LatLng FromContainerPixelToLatLng(Point pixel, bool nowrap = false);

        public extern LatLng FromDivPixelToLatLng(Point pixel, bool nowrap = false);

        public extern Point FromLatLngToContainerPixel(LatLng latLng);

        public extern Point FromLatLngToDivPixel(LatLng latLng);

        public extern double GetWorldWidth();
    }
}