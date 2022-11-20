using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cosafa.Startup))]
namespace cosafa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
