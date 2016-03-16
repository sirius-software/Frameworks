namespace Bridge.Google.Maps.Places
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class PlaceReview
    {
        public PlaceAspectRating[] Aspects;

        [Name("author_name")]
        public string AuthorName;

        [Name("author_url")]
        public string AuthorUrl;

        public string Language;

        public string Text;
    }
}