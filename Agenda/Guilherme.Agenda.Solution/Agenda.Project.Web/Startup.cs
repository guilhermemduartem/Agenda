using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Agenda.Project.Web.Startup))]
namespace Agenda.Project.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
