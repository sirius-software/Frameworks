using Bridge.Html5;
using System;

namespace Bridge.AngularJS.Route
{
    /// <summary>
    /// ngRoute-specific directives extension methods for Bridge.HTML5
    /// Element class.
    /// </summary>
    [External]
    public static class Directives
    {
        /// <summary>
        /// Sets the ng-view attribute to the element.
        /// </summary>
        /// <param name="el">Element</param>
        [Template("{el}.setAttribute('ng-view')")]
        public static void SetNGView(this Element el)
        {
        }

        /// <summary>
        /// Gets the ng-view attribute of the element.
        /// </summary>
        /// <param name="el">Element</param>
        [Template("{el}.getAttribute('ng-view')")]
        public static void GetNGView(this Element el)
        {
        }

        /// <summary>
        /// Removes the ng-view attribute fromthe element.
        /// </summary>
        /// <param name="el">Element</param>
        [Template("{el}.removeAttribute('ng-view')")]
        public static void RemoveNGView(this Element el)
        {
        }
    }

    /// <summary>
    /// Route Provider of ngRoute.
    /// </summary>
    [External]
    public class RouteProvider
    {
        /// <summary>
        /// A boolean property indicating if routes defined using this provider
        /// should be matched using a case insensitive algorithm.
        /// </summary>
        public bool CaseInsensitiveMatch = false;

        /// <summary>
        /// Adds a new route definition to the $route service.
        /// </summary>
        /// <param name="path">
        /// Route path (matched against $location.path).
        /// </param>
        /// <param name="route">
        /// Mapping information to be assigned to $route.current on route match.
        /// </param>
        public RouteProvider When(string path, MappingInformation route)
        {
            return default(RouteProvider);
        }

        /// <summary>
        /// Sets route definition that will be used on route change when no
        /// other route definition is matched.
        /// </summary>
        /// <param name="parms">
        /// Mapping information to be assigned to $route.current. If called with
        /// a string, the value maps to redirectTo.
        /// </param>
        public RouteProvider Otherwise(Union<String, MappingInformation> parms)
        {
            return default(RouteProvider);
        }
    }

    /// <summary>
    /// Mapping information structure for use with Route Provider.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MappingInformation
    {
        /// <summary>
        /// Controller fn that should be associated with newly created scope or
        /// the name of a registered controller if passed as a string.
        /// </summary>
        public Union<string, Action> Controller;

        /// <summary>
        /// An identifier name for a reference to the controller. If present,
        /// the controller will be published to scope under the controllerAs
        /// name.
        /// </summary>
        public string ControllerAs;

        /// <summary>
        /// HTML template as a string or a function that returns an html
        /// template as a string which should be used by ngView or ngInclude
        /// directives. This property takes precedence over TemplateUrl.
        /// </summary>
        /// <remarks>
        /// If Template is a function, it will be called with the following
        /// parameters:
        /// {Array.&lt;Object&gt;} - route parameters extracted from the current
        /// $location.path() by applying the current route.
        /// </remarks>
        public Union<string, Func<string>> Template;

        /// <summary>
        /// Path or function that returns a path to an html template that should
        /// be used by ngView.
        /// </summary>
        /// <remarks>
        /// If TemplateUrl is a function, it will be called with the following
        /// parameters:
        /// {Array.&lt;Object&gt;} - route parameters extracted from the current
        /// $location.path() by applying the current route
        /// </remarks>
        public Union<string, Func<string>> TemplateUrl;

        /// <summary>
        /// An optional map of dependencies which should be injected into the
        /// controller.
        /// </summary>
        /// <remarks>
        /// If any of these dependencies are promises, the router will wait for
        /// them all to be resolved or one to be rejected before the controller
        /// is instantiated.
        /// If all the promises are resolved successfully, the values of the
        /// resolved promises are injected and $routeChangeSuccess event is
        /// fired.
        /// If any of the promises are rejected the $routeChangeError event is
        /// fired.
        /// </remarks>
        public ResolveMap Resolve;

        // FIXME: Is ResolveMap the desired type?
        /// <summary>
        /// Value or function to update $location path with and trigger route
        /// redirection.
        /// </summary>
        /// <remarks>
        /// If redirectTo is a function, it will be called with the following
        /// parameters:
        /// {Object.&lt;string&gt;} - route parameters extracted from the current
        /// $location.path() by applying the current route templateUrl.
        /// {string} - current $location.path()
        /// {Object} - current $location.search()
        /// The custom redirectTo function is expected to return a string which
        /// will be used to update $location.path() and $location.search().
        /// </remarks>
        public Union<string, Func<string, ResolveMap, string, object>> RedirectTo;

        /// <summary>
        /// Reload route when only $location.search() or $location.hash()
        /// changes.
        /// </summary>
        /// <remarks>
        /// If the option is set to false and url in the browser changes, then
        /// $routeUpdate event is broadcasted on the root scope.
        /// </remarks>
        public bool ReloadOnSearch = true;

        /// <summary>
        /// Match routes without being case sensitive.
        /// </summary>
        /// <remarks>
        /// If the option is set to true, then the particular route can be
        /// matched without being case sensitive.
        /// </remarks>
        public bool CaseInsensitiveMatch = false;
    }

    /// <summary>
    /// Structure for dependency mapping.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class ResolveMap
    {
        /// <summary>
        /// Name of the dependency to be injected into the controller.
        /// </summary>
        public string Key;

        /// <summary>
        /// String for an alias for a service or function to inject it and use
        /// its return value as dependency.
        /// </summary>
        /// <remarks>
        /// If the result of the function is a promise, it is resolved before
        /// its value is injected into the controller. Be aware that
        /// ngRoute.$routeParams will still refer to the previous route within
        /// these resolve functions. Use $route.current.params to access the new
        /// route parameters, instead.
        /// </remarks>
        public Union<string, Func<object>> Factory;
    }
}

