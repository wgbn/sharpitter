using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAulaMVC.Startup))]
namespace WebAulaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
