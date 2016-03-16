namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    [Namespace("google.maps")]
    public class Marker : MVCObject
    {
        [Name("MAX_ZINDEX")]
        public const int MaxZIndex = 0;

        public extern Marker();

        public extern Marker(MarkerOptions opts);

        public extern Animation GetAnimation();

        public extern Attribution GetAttribution();

        public extern bool GetClickable();

        public extern string GetCursor();

        public extern bool GetDraggable();

        public extern Any<string, Icon, Symbol> GetIcon();

        public extern MarkerLabel GetLabel();

        public extern Any<Map, StreetViewPanorama> GetMap();

        public extern double GetOpacity();

        public extern MarkerPlace GetPlace();

        public extern LatLng GetPosition();

        public extern MarkerShape GetShape();

        public extern string GetTile();

        public extern bool GetVisible();

        public extern int GetZIndex();

        public extern void SetAnimation(AnimationDirection animation);

        public extern void SetAttribution(Attribution attribution);

        public extern void SetClickable(bool flag);

        public extern void SetCursor(string cursor);

        public extern void SetDraggable(bool flag);

        public extern void SetIcon(Any<string, Icon, Symbol> icon);

        public extern void SetLabel(Any<string, MarkerLabel> label);

        public extern void SetMap(Any<StreetViewPanorama, Map> map);

        public extern void SetOpacity(double opacity);

        public extern void SetOptions(MarkerOptions options);

        public extern void SetPlace(MarkerPlace place);

        public extern void SetPosition(Any<LatLng, LatLngLiteral> latLng);

        public extern void SetShape(MarkerShape shape);

        public extern void SetTile(string tile);

        public extern void SetVisible(bool visible);

        public extern void SetZIndex(int zIndex);
    }
}