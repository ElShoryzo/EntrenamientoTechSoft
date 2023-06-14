using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.Consultorio.Aplicacion.DataTransferObjects
{
    public class DoctorCreationDto : PersonaCreationDto
    {
        [Required(ErrorMessage = "La cédula es requerida")]
        public string Cedula { get; set; }
    }
}
