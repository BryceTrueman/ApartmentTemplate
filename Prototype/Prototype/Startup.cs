using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prototype.Startup))]
namespace Prototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
