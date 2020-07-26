using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PipelineManager
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            /* No Authorization, No Validation, No ViewEngine.
             * Just MVC Core, as is :) */
            services.AddMvcCore();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseRouting();
            app.UseEndpoints(e => e.MapControllers());
        }
    }
}
