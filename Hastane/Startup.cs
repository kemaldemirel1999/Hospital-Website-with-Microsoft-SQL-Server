using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hastane.Startup))]
namespace Hastane
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
