namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    [Namespace("google.maps")]
    public class Map : MVCObject
    {
        public MVCArray<Node>[] Controls;

        public Data Data;

        public MapTypeRegistry MapTypes;

        public MVCArray<MapType> OverlayMapTypes;

        public extern Map(Node mapDiv, MapOptions opts = null);

        public extern void FitBounds(LatLngBounds bounds);

        public extern LatLngBounds GetBounds();

        public extern LatLng GetCenter();

        public extern Node GetDiv();

        public extern double GetHeading();

        public extern MapTypeId GetMapTypeId();

        public extern Projection GetProjection();

        public extern StreetViewPanorama GetStreetView();

        public extern double GetTilt();

        public extern int GetZoom();

        public extern void PanBy(double x, double y);

        public extern void PanTo(Any<LatLng, LatLngLiteral> latLng);

        public extern void PanToBounds(LatLngBounds latLngBounds);

        public extern void SetCenter(Any<LatLng, LatLngLiteral> latLng);

        public extern void SetHeading(double heading);

        public extern void SetMapTypeId(Any<string, MapTypeId> mapTypeId);

        public extern void SetOptions(MapOptions options);

        public extern void SetStreetView(StreetViewPanorama panorama);

        public extern void SetTilt(double tilt);

        public extern void SetZoom(int zoom);
    }
}