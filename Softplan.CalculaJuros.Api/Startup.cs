using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Softplan.CalculaJuros.Api.IoC;
using Softplan.CalculaJuros.Api.Mappings;
using System;

namespace Softplan.CalculaJuros.Api
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

            #region IoC
            IoCConfiguration.Register(services);
            #endregion

            #region AutoMapper
            services.AddSingleton(AutoMapperConfiguration.Register());
            #endregion

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Cálculo de Juros Compostos",
                        Version = "v1",
                        Description = "API REST criada com o ASP.NET Core 3.1 para Cálculo de Juros Compostos",
                        Contact = new OpenApiContact
                        {
                            Name = "Anderson Isidoro",
                            Email = "anderson.isidoro.programador@gmail.com",
                            Url = new Uri("https://github.com/isidorodeveloper/calcula-juros/tree/master")
                        }
                    });
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region Middleware Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cálculo de Juros Compostos V1");
            });
            #endregion

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
