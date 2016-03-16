namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    [External]
    [Namespace("google.maps")]
    public class ElevationService
    {
        public extern void GetElevationAlongPath(PathElevationRequest request, Action<ElevationResult[], ElevationStatus> callback);

        public extern void GetElevationForLocations(LocationElevationRequest request, Action<ElevationResult[], ElevationStatus> callback);
    }
}