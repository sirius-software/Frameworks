namespace Bridge.Google.Maps.Drawing
{
    using Bridge;

    [External]
    [Namespace("google.maps.drawing")]
    public class DrawingManager : MVCObject
    {
        public extern DrawingManager(DrawingManagerOptions options = null);

        public extern OverlayType GetDrawingMode();

        public extern Map GetMap();

        public extern void SetDrawingMode(OverlayType? drawingMode);

        public extern void SetMap(Map map);

        public extern void SetOptions(DrawingManagerOptions options);
    }
}