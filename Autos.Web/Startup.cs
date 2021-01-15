using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autos.Web.Startup))]
namespace Autos.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
