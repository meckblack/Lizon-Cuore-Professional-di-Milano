using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lizon.Startup))]
namespace Lizon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
