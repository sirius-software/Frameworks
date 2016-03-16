namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    public interface Projection
    {
        // TODO depends on usage can be field or method
        Point FromLatLngToPoint(LatLng latLng, Point point = null);

        // TODO depends on usage can be field or method
        LatLng FromPointToLatLng(Point pixel, bool nowrap = false);
    }
}
