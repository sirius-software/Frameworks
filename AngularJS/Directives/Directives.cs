using Bridge.Html5;

namespace Bridge.AngularJS
{
    [External]
    public static class Directives
    {
        [Template("{el}")]
        public extern static AngularElement NG(this Element el);

        [Template("{el}")]
        public extern static AngularElement Angular(this Element el);

        [Template("{el}")]
        public extern static AngularHtmlElement NG(this HTMLHtmlElement el);

        [Template("{el}")]
        public extern static AngularHtmlElement Angular(this HTMLHtmlElement el);

        [Template("{el}")]
        public extern static AngularAnchorElement NG(this HTMLAnchorElement el);

        [Template("{el}")]
        public extern static AngularAnchorElement Angular(this HTMLAnchorElement el);

        [Template("{el}")]
        public extern static AngularImageElement NG(this HTMLImageElement el);

        [Template("{el}")]
        public extern static AngularImageElement Angular(this HTMLImageElement el);

        [Template("{el}")]
        public extern static AngularFormElement NG(this HTMLFormElement el);

        [Template("{el}")]
        public extern static AngularFormElement Angular(this HTMLFormElement el);

        // The elements related to <input/> below were extracted from:
        // http://www.w3schools.com/html/html_form_elements.asp
        // Except for label, fieldset and output elements (which don't really
        // are input elements)

        #region Input elements

        [Template("{el}")]
        public extern static AngularInputElement NG(this HTMLInputElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this HTMLInputElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this HTMLTextAreaElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this HTMLTextAreaElement el);

        [Template("{el}")]
        public extern static AngularSelectElement NG(this HTMLSelectElement el);

        [Template("{el}")]
        public extern static AngularSelectElement Angular(this HTMLSelectElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this HTMLOptGroupElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this HTMLOptGroupElement el);

        [Template("{el}")]
        public extern static AngularOptionElement NG(this HTMLOptionElement el);

        [Template("{el}")]
        public extern static AngularOptionElement Angular(this HTMLOptionElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this HTMLButtonElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this HTMLButtonElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this HTMLDataListElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this HTMLDataListElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this HTMLKeygenElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this HTMLKeygenElement el);

        #endregion Input elements

        /// <summary>
        /// The &lt;details&gt; tag is currently experimental and not supported
        /// by all major browsers.
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        /// <remarks>
        /// The &lt;details&gt; tag is currently in draft state and not supported
        /// by all browsers, thus not available on Bridge.Html5.
        /// Details: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details
        /// </remarks>
        [Template("{el}")]
        public extern static AngularDetailsElement NG(this HTMLUnknownElement el);

        /// <summary>
        /// The &lt;details&gt; tag is currently experimental and not supported
        /// by all major browsers.
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        /// <remarks>
        /// The &lt;details&gt; tag is currently in draft state and not supported
        /// by all browsers, thus not available on Bridge.Html5.
        /// Details: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details
        /// </remarks>
        [Template("{el}")]
        public extern static AngularDetailsElement Angular(this HTMLUnknownElement el);
    }
}