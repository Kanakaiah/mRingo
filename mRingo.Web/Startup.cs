using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mRingo.Web.Startup))]
namespace mRingo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
