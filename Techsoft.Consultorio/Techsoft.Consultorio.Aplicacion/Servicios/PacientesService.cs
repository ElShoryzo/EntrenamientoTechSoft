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
using Techsoft.Consultorio.Presentacion.Repositorios;

namespace Techsoft.Consultorio.Aplicacion.Servicios
{
    public class PacientesService
    {
        private readonly IPacientesRepository _pacientesRepo;
        public PacientesService()
        {
            _pacientesRepo = PacientesFabrik.CrearRepository();
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
    }
}
