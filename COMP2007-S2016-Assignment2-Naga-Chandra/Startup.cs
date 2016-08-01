using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP2007_S2016_Assignment2_Naga_Chandra.Startup))]
namespace COMP2007_S2016_Assignment2_Naga_Chandra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
