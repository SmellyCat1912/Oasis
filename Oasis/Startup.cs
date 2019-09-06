using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oasis.Startup))]
namespace Oasis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
