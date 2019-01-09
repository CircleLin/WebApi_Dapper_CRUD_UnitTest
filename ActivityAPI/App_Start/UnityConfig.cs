using System.Web.Http;
using Unity;
using Unity.WebApi;
using ActivityAPI.Repository;
using ActivityAPI.Service;

namespace ActivityAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            container.RegisterType<IActivityRepository, ActivityRepository>();
            container.RegisterType<IActivityService, ActivityService>();

        }
    }
}