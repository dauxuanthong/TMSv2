using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMSv2.Startup))]
namespace TMSv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
