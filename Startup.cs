using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using MvcTodoWithNg.Data;
using System;
using Microsoft.AspNet.FileSystems;
using Microsoft.AspNet.StaticFiles;

namespace KWebStartup
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "api",
                        template: "{controller}/{id?}");
                });

        }
        
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddMvc();

            services.AddEntityFramework()
                .AddInMemoryStore()
                .AddDbContext<AppDataContext>();
        }
    }
}
