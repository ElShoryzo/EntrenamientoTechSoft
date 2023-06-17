using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Aplicacion.DataTransferObjects;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;
using Techsoft.Consultorio.Infraestructura.Fabricas;
using Techsoft.Consultorio.Infraestructura.Repositorios;

namespace Techsoft.Consultorio.Aplicacion.Servicios
{
    public class PacientesService
    {
        private readonly IPacientesRepository _pacientesRepo;
        private readonly IDoctoresRepository _doctoresRepo;
        public PacientesService(IPacientesRepository pacientesRepository, IDoctoresRepository doctoresRepo)
        {
            // _pacientesRepo = PacientesFabrik.CrearRepository();
            _pacientesRepo = pacientesRepository;
            _doctoresRepo = doctoresRepo;
        }

        public void Guardar(Paciente paciente)
        {
            UsuarioDuplicado(paciente);
            _pacientesRepo.Guardar(paciente);
        }

        private void UsuarioDuplicado(Paciente paciente)
        {
            var result = _pacientesRepo.ConsultarPaciente(paciente);

            if (result is not null)
            {
                throw new InvalidOperationException("El paciente ya existe");
            }

        }
        public void AgendarConsulta (Consulta consulta)
        {
            // Validar Paciente
            var paciente = _pacientesRepo.ConsultarPacientePorId(consulta.PacienteId) ?? throw new ArgumentException("El paciente no esta dado de alta");
            // Validar Doctor
            var doctor = _doctoresRepo.ConsultarDoctorPorId(consulta.DoctorId) ?? throw new ArgumentException("El doctor no esta dado de alta");
            ConsultarDisponibilidad(paciente, doctor, consulta.FechaConsulta);
            // Agregar Cita
            _pacientesRepo.AgregarConsulta(new Consulta(paciente, doctor, consulta.FechaConsulta, consulta.Direccion));
        }
        private void ConsultarDisponibilidad(Paciente paciente, Doctor doctor, DateTime horario)
        {
            var disponibilidadPaciente = _pacientesRepo.ConsultarDisponibilidadPaciente(paciente, horario);
            if (disponibilidadPaciente != null)
            {
                throw new InvalidOperationException("El paciente no está disponible.");
            }
            var disponibilidadDoctor = _doctoresRepo.ConsultarDisponibilidadDoctor(doctor, horario);
            if (disponibilidadDoctor != null)
            {
                throw new InvalidOperationException("El doctor no está disponible.");
            }
        }
    }
}
