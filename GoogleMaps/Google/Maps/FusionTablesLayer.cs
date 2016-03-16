namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class FusionTablesLayer : MVCObject
    {
        public extern FusionTablesLayer(FusionTablesLayerOptions options);

        public extern Map GetMap();

        public extern void SetMap(Map map);

        public extern void SetOptions(FusionTablesLayerOptions options);
    }
}