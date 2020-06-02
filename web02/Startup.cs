using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web02.Startup))]
namespace web02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
