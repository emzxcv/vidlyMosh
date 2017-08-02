using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMosh.Startup))]
namespace VidlyMosh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
