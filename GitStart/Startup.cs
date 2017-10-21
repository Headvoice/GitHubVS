using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitStart.Startup))]
namespace GitStart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
