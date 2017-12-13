using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventfulSearchWebsite.Startup))]
namespace EventfulSearchWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
