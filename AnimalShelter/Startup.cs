
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Reflection;
using System.IO;

namespace AnimalShelter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AnimalShelterContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
            services.AddControllers();

            //SWAGGER STUFF
            services.AddSwaggerDocument(config =>
            {
              config.PostProcess = document =>
              {
                document.Info.Version = "v1";
                document.Info.Title = "Animal Shelter API";
                document.Info.Description = "A simple ASP.NET Core web API for Animal Shelter";
                document.Info.TermsOfService = "None";
                document.Info.Contact = new NSwag.OpenApiContact
                {
                  Name = "Hayley EpicodusStudent",
                  Email = "hayley@EpicodusStudent.com"  
                };
              };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();

            app.UseOpenApi(); //SWAGGER STUFF
            app.UseSwaggerUi3();//SWAGGER STUFF

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}