namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum MapTypeControlStyle
    {
        [Name("DEFAULT")]
        Default,

        [Name("DROPDOWN_MENU")]
        DropDownMenu,

        [Name("HORIZONTAL_BAR")]
        HorizontalBar
    }
}
