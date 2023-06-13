using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Infraestructura.Contextos
{
    internal class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options){}

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
    }
}
