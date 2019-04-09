using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChattingApp.Startup))]
namespace ChattingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
