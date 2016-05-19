namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class Circle : MVCObject
    {
        public extern Circle(CircleOptions opts = null);

        public extern LatLngBounds GetBounds();

        public extern LatLng GetCenter();

        public extern bool GetDraggable();

        public extern bool GetEditable();

        public extern Map GetMap();

        public extern double GetRadius();

        public extern bool GetVisible();

        public extern void SetCenter(Any<LatLngLiteral, LatLng> center);

        public extern void SetDraggable(bool draggable);

        public extern void SetEditable(bool editable);

        public extern void SetMap(Map map);

        public extern void SetOptions(CircleOptions options);

        public extern void SetRadius(double radius);

        public extern void SetVisible(bool visible);
    }
}
