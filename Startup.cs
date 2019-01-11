using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KoksHamit
{
    public class Startup
    {
        public IConfiguration configuration{get;}


        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IEtiketRepository, EtiketRepository>();
            services.AddTransient<IKullaniciRepository, KullaniciRepository>();
            services.AddTransient<IMuzikRepository, MuzikRepository>();
            services.AddTransient<ISanatciRepository, SanatciRepository>();
            services.AddTransient<IYoneticiRepository, YoneticiRepository>();
            services.AddTransient<IYorumRepository, YorumRepository>();
            services.AddDbContext<MuzikContext>(options=>
                options.UseMySql(configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();

            app.UseStaticFiles();

            app.UseMvc(
                routes=>{
                    routes.MapRoute(
                        name:"default",
                        template:"{controller=Home}/{action=Index}/{id?}"
                    );
                }
            );
        }
    }
}
