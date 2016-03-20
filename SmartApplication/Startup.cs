using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartApplication.Startup))]
namespace SmartApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
