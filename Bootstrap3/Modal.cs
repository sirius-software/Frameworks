using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [External]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Either toggles, shows or hides a modal. Depends on the "operation" parameter which might be "toggle", "show" or "hide".
        /// Returns to the caller before the modal has actually been shown or hidden (i.e. before the shown.bs.modal or hidden.bs.modal event occurs).
        /// </summary>
        /// <param name="instance">The jQuery object with a modal or modals</param>
        /// <param name="options">The options</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.modal({1})")]
        public static jQuery Modal(this jQuery instance, ModalOptions options)
        {
            return null;
        }

        /// <summary>
        /// Either toggles, shows or hides a modal. Depends on the "operation" parameter which might be "toggle", "show" or "hide".
        /// Returns to the caller before the modal has actually been shown or hidden (i.e. before the shown.bs.modal or hidden.bs.modal event occurs).
        /// </summary>
        /// <param name="instance">The jQuery object with a modal or modals</param>
        /// <param name="operation">The operation to be done. Either "toggle", "show" or "hide.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.modal({1})")]
        public static jQuery Modal(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Either toggles, shows or hides a modal. Depends on the "operation" parameter which might be "toggle", "show" or "hide".
        /// Returns to the caller before the modal has actually been shown or hidden (i.e. before the shown.bs.modal or hidden.bs.modal event occurs).
        /// </summary>
        /// <param name="instance">The jQuery object with a modal or modals</param>
        /// <param name="operation">The operation to be done. Either "toggle", "show" or "hide.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.modal({1})")]
        public static jQuery Modal(this jQuery instance, ModalOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Hides a modal. Returns to the caller before the modal has actually been hidden (i.e. before the hidden.bs.modal event occurs).
        /// </summary>
        /// <param name="instance">The jQuery object with a modal or modals</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.modal('hide')")]
        public static jQuery ModalHide(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Opens a modal. Returns to the caller before the modal has actually been shown (i.e. before the shown.bs.modal event occurs).
        /// </summary>
        /// <param name="instance">The jQuery object with a modal or modals</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.modal('show')")]
        public static jQuery ModalShow(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Toggles a modal. Returns to the caller before the modal has actually been shown or hidden (i.e. before the shown.bs.modal or hidden.bs.modal event occurs).
        /// </summary>
        /// <param name="instance">The jQuery object with a modal or modals</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.modal('toggle')")]
        public static jQuery ModalToggle(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// Possible operations on a modal
    /// </summary>
    [External]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum ModalOperation
    {
        /// <summary>
        /// Hides a modal. Returns to the caller before the modal has actually been hidden (i.e. before the hidden.bs.modal event occurs).
        /// </summary>
        Hide,

        /// <summary>
        /// Opens a modal. Returns to the caller before the modal has actually been shown (i.e. before the shown.bs.modal event occurs).
        /// </summary>
        Show,

        /// <summary>
        /// Toggles a modal. Returns to the caller before the modal has actually been shown or hidden (i.e. before the shown.bs.modal or hidden.bs.modal event occurs).
        /// </summary>
        Toggle
    }

    /// <summary>
    /// Modal options
    /// </summary>
    [External]
    [ObjectLiteral]
    public class ModalOptions
    {
        /// <summary>
        /// Includes a modal-backdrop element. Alternatively, specify static for a backdrop which doesn't close the modal on click.
        /// It might be the boolean or the string 'static'
        /// Defaults to true.
        /// </summary>
        public virtual Union<bool, string> Backdrop
        {
            get;
            set;
        }

        /// <summary>
        /// Closes the modal when escape key is pressed.
        /// Defaults to true.
        /// </summary>
        public virtual bool Keyboard
        {
            get;
            set;
        }

        /// <summary>
        /// Shows the modal when initialized.
        /// Defaults to true.
        /// </summary>
        public virtual bool Show
        {
            get;
            set;
        }

        /// <summary>
        /// If a remote URL is provided, content will be loaded one time via jQuery's load method and injected into the .modal-content div.
        /// Defaults to false.
        /// </summary>
        public virtual Union<bool, string> Path
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Events of a modal
    /// </summary>
    [External]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum ModalEvent
    {
        /// <summary>
        /// This event is fired immediately when the hide instance method has been called.
        /// </summary>
        [Name("hide.bs.modal")]
        Hide,

        /// <summary>
        /// This event is fired when the modal has finished being hidden from the user (will wait for CSS transitions to complete).
        /// </summary>
        [Name("hidden.bs.modal")]
        Hidden,

        /// <summary>
        /// This event is fired when the modal has loaded content using the remote option.
        /// </summary>
        [Name("loaded.bs.modal")]
        Loaded,

        /// <summary>
        /// This event fires immediately when the show instance method is called. If caused by a click, the clicked element is available as the relatedTarget property of the event.
        /// </summary>
        [Name("show.bs.modal")]
        Show,

        /// <summary>
        /// This event is fired when the modal has been made visible to the user (will wait for CSS transitions to complete). If caused by a click, the clicked element is available as the relatedTarget property of the event.
        /// </summary>
        [Name("shown.bs.modal")]
        Shown
    }
}
