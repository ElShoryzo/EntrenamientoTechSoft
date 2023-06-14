﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.Consultorio.Aplicacion.DataTransferObjects
{
    public abstract class PersonaDto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
