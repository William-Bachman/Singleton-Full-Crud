using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingletonFullCRUD.Startup))]
namespace SingletonFullCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
