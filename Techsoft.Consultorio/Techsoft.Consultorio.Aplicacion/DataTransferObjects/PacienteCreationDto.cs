using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.Consultorio.Aplicacion.DataTransferObjects
{
    public class PacienteCreationDto : PersonaCreationDto
    {
        [Required(ErrorMessage = "La edad es requerida")]
        public int Edad { get; set; }
    }
}
