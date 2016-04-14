using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ppmteff.Startup))]
namespace ppmteff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
