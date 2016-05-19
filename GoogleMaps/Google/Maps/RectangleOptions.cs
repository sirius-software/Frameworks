namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class RectangleOptions
    {
        public LatLngBounds Bounds;

        public bool Clickable;

        public bool Draggable;

        public bool Editable;

        public string FillColor;

        public double FillOpacity;

        public Map Map;

        public string StrokeColor;

        public double StrokeOpacity;

        public StrokePosition StrokePosition;

        public double StrokeWeight;

        public bool Visible;

        public int ZIndex;
    }
}