using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mirasol.Startup))]
namespace Mirasol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
