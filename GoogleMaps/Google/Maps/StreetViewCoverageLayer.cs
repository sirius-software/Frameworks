namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class StreetViewCoverageLayer : MVCObject
    {
        public extern Map GetMap();

        public extern void SetMap(Map map);
    }
}