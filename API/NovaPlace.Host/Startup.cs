
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NovaPlace.Host
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.Scan(scan => scan.FromCallingAssembly() //FromCallingAssembly sadece Host uygulaması demek oluyor.
                            .AddClasses()
                            .AsMatchingInterface());
            services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy",
                    builder =>
                    {
                        builder.AllowAnyOrigin();
                    });
            });
            #region DomainService & Repository

            //services.AddTransient<DomainService.IDomainService, DomainService.DomainService>();


            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseMiddleware<Logger.Logger>(); 
            app.UseCors("MyPolicy");
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
