namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class Rectangle : MVCObject
    {
        public extern Rectangle(RectangleOptions opts = null);

        public extern LatLngBounds GetBounds();

        public extern bool GetDraggable();

        public extern bool GetEditable();

        public extern Map GetMap();

        public extern bool GetVisible();

        public extern void SetBounds(LatLngBounds bounds);

        public extern void SetDraggable(bool flag);

        public extern void SetEditable(bool flag);

        public extern void SetMap(Map map);

        public extern void SetOptions(RectangleOptions options);

        public extern void SetVisible(bool visible);
    }
}