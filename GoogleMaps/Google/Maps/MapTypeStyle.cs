namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MapTypeStyle
    {
        public MapTypeStyleElementType ElementType;

        public MapTypeStyleFeatureType FeatureType;

        public MapTypeStyler[] Stylers;
    }
}