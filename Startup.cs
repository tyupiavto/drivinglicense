using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrivingLicense.Startup))]
namespace DrivingLicense
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
