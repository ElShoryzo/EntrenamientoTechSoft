using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Aplicacion.DataTransferObjects
{
    public class ConsultaDto
    {
        public Guid Id { get; set; }

        //public Paciente Paciente { get; set; }

        //public Doctor Doctor { get; set; }
        public string PacienteId { get; set; }

        public string DoctorId { get; set; }
        public string Direccion { get; set; }

        public DateTime FechaConsulta { get; set; }
    }
}
