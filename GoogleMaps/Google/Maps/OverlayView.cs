namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class OverlayView : MVCObject
    {
        // TODO depends on usage can be field or method
        public extern void Draw();

        public extern Any<Map, StreetViewPanorama> GetMap();

        public extern MapPanes GetPanes();

        public extern MapCanvasProjection GetProjection();

        // TODO depends on usage can be field or method
        public extern void OnAdd();

        // TODO depends on usage can be field or method
        public extern void OnRemove();

        public extern void SetMap(Any<Map, StreetViewPanorama> map);
    }
}
