using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcsample.Startup))]
namespace mvcsample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
