using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanceSportFederation.Web.Startup))]
namespace DanceSportFederation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
