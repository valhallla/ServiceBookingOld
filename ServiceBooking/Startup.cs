using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceBooking.Startup))]
namespace ServiceBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
