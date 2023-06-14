using Techsoft.Consultorio.Aplicacion.LoggerService;
using Techsoft.Consultorio.Aplicacion.Servicios;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;

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
        public static void ConfigurePersonaService(this IServiceCollection services)
        {
            // services.AddScoped<IPersonaService<Doctor>, DoctoresService>();
            // services.AddScoped<IPersonaService<Paciente>, PacientesService>();
            services.AddScoped<DoctoresService>();
            services.AddScoped<PacientesService>();
        }
    }
}
