using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(todoMVC_app.Startup))]
namespace todoMVC_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
