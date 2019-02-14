using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chesterfields.Startup))]
namespace chesterfields
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
