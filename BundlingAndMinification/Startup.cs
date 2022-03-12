using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BundlingAndMinification.Startup))]
namespace BundlingAndMinification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
