using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Aplicacion.DataTransferObjects
{
    public class ConsultaCreationDto
    {
        [Required(ErrorMessage = "El id del paciente es requerido")]
        public string PacienteId { get; set; }

        [Required(ErrorMessage = "El id del doctor es requerido")]
        public string DoctorId { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime FechaConsulta { get; set; }
    }
}
