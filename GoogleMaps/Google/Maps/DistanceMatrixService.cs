namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    [External]
    [Namespace("google.maps")]
    public class DistanceMatrixService
    {
        public extern void GetDistanceMatrix(DistanceMatrixRequest request, Action<DistanceMatrixResponse, DistanceMatrixStatus> callback);
    }
}