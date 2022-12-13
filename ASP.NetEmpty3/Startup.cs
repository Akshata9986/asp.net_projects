using ASP.NetEmpty3.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetEmpty3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
           // services.AddControllersWithViews();
            services.AddMvc();
            services.AddSingleton<IEmployeeRepository, MockEmployeeDetails>();
           services.AddMvc().AddXmlDataContractSerializerFormatters();

            services.AddDbContextPool<EmployeeDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //we use add scoped method cox we what the instance of the IemployeeRepo to be availabe in the entair scope of the application.
            services.AddScoped<IEmployeeRepository, SqlEmployeeRepository>();
            //services.AddMvcCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }


            // app.UseMvc();

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(name: "default",
                     pattern: "{controller=Home}/{action=Details}/{id?}");
            });


        }
    }
}
