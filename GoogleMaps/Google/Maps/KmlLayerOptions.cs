namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class KmlLayerOptions
    {
        public bool Clickable;

        public Map Map;

        public bool PreserveViewport;

        public bool ScreenOverlays;

        public bool SuppressInfoWindows;

        public string Url;

        public int ZIndex;
    }
}