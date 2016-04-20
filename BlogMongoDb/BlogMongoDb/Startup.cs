using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogMongoDb.Startup))]
namespace BlogMongoDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
