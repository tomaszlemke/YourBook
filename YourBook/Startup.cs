using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YourBook.Startup))]
namespace YourBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
