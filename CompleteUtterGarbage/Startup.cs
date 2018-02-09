using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompleteUtterGarbage.Startup))]
namespace CompleteUtterGarbage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
