using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheInformationAndTechnologyCollege.Startup))]
namespace TheInformationAndTechnologyCollege
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
