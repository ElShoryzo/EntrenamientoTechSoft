using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Infraestructura.Repositorios
{
    public class PacientesRepositorioTxt: IPacientesRepository
    {
        public Paciente? ConsultarPaciente(Paciente paciente)
        {
            using (var reader = new StreamReader(@"D:\Entrenamiento TechSoft\Techsoft.Consultorio\Datos\datos.txt", true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(line == paciente.ToString())
                    {
                        return paciente;
                    }
                }
                reader.Close();
            }
            return null;
        }

        public void Guardar(Paciente paciente)
        {
            // var writer = new StreamWriter(@"D:\Entrenamiento TechSoft\Techsoft.Consultorio\Datos\datos.txt", true);
            // var linea = paciente.Nombre + ", " + paciente.Direccion + ", " + paciente.Edad + ", " + paciente.Telefono;

            // var linea = $"{paciente.Nombre}, {paciente.Direccion}, {paciente.Edad}, {paciente.Telefono}";

            // writer.WriteLine(paciente);
            // writer.Close();
            // writer.Dispose();

            // using crea y destruye donde mimso el objeto
            using (var writer = new StreamWriter(@"D:\Entrenamiento TechSoft\Techsoft.Consultorio\Datos\datos.txt", true))
            {
                writer.WriteLine(paciente);
                writer.Close();
            }
        }
    }
}
