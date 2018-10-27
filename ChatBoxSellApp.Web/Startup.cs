using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatBoxSellApp.Web.Startup))]
namespace ChatBoxSellApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
