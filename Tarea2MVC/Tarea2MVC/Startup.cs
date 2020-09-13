using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea2MVC.Startup))]
namespace Tarea2MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
