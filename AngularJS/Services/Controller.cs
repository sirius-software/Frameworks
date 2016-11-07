using System;
namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// The $controller service.
    /// </summary>
    [External]
    public class Controller
    {
        /// <summary>
        /// $controller service is responsible for instantiating controllers.
        /// It's just a simple call to $injector, but extracted into a service,
        /// so that one can override this service with BC version.
        /// </summary>
        /// <param name="constructor">
        /// If called with a function then it's considered to be the controller
        /// constructor function. Otherwise it's considered to be a string
        /// which is used to retrieve the controller constructor.
        /// </param>
        /// <param name="locals">Injection locals for Controller.</param>
        /// <returns>Instance of given controller.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/service/$controller">
        /// Official JavaScript Documentation
        /// </see>
        [Template("$controller({constructor}, {locals})")]
        public static object DoController(Union<Delegate, string> constructor,
            object locals)
        {
            return default(object);
        }
    }
}