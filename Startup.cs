using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fashionshops.Startup))]
namespace fashionshops
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
