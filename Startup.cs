using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoDePrueba.Context;

using Microsoft.EntityFrameworkCore; //se agrega para la DbContext
using ProyectoDePrueba.Entidades;


namespace ProyectoDePrueba
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProyectoDePrueba", Version = "v1" });
            });

            services.AddEntityFrameworkSqlServer();
            services.AddDbContext<IconsContext>((services, options) => //landa
            {
            options.UseInternalServiceProvider(services);
                // options.UseSqlServer(Configuration.GetConnectionString("IconsConnectionString"));//le pasamos el valor de la conexion que queremos levantar del Json
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IconsDb;Integrated Security=True;");

            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProyectoDePrueba v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
