namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MapOptions
    {
        public string BackgroundColor;

        public LatLng Center;

        public bool DisableDefaultUI;

        public bool DisableDoubleClickZoom;

        public bool Draggable;

        public string DraggableCursor;

        public string DraggingCursor;

        public double Heading;

        public bool KayboardShorcuts;

        public bool MapMarker;

        public bool MapTypeControl;

        public MapTypeControlOptions MapTypeControlOptions;

        public MapTypeId MapTypeId;

        public int MaxZoom;

        public int MinZoom;

        public bool NoClear;

        public bool OverviewMapControl;

        public OverviewMapControlOptions OverviewMapControlOptions;

        public bool PanControl;

        public PanControlOptions PanControlOptions;

        public bool RotateControl;

        public RotateControlOptions RotateControlOptions;

        public bool ScaleControl;

        public ScaleControlOptions ScaleControlOptions;

        public bool Scrollwheel;

        public StreetViewPanorama StreetView;

        public bool StreetViewControl;

        public StreetViewControlOptions StreetViewControlOptions;

        public MapTypeStyle[] Styles;

        public double Tilt;

        public int Zoom;

        public bool ZoomControl;

        public ZoomControlOptions ZoomControlOptions;
    }
}