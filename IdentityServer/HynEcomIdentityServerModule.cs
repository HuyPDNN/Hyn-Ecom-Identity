using HynEcom.IdentityServer.EntityFrameworkCore;
using HynEcom.IdentityServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;

namespace HynEcom.IdentityServer.IdentityServer
{
    public static class HynEcomIdentityServerModule
    {
        public static void RegisterService(WebApplicationBuilder builder)
        {
            builder.Services.AddSession();

            builder.Services.AddAutoMapper(cfg => cfg.AddProfile(new ApplicationAutoMapperProfile()));

            builder.Services.AddDbContext<HynEcomIdentityDbContext>(option => option
                            .UseNpgsql(builder.Configuration.GetConnectionString("Default")));

            builder.Services.AddMemoryCache();

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "HynEcom Identity APIs",
                    Description = "API for managing Identity user",
                    //TermsOfService = new Uri("https://example.com/terms"),
                    //Contact = new OpenApiContact
                    //{
                    //    Name = "Example Contact",
                    //    Url = new Uri("https://example.com/contact")
                    //},
                    //License = new OpenApiLicense
                    //{
                    //    Name = "Example License",
                    //    Url = new Uri("https://example.com/license")
                    //}
                });

                // using System.Reflection;
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            //builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //builder.Services.AddSingleton<IBusinessObjectService, BusinessObjectService>();
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

        }

        public static void UseSwaggerSpec(WebApplication app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("v1/swagger.json", "v1");
                options.InjectStylesheet("/swagger-ui/custom.css");
            });
        }
    }
}
