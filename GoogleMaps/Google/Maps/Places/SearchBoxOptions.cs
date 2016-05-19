namespace Bridge.Google.Maps.Places
{
    using Bridge;
    using Bridge.Google.Maps;

    [External]
    [ObjectLiteral]
    public class SearchBoxOptions
    {
        public Any<LatLngBounds, LatLngBoundsLiteral> Bounds;
    }
}