using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flow.Web.Startup))]
namespace Flow.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
