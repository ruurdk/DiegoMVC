using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiegoMVC.Web.Startup))]
namespace DiegoMVC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
