using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CriptoManage.Startup))]
namespace CriptoManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
