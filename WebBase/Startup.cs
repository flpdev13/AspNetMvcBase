using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBase.Startup))]
namespace WebBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
