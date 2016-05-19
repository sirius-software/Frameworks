namespace Bridge.Google.Maps.Places
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class PlaceResult
    {
        [Name("address_components")]
        public GeocoderAddressComponent[] AddressComponents;

        public PlaceAspectRating[] Aspects;

        [Name("formatted_address")]
        public string FormattedAddress;

        [Name("formatted_phone_number")]
        public string FormattedPhoneNumber;

        public PlaceGeometry Geometry;

        [Name("html_attributions")]
        public string[] HtmlAttributions;

        public string Icon;

        [Name("International_phone_number")]
        public string InternationalPhoneNumber;

        public string Name;

        [Name("permamently_closed")]
        public bool PermamentlyClosed;

        public PlacePhoto[] Photos;

        [Name("place_id")]
        public string Place_id;

        [Name("price_level")]
        public int PriceLevel;

        public double Rating;

        public PlaceReview[] Reviews;

        public string[] Types;

        public string URLSearchParams;

        [Name("utc_offset")]
        public double UtcOffset;

        public string Vicinity;

        public string Website;
    }
}