namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class Polyline : MVCObject
    {
        public extern Polyline(PolylineOptions opts = null);

        public extern bool GetDraggable();

        public extern bool GetEditable();

        public extern Map GetMap();

        public extern MVCArray<LatLng> GetPath();

        public extern bool GetVisible();

        public extern void SetDraggable(bool flag);

        public extern void SetEditable(bool flag);

        public extern void SetMap(Map map);

        public extern void SetOptions(PolylineOptions options);

        public extern void SetPath(Any<LatLngLiteral[], LatLng[], MVCArray<LatLng>> path);

        public extern void SetVisible(bool visible);
    }
}