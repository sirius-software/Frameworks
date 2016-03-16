namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MapTypeControlOptions
    {
        public string[] MapTypeIds;

        public ControlPosition Position;

        public MapTypeControlStyle Style;
    }
}