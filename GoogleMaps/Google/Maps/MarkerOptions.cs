namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MarkerOptions
    {
        public Point AnchorPoint;

        public Animation Animation;

        public Attribution Attribution;

        public bool Clickable;

        public bool CrossOnDrag;

        public string Cursor;

        public bool Draggable;

        public Any<string, Icon, Symbol> Icon;

        public Any<string, MarkerLabel> Label;

        public Any<Map, StreetViewPanorama> Map;

        public double Opacity;

        public bool Optimized;

        public MarkerPlace Place;

        public LatLng Position;

        public string Title;

        public bool Visible;

        public int ZIndex;
    }
}