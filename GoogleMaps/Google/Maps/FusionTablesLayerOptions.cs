namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    [Namespace("google.maps")]
    public class FusionTablesLayerOptions
    {
        public bool Clickable;

        public FusionTablesHeatmap Heatmap;

        public Map Map;

        public FusionTablesQuery Query;

        public FusionTablesStyle[] Styles;

        public bool SuppressInfoWindows;
    }
}