namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DirectionsGeocodedWaypoint
    {
        [Name("partial_match")]
        public bool PartialMatch;

        [Name("place_id")]
        public string PlaceId;

        public string[] Types;
    }
}