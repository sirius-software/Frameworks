namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    [External]
    [Name("google.maps.event")]
    [Namespace(false)]
    public static class Event
    {
        public static extern MapsEventListener AddDomListener(object instance, string eventName, Action handler, bool capture = false);

        public static extern MapsEventListener AddDomListener<T>(object instance, string eventName, Action<T> handler, bool capture = false);

        public static extern MapsEventListener AddDomListenerOnce(object instance, string eventName, Action handler, bool capture = false);

        public static extern MapsEventListener AddDomListenerOnce<T>(object instance, string eventName, Action<T> handler, bool capture = false);

        public static extern MapsEventListener AddListener<T>(object instance, string eventName, T handler);

        public static extern MapsEventListener AddListener(object instance, string eventName, Action handler);

        public static extern MapsEventListener AddListener<T>(object instance, string eventName, Action<T> handler);

        public static extern MapsEventListener AddListener<T, U>(object instance, string eventName, Action<T, U> handler);

        public static extern MapsEventListener AddListenerOnce<T>(object instance, string eventName, T handler);

        public static extern MapsEventListener AddListenerOnce(object instance, string eventName, Action handler);

        public static extern MapsEventListener AddListenerOnce<T>(object instance, string eventName, Action<T> handler);

        public static extern MapsEventListener AddListenerOnce<T, U>(object instance, string eventName, Action<T, U> handler);

        public static extern void ClearInstanceListeners(object instance);

        public static extern void ClearListeners(object instance, string eventName);

        public static extern void RemoveListener(MapsEventListener listener);

        public static extern void Trigger(object instance, string eventName, params object[] args);
    }
}
