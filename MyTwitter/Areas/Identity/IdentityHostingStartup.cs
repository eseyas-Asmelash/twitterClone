using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(MyTwitter.Areas.Identity.IdentityHostingStartup))]
namespace MyTwitter.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}