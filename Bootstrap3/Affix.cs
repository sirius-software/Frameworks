using Bridge.Html5;
using Bridge.jQuery2;
using System;

namespace Bridge.Bootstrap3
{
    [External]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Initializes an affix with default options.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.affix()")]
        public static jQuery Affix(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Initializes an affix with the options object.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="options"></param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.affix({1})")]
        public static jQuery Affix(this jQuery instance, AffixOptions options)
        {
            return null;
        }
    }

    /// <summary>
    /// Affix offset
    /// </summary>
    [External]
    [ObjectLiteral]
    public class AffixOffset
    {
        /// <summary>
        /// Bottom offset
        /// </summary>
        public virtual int Bottom
        {
            get;
            set;
        }

        /// <summary>
        /// Top offset
        /// </summary>
        public virtual int Top
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Affix options
    /// </summary>
    [External]
    [ObjectLiteral]
    public class AffixOptions
    {
        /// <summary>
        /// Pixels to offset from screen when calculating position of scroll. If a single number is provided, the offset will be applied in both top and bottom directions. To provide a unique, bottom and top offset just provide an object offset: { top: 10 } or offset: { top: 10, bottom: 5 }. Use a function when you need to dynamically calculate an offset.
        /// Defaults to 10.
        /// </summary>
        public virtual Union<int, AffixOffset, Delegate, Func<AffixOffset>> Offset
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the target element of the affix. Either a selector string, a DOM element or a jQuery object.
        /// Defaults to the window object.
        /// </summary>
        public virtual Union<string, Element, jQuery> Target
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Affix events
    /// </summary>
    [External]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum AffixEvent
    {
        /// <summary>
        /// This event fires immediately before the element has been affixed.
        /// </summary>
        [Name("affix.bs.affix")]
        Affix,

        /// <summary>
        /// This event is fired after the element has been affixed.
        /// </summary>
        [Name("affixed.bs.affix")]
        Affixed,

        /// <summary>
        /// This event fires immediately before the element has been affixed-top.
        /// </summary>
        [Name("affix-top.bs.affix")]
        AffixTop,

        /// <summary>
        /// This event is fired after the element has been affixed-top.
        /// </summary>
        [Name("affixed-top.bs.affix")]
        AffixedTop,

        /// <summary>
        /// This event fires immediately before the element has been affixed-bottom.
        /// </summary>
        [Name("affix-bottom.bs.affix")]
        AffixBottom,

        /// <summary>
        /// This event is fired after the element has been affixed-bottom.
        /// </summary>
        [Name("affixed-bottom.bs.affix")]
        AffixedBottom
    }
}
