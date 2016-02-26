using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coderhub.Startup))]
namespace Coderhub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
