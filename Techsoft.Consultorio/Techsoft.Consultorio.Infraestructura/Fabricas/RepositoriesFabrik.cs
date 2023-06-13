using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Infraestructura.Repositorios;
using Techsoft.Consultorio.Presentacion.Repositorios;
using static Techsoft.Consultorio.Infraestructura.Fabricas.GlobalConfig;

namespace Techsoft.Consultorio.Infraestructura.Fabricas
{
    public class GlobalConfig
    {
        private static RepositoryOption _useRepositoryOption = 0;
        public static void SetRepositoryOption(RepositoryOption option)
        {
            if(_useRepositoryOption == RepositoryOption.None)
            {
                _useRepositoryOption = option;

            }
        }
        public static RepositoryOption UseRepositoryOption => _useRepositoryOption;
        public static DbContextOptions SqlOptions()
        {
            var options = new DbContextOptionsBuilder();
            options.UseSqlServer("server=.;Initial Catalog=BDEntrenamiento; Trusted_Connection=true; Encrypt=false");
            return options.Options;
        }
        public static DbContextOptions SqliteOptions()
        {
            var options = new DbContextOptionsBuilder();
            options.UseSqlite("Data Source = D:\\Entrenamiento TechSoft\\Techsoft.Consultorio\\Datos\\Consultorio.db");
            return options.Options;
        }
        public enum RepositoryOption
        {
            None = 0,
            SqlServer,
            Sqlite,
            TextFile
        }
    }
    public class PacientesFabrik
    {
        public static IPacientesRepository CrearRepository()
        {
            // return new RepositorioTxt();
            // return new RepositorioSQLite();
            // return new RepositorioSQLServer();
            switch (GlobalConfig.UseRepositoryOption)
            {
                case RepositoryOption.SqlServer:
                    return new PacientesRepositorio(GlobalConfig.SqlOptions());
                case RepositoryOption.Sqlite:
                    return new PacientesRepositorio(GlobalConfig.SqliteOptions());
                default:
                    return new PacientesRepositorioTxt();
            }
        }
    }
    public class DoctoresFabrik
    {
        public static IDoctoresRepository CrearRepository()
        {
            switch (GlobalConfig.UseRepositoryOption)
            {
                case RepositoryOption.SqlServer:
                    return new DoctoresRepositorio(GlobalConfig.SqlOptions());
                case RepositoryOption.Sqlite:
                    return new DoctoresRepositorio(GlobalConfig.SqliteOptions());
                default:
                    return new DoctoresRepositorioTxt();
            }
        }
    }
}
