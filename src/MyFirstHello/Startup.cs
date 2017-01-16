using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstHello.Startup))]
namespace MyFirstHello
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
