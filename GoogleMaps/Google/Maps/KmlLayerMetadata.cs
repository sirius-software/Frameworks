namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class KmlLayerMetadata
    {
        public KmlAuthor Author;

        public string Description;

        public bool HasScreenOverlays;

        public string Name;

        public string Snippet;
    }
}