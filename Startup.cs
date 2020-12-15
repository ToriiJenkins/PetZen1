using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetZen.Startup))]
namespace PetZen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
