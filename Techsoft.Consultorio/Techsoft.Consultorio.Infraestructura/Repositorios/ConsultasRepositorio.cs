using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Entidades;
using Techsoft.Consultorio.Infraestructura.Contextos;

namespace Techsoft.Consultorio.Infraestructura.Repositorios
{
    public class ConsultasRepositorio
    {
        private Context _contexto;

        public ConsultasRepositorio(DbContextOptions options)
        {
            _contexto = new Context(options);
        }
        public async Task<List<Consulta>> GetPacienteAllDates(string pacienteId)
        {
            var citas = await _contexto.Consultas.Where(c => c.PacienteId == pacienteId).ToListAsync();
            return citas;
        }

        public async Task<List<Consulta>> GetPacienteDates(string pacienteId, DateTime fecha)
        {
            var citas = await _contexto.Consultas.Where(c => c.PacienteId == pacienteId && c.FechaConsulta.Date == fecha.Date).ToListAsync();
            return citas;
        }

        public async Task<List<Consulta>> GetDoctorDates(string doctorId, DateTime fecha)
        {
            var citas = await _contexto.Consultas.Where(c => c.DoctorId == doctorId && c.FechaConsulta.Date == fecha.Date).ToListAsync();
            return citas;
        }
    }
}
