using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Library2.Startup))]
namespace Library2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
