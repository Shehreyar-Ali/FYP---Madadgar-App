using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Madadgar___Admin_Portal.Startup))]
namespace Madadgar___Admin_Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
