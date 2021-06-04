using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBasedUI.Startup))]
namespace WebBasedUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
