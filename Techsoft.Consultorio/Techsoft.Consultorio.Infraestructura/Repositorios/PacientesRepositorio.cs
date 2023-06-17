using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Infraestructura.Contextos;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Infraestructura.Repositorios
{
    public class PacientesRepositorio: IPacientesRepository
    {
        private Context _contexto;

        public PacientesRepositorio(DbContextOptions options)
        {
            _contexto = new Context(options);
        }
        public Paciente ConsultarPaciente(Paciente paciente)
        {
            return _contexto.Pacientes.FirstOrDefault(p => p.Nombre == paciente.Nombre && p.Direccion == paciente.Direccion && p.Edad == paciente.Edad && p.Telefono == paciente.Telefono);
        }
        public Paciente ConsultarPacientePorId(string pacienteId)
        {
            return _contexto.Pacientes.FirstOrDefault(p => p.Id == pacienteId);
        }
        public Consulta ConsultarDisponibilidadPaciente(Paciente paciente, DateTime horario)
        {
            return _contexto.Consultas.FirstOrDefault(p => p.PacienteId == paciente.Id && p.FechaConsulta == horario);
        }
        public void Guardar(Paciente paciente)
        {
            _contexto.Pacientes.Add(paciente);
            _contexto.SaveChanges();
        }
        public void AgregarConsulta(Consulta consulta)
        {
            _contexto.Consultas.Add(consulta);
            _contexto.SaveChanges();
        }
    }
}
