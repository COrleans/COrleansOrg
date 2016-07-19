using System.Web.Routing;
using FC.Framework;
using FC.Framework.Autofac;
using FC.Framework.Log4net;

namespace COrleans.Web
{
    public class AppConfig
    {
        public static void Initialize(RouteCollection routes)
        {
            FCFramework.Initialize()
                       .UseAutofac()
                       .UseLog4net()
                       .UseDefaultJsonSerializer();
        }
    }
}
