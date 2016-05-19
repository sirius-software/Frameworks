namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    [Namespace("google.maps")]
    public class InfoWindow
    {
        public extern InfoWindow(InfoWindowOptions opts = null);

        public extern void Close();

        public extern Any<string, Node> GetContent();

        public extern LatLng GetPosition();

        public extern void Open(Any<StreetViewPanorama, Map> map = null, MVCObject anchor = null);

        public extern void SetContent(Any<string, Node> content);

        public extern void SetPosition(Any<LatLng, LatLngLiteral> position);

        public extern void SetZIndex(int zIndex);
    }
}