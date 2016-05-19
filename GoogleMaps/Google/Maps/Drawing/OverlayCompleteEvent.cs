namespace Bridge.Google.Maps.Drawing
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class OverlayCompleteEvent
    {
        public Any<Marker, Polyline, Polygon, Circle, Rectangle> Overlay;

        public OverlayType Type;
    }
}