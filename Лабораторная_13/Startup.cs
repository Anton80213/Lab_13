using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Лабораторная_13.Startup))]
namespace Лабораторная_13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
