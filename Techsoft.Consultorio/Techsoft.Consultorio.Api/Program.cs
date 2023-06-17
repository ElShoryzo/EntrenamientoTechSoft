using NLog;
using Techsoft.Consultorio.Api.Extensions;
using static Techsoft.Consultorio.Infraestructura.Fabricas.GlobalConfig;
using Techsoft.Consultorio.Infraestructura.Fabricas;
using Serilog;
using Microsoft.AspNetCore.Hosting;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;

namespace Techsoft.Consultorio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Log Manager NLog setup
            // LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "\\nlog.config"));

            /*
            // Cargar configuracion de logger
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            // Construir Logger
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
            */

            // Serilog setup
            
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.Console()
               .WriteTo.SQLite(@"D:\\Entrenamiento TechSoft\\Techsoft.Consultorio\\Logs\\AppLogger.db")
               .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
               .CreateLogger();
            builder.Host.UseSerilog();

            // Repository config
            GlobalConfig.SetRepositoryOption(RepositoryOption.SqlServer);

            // Add services to the container.

            builder.Services.ConfigureCors();
            builder.Services.ConfigureIISIntegration();
            builder.Services.ConfigureLoggerService();
            var connectionString = builder.Configuration.GetConnectionString("SqlServerConnection");
            builder.Services.ConfigurePersonaService(connectionString);
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.Authentication();
            builder.Services.CheckHealth();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                // app.UseSwaggerUI();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/V1/swagger.json", "Product WebAPI");
                });
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();

            

            app.UseAuthentication();
            app.UseAuthorization();

            // Setup Health Check
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/health-check");
                endpoints.MapHealthChecks("/health-details", new HealthCheckOptions
                {
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                }
                );
                endpoints.MapControllers();
            });
            app.UseSerilogRequestLogging();

            app.MapControllers();

            app.Run();
        }
    }
}