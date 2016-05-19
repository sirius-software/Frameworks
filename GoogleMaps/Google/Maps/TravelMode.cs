namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TravelMode
    {
        [Name("BICYCLING")]
        Bicycling,

        [Name("DRIVING")]
        Driving,

        [Name("TRANSIT")]
        Transit,

        [Name("WALKING")]
        Walking
    }
}
