using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PourDemain.Startup))]
namespace PourDemain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
