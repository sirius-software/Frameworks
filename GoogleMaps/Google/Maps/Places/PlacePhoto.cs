namespace Bridge.Google.Maps.Places
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class PlacePhoto
    {
        public GetUrlDelegate GetUrl;

        public int Height;

        [Name("html_attributions")]
        public string[] HtmlAttributions;

        public int Width;
    }
}