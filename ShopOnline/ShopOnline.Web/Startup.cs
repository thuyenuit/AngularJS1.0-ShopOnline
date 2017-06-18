using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopOnline.Web.Startup))]
namespace ShopOnline.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
