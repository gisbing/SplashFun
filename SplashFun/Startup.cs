using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SplashFun.Startup))]
namespace SplashFun
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
