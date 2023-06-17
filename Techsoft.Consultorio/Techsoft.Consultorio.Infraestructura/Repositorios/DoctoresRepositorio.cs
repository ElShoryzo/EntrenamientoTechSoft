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
    public class DoctoresRepositorio: IDoctoresRepository
    {
        private Context _contexto;

        public DoctoresRepositorio(DbContextOptions options)
        {
            _contexto = new Context(options);
        }
        public Doctor ConsultarCedula(string cedula)
        {
            return _contexto.Doctores.FirstOrDefault(p=>p.Cedula == cedula);
        }
        public Doctor ConsultarDoctorPorId(string doctorId)
        {
            return _contexto.Doctores.FirstOrDefault(p => p.Id == doctorId);
        }
        public Consulta ConsultarDisponibilidadDoctor(Doctor doctor, DateTime horario)
        {
            return _contexto.Consultas.FirstOrDefault(p => p.DoctorId == doctor.Id && p.FechaConsulta == horario);
        }
        public void Guardar(Doctor doctor)
        {
            _contexto.Doctores.Add(doctor);
            _contexto.SaveChanges();
        }
        public async Task<Doctor> GetById(string id)
        {
            return await _contexto.Doctores.Where(e => e.Id == id).FirstOrDefaultAsync();
        }
    }
}
