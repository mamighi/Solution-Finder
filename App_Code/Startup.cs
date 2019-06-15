using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolutionFinder.Startup))]
namespace SolutionFinder
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
