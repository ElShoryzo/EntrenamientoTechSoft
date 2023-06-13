using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.Consultorio.Dominio.Entidades
{
    public class Paciente: Persona
    {
        public int Edad { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Nombre}, {Direccion}, {Edad}, {Telefono}";
        }
    }
}
