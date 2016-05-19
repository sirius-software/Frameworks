namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    [External]
    [Namespace("google.maps")]
    public class DirectionsService
    {
        public extern void Route(DirectionsRequest request, Action<DirectionsResult, DirectionsStatus> callback);
    }
}