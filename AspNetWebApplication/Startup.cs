using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetWebApplication.Startup))]
namespace AspNetWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
