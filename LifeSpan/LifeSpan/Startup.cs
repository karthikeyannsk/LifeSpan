using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeSpan.Startup))]
namespace LifeSpan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
