using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStore3.Startup))]
namespace BookStore3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
