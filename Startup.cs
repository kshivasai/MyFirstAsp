using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstAsp.Startup))]
namespace MyFirstAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
