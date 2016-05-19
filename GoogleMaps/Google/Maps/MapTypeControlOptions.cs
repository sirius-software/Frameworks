namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MapTypeControlOptions
    {
        public Any<string, MapTypeId>[] MapTypeIds;

        public ControlPosition Position;

        public MapTypeControlStyle Style;
    }
}
