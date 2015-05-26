using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillingsCoderDojo.Startup))]
namespace BillingsCoderDojo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
