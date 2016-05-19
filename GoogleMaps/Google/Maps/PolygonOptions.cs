namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class PolygonOptions
    {
        public bool Clickable;

        public bool Draggable;

        public bool Editable;

        public string FillColor;

        public double FillOpacity;

        public bool Geodesic;

        public Map Map;

        public Any<MVCArray<MVCArray<LatLng>>, MVCArray<LatLng>, LatLng[][], LatLngLiteral[][], LatLng[], LatLngLiteral[]> Paths;

        public string StrokeColor;

        public double StrokeOpacity;

        public StrokePosition StrokePosition;

        public double StrokeWeight;

        public bool Visible;

        public int ZIndex;
    }
}