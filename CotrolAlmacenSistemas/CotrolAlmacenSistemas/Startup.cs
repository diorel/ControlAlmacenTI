using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CotrolAlmacenSistemas.Startup))]
namespace CotrolAlmacenSistemas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
