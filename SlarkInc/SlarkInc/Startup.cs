using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlarkInc.Startup))]
namespace SlarkInc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
