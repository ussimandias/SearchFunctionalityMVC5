using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CortanaMvc.Startup))]
namespace CortanaMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
