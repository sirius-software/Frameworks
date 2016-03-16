namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DistanceMatrixResponse
    {
        public string[] DestinationAddresses;

        public string[] OriginAddresses;

        public DistanceMatrixResponseRow[] Rows;
    }
}