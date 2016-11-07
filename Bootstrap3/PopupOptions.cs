using Bridge.Html5;
using System;

namespace Bridge.Bootstrap3
{
    /// <summary>
    /// Tooltip/popover delay
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PopupDelay
    {
        /// <summary>
        /// A delay for hiding of a tooltip/popover
        /// </summary>
        public virtual int Hide
        {
            get;
            set;
        }

        /// <summary>
        /// A delay for showing of a tooltip/popover
        /// </summary>
        public virtual int Show
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Tooltip/popover placement
    /// </summary>
    [External]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum PopupPlacement
    {
        Auto,

        AutoBottom,

        AutoLeft,

        AutoRight,

        AutoTop,

        Bottom,

        Left,

        Right,

        Top
    }

    /// <summary>
    /// Tooltip/popover trigger
    /// </summary>
    [External]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum PopupTrigger
    {
        [Name("click focus hover manual")]
        All,

        Click,

        [Name("click focus")]
        ClickFocus,

        [Name("click focus manual")]
        ClickFocusManual,

        [Name("click focus hover")]
        ClickFocusHover,

        [Name("click hover")]
        ClickHover,

        [Name("click hover manual")]
        ClickHoverManual,

        Focus,

        [Name("focus hover")]
        FocusHover,

        [Name("focus manual")]
        FocusManual,

        Hover,

        [Name("hover manual")]
        HoverManual,

        Manual
    }

    /// <summary>
    /// Tooltip/popover viewport
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PopupViewport
    {
        /// <summary>
        /// Selector
        /// </summary>
        public virtual string Selector
        {
            get;
            set;
        }

        /// <summary>
        /// Padding
        /// </summary>
        public virtual int Padding
        {
            get;
            set;
        }
    }

    /// <summary>
    /// A base class for a tooltip and a popover options
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PopupOptions
    {
        /// <summary>
        /// Apply a CSS fade transition to the tooltip/popover.
        /// Defaults to true.
        /// </summary>
        public virtual bool Animation
        {
            get;
            set;
        }

        /// <summary>
        /// Appends the tooltip/popover to a specific element.
        /// Example: container: 'body'. This option is particularly useful in that it allows you to position the tooltip/popover in the flow of the document near the triggering element - which will prevent the tooltip/popover from floating away from the triggering element during a window resize.
        /// Defaults to false.
        /// </summary>
        public virtual string Container
        {
            get;
            set;
        }

        /// <summary>
        /// Delay showing and hiding the tooltip/popover (ms) - does not apply to manual trigger type.
        /// If a number is supplied, delay is applied to both hide/show
        /// Object structure is: delay: { show: 500, hide: 100 }
        /// Defaults to 0.
        /// </summary>
        public virtual Union<int, PopupDelay> Delay
        {
            get;
            set;
        }

        /// <summary>
        /// Insert HTML into the tooltip/popover. If false, jQuery's text method will be used to insert content into the DOM. Use text if you're worried about XSS attacks.
        /// Defaults to false.
        /// </summary>
        public virtual bool Html
        {
            get;
            set;
        }

        /// <summary>
        /// How to position the tooltip/popover - top | bottom | left | right | auto.
        /// When "auto" is specified, it will dynamically reorient the tooltip/popover. For example, if placement is "auto left", the tooltip/popover will display to the left when possible, otherwise it will display right.
        /// You can define a function which returns a placement string. The two arguments are passed to a function - a tooltip/popover and a target DOM elements.
        /// Defaults to 'top'.
        /// </summary>
        public virtual Union<string, PopupPlacement, Delegate, Func<Element, Element, string>> Placement
        {
            get;
            set;
        }

        /// <summary>
        /// If a selector is provided, tooltip/popover objects will be delegated to the specified targets. In practice, this is used to enable dynamic HTML content to have tooltips/popovers added.
        /// See this Issue: https://github.com/twbs/bootstrap/issues/4215
        /// and an informative example: http://jsfiddle.net/fScua/
        /// Defaults to no selector.
        /// </summary>
        public virtual string Selector
        {
            get;
            set;
        }

        /// <summary>
        /// Default title value if title attribute isn't present.
        /// If a function is given, you can access the element that the popover is attached to via the "this" reference (Script.This&lt;Element&gt;()).
        /// Defaults to "".
        /// </summary>
        public virtual Union<string, Delegate, Func<string>> Title
        {
            get;
            set;
        }

        /// <summary>
        /// How tooltip/popover is triggered - click | hover | focus | manual. You may pass multiple triggers; separate them with a space.
        /// Defaults to "hover focus" for a tooltip and "click" for a popover.
        /// </summary>
        public virtual Union<string, PopupTrigger> Trigger
        {
            get;
            set;
        }

        /// <summary>
        /// Keeps the tooltip within the bounds of this element. Example: viewport: '#viewport' or { selector: '#viewport', padding: 0 }
        /// Defaults to { selector: 'body', padding: 0 }.
        /// </summary>
        public virtual Union<string, PopupViewport> Viewport
        {
            get;
            set;
        }
    }

    [External]
    [ObjectLiteral]
    public class TooltipOptions : PopupOptions
    {
        /// <summary>
        /// Base HTML to use when creating the tooltip.
        /// The tooltip's title will be injected into the .tooltip-inner.
        /// .tooltip-arrow will become the tooltip's arrow.
        /// The outermost wrapper element should have the .tooltip class.
        /// Defaults to
        ///     <div class="tooltip" role="tooltip">
        ///         <div class="tooltip-arrow">
        ///         </div>
        ///
        ///         <div class="tooltip-inner">
        ///         </div>
        ///     </div>
        /// </summary>
        public virtual string Template
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Popover options
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PopoverOptions : PopupOptions
    {
        /// <summary>
        /// Default content value if data-content attribute isn't present.
        /// If a function is given, you can access the element that the popover is attached to via the "this" reference (Script.This&lt;Element&gt;()).
        /// Defaults to ''.
        /// </summary>
        public virtual Union<string, Delegate, Func<string>> Content
        {
            get;
            set;
        }

        /// <summary>
        /// Base HTML to use when creating the popover.
        /// The popover's title will be injected into the .popover-title.
        /// The popover's content will be injected into the .popover-content.
        /// .arrow will become the popover's arrow.
        /// The outermost wrapper element should have the .popover class.
        /// Defaults to
        ///     <div class="popover" role="tooltip">
        ///         <div class="arrow">
        ///         </div>
        ///         <h3 class="popover-title">
        ///         </h3>
        ///         <div class="popover-content">
        ///         </div>
        ///     </div>
        /// </summary>
        public virtual string Template
        {
            get;
            set;
        }
    }
}
