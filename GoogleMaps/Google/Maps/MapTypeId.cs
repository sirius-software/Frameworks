namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum MapTypeId
    {
        [Name("HYBRID")]
        Hybrid,

        [Name("ROADMAP")]
        Roadmap,

        [Name("SATELLITE")]
        Satellite,

        [Name("TERRIAN")]
        Terrian
    }
}
