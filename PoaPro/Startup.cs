using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoaPro.Startup))]
namespace PoaPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
