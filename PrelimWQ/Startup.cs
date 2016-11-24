using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrelimWQ.Startup))]
namespace PrelimWQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
