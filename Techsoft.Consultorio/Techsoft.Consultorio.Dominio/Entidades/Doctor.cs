using Dawn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.Consultorio.Dominio.Entidades
{
    public class Doctor: Persona 
    {
        public string Cedula { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Nombre}, {Direccion}, {Cedula}, {Telefono}";
        }
        public Doctor(string nombre, string direccion, string telefono, string cedula) : base(nombre, direccion, telefono)
        {
            Cedula = Guard.Argument(cedula, nameof(cedula)).LengthInRange(4, 20);
            //Usando Guard Antiguo
            //Cedula = cedula.Range(4, 20, nameof(cedula));
        }
    }
}
