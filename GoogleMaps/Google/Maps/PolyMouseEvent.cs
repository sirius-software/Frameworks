namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class PolyMouseEvent : MouseEvent
    {
        public int Edge;

        public int Path;

        public int Vertex;
    }
}