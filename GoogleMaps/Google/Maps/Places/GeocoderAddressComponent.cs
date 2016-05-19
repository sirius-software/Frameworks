namespace Bridge.Google.Maps.Places
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class GeocoderAddressComponent
    {
        [Name("long_name")]
        public string LongName;

        [Name("short_name")]
        public string ShortName;

        public string[] Types;
    }
}