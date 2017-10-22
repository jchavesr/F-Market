using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(F_Market.Startup))]
namespace F_Market
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
