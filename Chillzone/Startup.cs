using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chillzone.Startup))]
namespace Chillzone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
