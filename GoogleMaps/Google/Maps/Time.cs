namespace Bridge.Google.Maps
{
    using System;

    using Bridge;

    [External]
    [ObjectLiteral]
    public class Time
    {
        public string Text;

        [Name("time_zome")]
        public string TimeZone;

        public Date Value;
    }
}