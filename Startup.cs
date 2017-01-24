using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCNorthwindDB.Startup))]
namespace MVCNorthwindDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
