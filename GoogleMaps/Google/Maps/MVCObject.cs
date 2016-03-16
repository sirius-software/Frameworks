namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    [External]
    [Namespace("google.maps")]
    public class MVCObject
    {
        public extern MapsEventListener AddListener(string name, Action handler);

        public extern void BindTo(string key, MVCObject target, string targetKey = null, bool noNotify = false);

        public extern void Changed(string key);

        public extern object Get(string key);

        public extern void Notify(string key);

        public extern void Set(string key, object value);

        public extern void SetValues(object values);

        public extern void Unbind(string key);

        public extern void UnbindAll();
    }
}