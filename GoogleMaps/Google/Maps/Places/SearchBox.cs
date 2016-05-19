namespace Bridge.Google.Maps.Places
{
    using Bridge;
    using Bridge.Html5;
    using Bridge.Google.Maps;

    public delegate string GetUrlDelegate(PhotoOptions opts);

    [External]
    [Namespace("google.maps.places")]
    public class SearchBox : MVCObject
    {
        public extern SearchBox(InputElement inputField, SearchBoxOptions opts = null);

        public extern LatLngBounds GetBounds();

        public extern PlaceResult[] GetPlaces();

        public extern void SetBounds(Any<LatLngBounds, LatLngBoundsLiteral> bounds);
    }
}