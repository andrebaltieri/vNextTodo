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

            // Add MVC to the request pipeline
            app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller}/{action}/{id?}",
                        defaults: new { controller = "Home", action = "Index" });

                    routes.MapRoute(
                        name: "api",
                        template: "{controller}/{id?}");
                });
        }
        
        public void ConfigureServices(IServiceCollection services)
        {            
            // Add MVC services to the service container
            services.AddMvc();

            // Add EF services to the service container
            services.AddEntityFramework()
                .AddInMemoryStore()
                .AddDbContext<AppDataContext>();
        }
    }
}
