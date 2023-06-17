using Dawn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.Consultorio.Dominio.Entidades
{
    public class Paciente: Persona
    {
        public int Edad { get; private set; }
        public override string ToString()
        {
            return $"{Id}, {Nombre}, {Direccion}, {Edad}, {Telefono}";
        }
        public Paciente(string nombre, string direccion, string telefono, int edad) : base (nombre, direccion, telefono)
        {
            Edad = Guard.Argument(edad, nameof(edad)).InRange(10, 120);
            // Usando Guard antiguo
            //Edad = edad.Range(10, 120, nameof(edad));
        }
    }
}
