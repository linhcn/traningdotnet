using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetDemo.Startup))]
namespace AspNetDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
