namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum SymbolPath
    {
        [Name("ACKWARD_CLOSED_ARROW")]
        AckwardClosedArrow,

        [Name("BACKWARD_OPEN_ARROW")]
        BackwardOpenArrow,

        [Name("CIRCLE")]
        Circle,

        [Name("FORWARD_CLOSED_ARROW")]
        ForwardClosedArrow,

        [Name("FORWARD_OPEN_ARROW")]
        ForwardOpenedArrow
    }
}
