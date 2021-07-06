using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tuan456.Startup))]
namespace tuan456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
