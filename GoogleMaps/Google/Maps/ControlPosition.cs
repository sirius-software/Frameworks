namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum ControlPosition
    {
        [Name("BOTTOM_CENTER")]
        BottomCenter,

        [Name("BOTTOM_LEFT")]
        BottomLeft,

        [Name("BOTTOM_RIGHT")]
        BottomRight,

        [Name("LEFT_BOTTOM")]
        LeftBottom,

        [Name("LEFT_CENTER")]
        LeftCenter,

        [Name("LEFT_TOP")]
        LeftTop,

        [Name("RIGHT_BOTTOM")]
        RightBottom,

        [Name("RIGHT_CENTER")]
        RightCenter,

        [Name("RIGHT_TOP")]
        RightTop,

        [Name("TOP_CENTER")]
        TopCenter,

        [Name("TOP_LEFT")]
        TopLeft,

        [Name("TOP_RIGHT")]
        TopRight
    }
}
