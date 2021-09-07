using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice_01.Startup))]
namespace Practice_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
