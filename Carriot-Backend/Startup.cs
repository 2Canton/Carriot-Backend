using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Carriot_Backend.Startup))]

namespace Carriot_Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}