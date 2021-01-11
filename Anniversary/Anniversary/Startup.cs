using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Anniversary.Startup))]
namespace Anniversary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
