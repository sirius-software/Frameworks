namespace Bridge.Google.Maps.Drawing
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DrawingManagerOptions
    {
        public CircleOptions CircleOptions;

        public bool DrawingControl;

        public DrawingControlOptions DrawingControlOptions;

        public OverlayType? DrawingMode;

        public Map Map;

        public MarkerOptions MarkerOptions;

        public PolygonOptions PolygonOptions;

        public PolylineOptions PolylineOptions;

        public RectangleOptions RectangleOptions;
    }
}