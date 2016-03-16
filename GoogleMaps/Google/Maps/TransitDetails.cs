namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class TransitDetails
    {
        [Name("arrival_stop")]
        public TransitStop ArrivalStop;

        [Name("arrival_time")]
        public Time ArrivalTime;

        [Name("departure_stop")]
        public TransitStop DepartureStop;

        [Name("departure_time")]
        public Time DepartureTime;

        public string Headsign;

        public double Headway;

        public TransitLine Line;

        [Name("num_stops")]
        public int NumStops;
    }
}