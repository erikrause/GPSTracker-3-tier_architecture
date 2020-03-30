using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autorization.Startup))]
namespace Autorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
