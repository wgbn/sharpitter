using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testeMVC.Startup))]
namespace testeMVC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
