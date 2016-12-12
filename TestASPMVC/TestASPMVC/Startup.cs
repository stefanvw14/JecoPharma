using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestASPMVC.Startup))]
namespace TestASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
