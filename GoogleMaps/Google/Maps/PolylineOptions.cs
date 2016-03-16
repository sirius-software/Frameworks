namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class PolylineOptions
    {
        public bool Clickable;

        public bool Draggable;

        public bool Editable;

        public bool Geodesic;

        public IconSequence[] Icons;

        public Map Map;

        public Any<MVCArray<LatLng>, LatLng[], LatLngLiteral[]> Path;

        public string StrokeColor;

        public double StrokeOpacity;

        public double StrokeWeight;

        public bool Visible;

        public int ZIndex;
    }
}