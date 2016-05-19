namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class Polygon : MVCObject
    {
        public extern Polygon(PolygonOptions opts = null);

        public extern bool GetDraggable();

        public extern bool GetEditable();

        public extern Map GetMap();

        public extern MVCArray<LatLng> GetPath();

        public extern MVCArray<MVCArray<LatLng>> GetPaths();

        public extern bool GetVisible();

        public extern void SetDraggable(bool flag);

        public extern void SetEditable(bool flag);

        public extern void SetMap(Map map);

        public extern void SetOptions(PolygonOptions options);

        public extern void SetPath(Any<LatLngLiteral[], LatLng[], MVCArray<LatLng>> path);

        public extern void SetPaths(Any<MVCArray<LatLng>, LatLng[], LatLngLiteral[], LatLng[][], LatLngLiteral[][], MVCArray<MVCArray<LatLng>>> path);

        public extern void SetVisible(bool visible);
    }
}