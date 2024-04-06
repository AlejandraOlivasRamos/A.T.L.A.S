using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A.T.L.A.S.Startup))]
namespace A.T.L.A.S
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
