namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;
    using System;

    [External]
    [Namespace("google.maps")]
    public class StreetViewPanorama : MVCObject
    {
        public MVCArray<Node>[] Controls;

        public extern StreetViewPanorama(Node containter, StreetViewPanoramaOptions opts = null);

        public extern StreetViewLink[] GetLinks();

        public extern StreetViewLocation GetLocation();

        public extern string GetPano();

        public extern StreetViewPov GetPhotographPov();

        public extern LatLng GetPosition();

        public extern StreetViewPov GetPov();

        public extern StreetViewStatus GetStatus();

        public extern bool GetVisible();

        public extern int GetZoom();

        public extern void RegisterPanoProvider(Func<string, StreetViewPanoramaData> provider);

        public extern void SetLinks(StreetViewLink[] links);

        public extern void SetOptions(StreetViewPanoramaOptions options);

        public extern void SetPano(string pano);

        public extern void SetPosition(Any<LatLngLiteral, LatLng> latLng);

        public extern void SetPov(StreetViewPov pov);

        public extern void SetVisible(bool flag);

        public extern void SetZoom(int zoom);
    }
}