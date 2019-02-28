using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoggingWebsite.Startup))]
namespace LoggingWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
