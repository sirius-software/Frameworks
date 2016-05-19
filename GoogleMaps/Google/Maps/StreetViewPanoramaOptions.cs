namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class StreetViewPanoramaOptions
    {
        public bool AddressControl;

        public StreetViewAddressControlOptions AddressControlOptions;

        public bool ClickToGo;

        public bool DisableDefaultUI;

        public bool DisableDoubleClickZoom;

        public bool EnableCloseButton;

        public bool ImageDateControl;

        public bool LinksControl;

        public bool PanControl;

        public PanControlOptions PanControlOptions;

        public string Pano;

        public StreetViewPanoramaData PanoProvider;

        public Any<LatLng, LatLngLiteral> Position;

        public StreetViewPov Pov;

        public bool Scrollwheell;

        public bool Visible;

        public bool ZoomControl;

        public ZoomControlOptions ZoomControlOptions;
    }
}
