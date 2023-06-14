using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.Consultorio.Aplicacion.DataTransferObjects
{
    public class DoctorDto : PersonaDto
    {
        public string Cedula { get; set; }
    }
}
