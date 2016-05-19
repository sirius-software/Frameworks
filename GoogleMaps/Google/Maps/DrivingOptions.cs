namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    [External]
    [ObjectLiteral]
    public class DrivingOptions
    {
        public Date DepartureTime;

        public TrafficModel TrafficModel;
    }
}