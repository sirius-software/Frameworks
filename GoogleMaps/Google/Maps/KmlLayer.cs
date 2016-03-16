namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class KmlLayer : MVCObject
    {
        public extern KmlLayer(KmlLayerOptions options = null);

        public extern LatLngBounds GetDefaultViewport();

        public extern Map GetMap();

        public extern KmlLayerMetadata GetMetadata();

        public extern KmlLayerStatus GetStatus();

        public extern string GetUrl();

        public extern int GetZIndex();

        public extern void SetMap(Map map);

        public extern void SetUrl(string url);

        public extern void SetZIndex(int zIndex);
    }
}