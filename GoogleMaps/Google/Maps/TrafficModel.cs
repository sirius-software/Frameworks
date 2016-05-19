namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TrafficModel
    {
        [Name("BEST_GUESS")]
        BestGuess,

        [Name("OPTIMISTIC")]
        Optimistic,

        [Name("PESSIMISTIC")]
        Pesimistic
    }
}
