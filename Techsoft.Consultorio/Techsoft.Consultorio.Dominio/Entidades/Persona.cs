using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dawn;

namespace Techsoft.Consultorio.Dominio.Entidades
{
    public abstract class Persona : Entity
    {
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        public string Telefono { get; private set; }
        public Persona(string nombre, string direccion, string telefono)
        {
            Nombre = Guard.Argument(nombre, nameof(nombre)).LengthInRange(4, 30);
            Direccion = Guard.Argument(direccion, nameof(direccion)).LengthInRange(10, 50);
            Telefono = Guard.Argument(telefono, nameof(telefono)).Length(10);   
            // Usando Guard antiguo
            //Nombre = nombre.Range(4, 30, nameof(nombre));
            //Direccion = direccion.Range(10, 50, nameof(direccion)); 
            //Telefono = telefono.Range(10, 10, nameof(telefono));
        }
    }
}
