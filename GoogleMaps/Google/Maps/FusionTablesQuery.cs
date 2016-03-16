namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class FusionTablesQuery
    {
        public string From;

        public int Limit;

        public int Offset;

        public string OrderBy;

        public string Select;

        public string Where;
    }
}