using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Text;
using Techsoft.Consultorio.Aplicacion.LoggerService;
using Techsoft.Consultorio.Aplicacion.Servicios;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;
using Techsoft.Consultorio.Infraestructura.Contextos;
using Techsoft.Consultorio.Infraestructura.Repositorios;

namespace Techsoft.Consultorio.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
        public static void ConfigurePersonaService(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<Context>(opt => opt.UseSqlServer(connectionString));
            // services.AddScoped<IPersonaService<Doctor>, DoctoresService>();
            // services.AddScoped<IPersonaService<Paciente>, PacientesService>();
            services.AddScoped<DoctoresService>();
            services.AddScoped<PacientesService>();
            services.AddScoped<IPacientesRepository, PacientesRepositorio>();
            services.AddScoped<IDoctoresRepository, DoctoresRepositorio>();
        }
        public static void Authentication(this IServiceCollection services)
        {
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt => {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = "http://localhost:5105",
                    ValidAudience = "http://localhost:5105",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("suP32@cR3T00$24T"))
                };
            });
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("V1", new OpenApiInfo
                {
                    Version = "V1",
                    Title = "WebAPI",
                    Description = "Product WebAPI"
                });
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Description = "Bearer Authentication with JWT Token",
                    Type = SecuritySchemeType.Http
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                     {
                         new OpenApiSecurityScheme
                         {
                             Reference = new OpenApiReference
                             {
                                 Id = "Bearer",
                                 Type = ReferenceType.SecurityScheme
                             }
                         },
                         new List<string>()
                     }
                });
            });
        }
        public static void CheckHealth(this IServiceCollection services)
        {
            services.AddHealthChecks();
            services.AddHealthChecks()
                .AddCheck("App Running", () => HealthCheckResult.Healthy("Api is working as expected"));
        }
    }
}
