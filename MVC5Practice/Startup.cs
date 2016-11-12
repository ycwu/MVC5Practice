using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Practice.Startup))]
namespace MVC5Practice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
