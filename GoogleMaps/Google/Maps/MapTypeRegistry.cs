namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class MapTypeRegistry : MVCObject
    {
        public extern void Set(string id, MapTypeId mapType);
    }
}