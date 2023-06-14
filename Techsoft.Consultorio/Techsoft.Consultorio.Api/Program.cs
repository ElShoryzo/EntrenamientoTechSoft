using NLog;
using Techsoft.Consultorio.Api.Extensions;
using static Techsoft.Consultorio.Infraestructura.Fabricas.GlobalConfig;
using Techsoft.Consultorio.Infraestructura.Fabricas;

namespace Techsoft.Consultorio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Log Manager setup
            LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "\\nlog.config"));

            // Repository config
            GlobalConfig.SetRepositoryOption(RepositoryOption.TextFile);

            // Add services to the container.

            builder.Services.ConfigureCors();
            builder.Services.ConfigureIISIntegration();
            builder.Services.ConfigureLoggerService();
            builder.Services.ConfigurePersonaService();
            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            // app.useSerilog();
            app.MapControllers();

            app.Run();
        }
    }
}