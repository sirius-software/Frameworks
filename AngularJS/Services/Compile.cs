using Bridge.jQuery2;
using System;

using jQry = Bridge.jQuery2.jQuery;

namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// Type shorthand for the Transclude signature.
    /// </summary>
    public class TranscludeSig : Union<bool, jQry, jqLite>
    { }

    /// <summary>
    /// The $compile service.
    /// </summary>
    [External]
    public static class Compile
    {
        /// <summary>
        /// The directive definition object provides instructions to the
        /// compiler.
        /// </summary>
        [External]
        [ObjectLiteral]
        public class DirectiveDefinitionObject
        {
            /// <summary>
            /// When this property is set to true, the HTML compiler will
            /// collect DOM nodes between nodes with the attributes
            /// directive-name-start and directive-name-end, and group them
            /// together as the directive elements. It is recommended that this
            /// feature be used on directives which are not strictly
            /// behavioural (such as ngClick), and which do not manipulate or
            /// replace child nodes (such as ngInclude).
            /// </summary>
            public bool MultiElement;

            /// <summary>
            /// When there are multiple directives defined on a single DOM
            /// element, sometimes it is necessary to specify the order in
            /// which the directives are applied. The priority is used to sort
            /// the directives before their compile functions get called.
            /// Priority is defined as a number. Directives with greater
            /// numerical priority are compiled first. Pre-link functions are
            /// also run in priority order, but post-link functions are run in
            /// reverse order. The order of directives with the same priority
            /// is undefined. The default priority is 0.
            /// </summary>
            public int Priority;

            /// <summary>
            /// If set to true then the current priority will be the last set
            /// of directives which will execute (any directives at the current
            /// priority will still execute as the order of execution on same
            /// priority is undefined). Note that expressions and other
            /// directives used in the directive's template will also be
            /// excluded from execution.
            /// </summary>
            public bool Terminal;

            /// <summary>
            /// The scope property can be true, an object or a falsy value:
            /// • falsy: No scope will be created for the directive. The
            ///   directive will use its parent's scope.
            /// • true: A new child scope that prototypically inherits from
            ///   its parent will be created for the directive's element. If
            ///   multiple directives on the same element request a new scope,
            ///   only one new scope is created. The new scope rule does not
            ///   apply for the root of the template since the root of the
            ///   template always gets a new scope.
            /// • {...} (an object hash): A new "isolate" scope is created for
            ///   the directive's element. The 'isolate' scope differs from
            ///   normal scope in that it does not prototypically inherit from
            ///   its parent scope. This is useful when creating reusable
            ///   components, which should not accidentally read or modify data
            ///   in the parent scope.
            /// </summary>
            /// <see cref="!:https://docs.angularjs.org/api/ng/service/$compile">
            /// Official JavaScript Documentation
            /// </see>
            public Union<object, bool, string> Scope;

            /// <summary>
            /// When an isolate scope is used for a component (see above), and
            /// controllerAs is used, bindToController: true will allow a
            /// component to have its properties bound to the controller,
            /// rather than to scope. When the controller is instantiated, the
            /// initial values of the isolate scope bindings are already
            /// available.
            /// </summary>
            public bool BindToController;

            /// <summary>
            /// Controller constructor function. The controller is instantiated
            /// before the pre-linking phase and can be accessed by other
            /// directives (see require attribute). This allows the directives
            /// to communicate with each other and augment each other's
            /// behavior.
            /// </summary>
            /// <returns></returns>
            /// <see cref="!:https://docs.angularjs.org/api/ng/service/$compile">
            /// Official JavaScript Documentation
            /// </see>
            public Delegate Controller;

            /// <summary>
            /// Require another directive and inject its controller as the
            /// fourth argument to the linking function. The require takes a
            /// string name (or array of strings) of the directive(s) to pass
            /// in. If an array is used, the injected argument will be an array
            /// in corresponding order. If no such directive can be found, or
            /// if the directive does not have a controller, then an error is
            /// raised (unless no link function is specified, in which case
            /// error checking is skipped).
            /// </summary>
            public Union<string, string[]> Require;

            /// <summary>
            /// Identifier name for a reference to the controller in the
            /// directive's scope. This allows the controller to be referenced
            /// from the directive template. This is especially useful when a
            /// directive is used as component, i.e. with an isolate scope.
            /// It's also possible to use it in a directive without an
            /// isolate / new scope, but you need to be aware that the
            /// controllerAs reference might overwrite a property that already
            /// exists on the parent scope.
            /// </summary>
            public string ControllerAs;

            /// <summary>
            /// String of subset of EACM which restricts the directive to a
            /// specific directive declaration style. If omitted, the defaults
            /// (elements and attributes) are used. Valid chars are:
            /// E (element), A (attribute), C (class), M(comment)
            /// </summary>
            /// <example>E (element)</example>
            /// <example>A (attribute)</example>
            /// <example>C (class)</example>
            /// <example>M (comment)</example>
            /// <example>EACM (all)</example>
            /// <see cref="!:https://docs.angularjs.org/api/ng/service/$compile">
            /// Official JavaScript Documentation
            /// </see>
            public string Restrict;

            /// <summary>
            /// String representing the document type used by the markup in the
            /// template. AngularJS needs this information as those elements
            /// need to be created and cloned in a special way when they are
            /// defined outside their usual containers like &lt;svg&gt; and &lt;math&gt;.
            /// Valid options are: html, svg, math. Default is html.
            /// </summary>
            public string TemplateNamespace;

            /// <summary>
            /// HTML markup that may:
            /// • Replace the contents of the directive's element (default).
            /// • Replace the directive's element itself (if replace is true -
            ///   DEPRECATED).
            /// • Wrap the contents of the directive's element (if transclude
            /// is true).
            ///
            /// Value may be:
            /// • A string. For example &lt;div red-on-hover&gt;{{delete_str}}&lt;/div&gt;.
            /// • A function which takes two arguments tElement and tAttrs
            ///   (described in the compile function api below) and returns a
            ///   string value.
            /// </summary>
            public string Template;

            /// <summary>
            /// This is similar to template but the template is loaded from the
            /// specified URL, asynchronously
            /// </summary>
            /// <see cref="!:https://docs.angularjs.org/api/ng/service/$compile">
            /// Official JavaScript Documentation
            /// </see>
            public string TemplateUrl;

            /// <summary>
            /// Specify what the template should replace. Defaults to false.
            /// If false, template will replace the contents of the directive's
            /// element. If true, template will replace the directive's
            /// element.
            /// </summary>
            [Obsolete("Will be removed in next major release - i.e. v2.0")]
            public bool Replace;

            /// <summary>
            /// Extract the contents of the element where the directive appears
            /// and make it available to the directive. The contents are
            /// compiled and provided to the directive as a transclusion
            /// function.
            /// </summary>
            public TranscludeSig Transclude;

            /// <summary>
            /// function compile(tElement, tAttrs, transclude)
            /// The compile function deals with transforming the template DOM.
            /// Since most directives do not do template transformation, it is
            /// not used often.
            /// </summary>
            /// <see cref="!:https://docs.angularjs.org/api/ng/service/$compile">
            /// Official JavaScript Documentation
            /// </see>
            public Delegate Compile;

            /// <summary>
            /// This property is used only if the compile property is not
            /// defined.
            /// function link(scope, iElement, iAttrs, controller, transcludeFn)
            /// The link function is responsible for registering DOM listeners
            /// as well as updating the DOM. It is executed after the template
            /// has been cloned. This is where most of the directive logic will
            /// be put.
            /// </summary>
            /// <see cref="!:https://docs.angularjs.org/api/ng/service/$compile">
            /// Official JavaScript Documentation
            /// </see>
            public Delegate Link;
        }
    }

}