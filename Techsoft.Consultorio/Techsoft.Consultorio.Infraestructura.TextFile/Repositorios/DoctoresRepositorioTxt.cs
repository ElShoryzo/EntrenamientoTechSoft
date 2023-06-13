using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Infraestructura.Repositorios
{
    public class DoctoresRepositorioTxt: IDoctoresRepository
    {
        public Doctor? ConsultarCedula(string cedula)
        {
            
            using (var reader = new StreamReader(@"D:\Entrenamiento TechSoft\Techsoft.Consultorio\Datos\datos.txt", true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string buscarCedula = parts[3].Trim();
                    if (buscarCedula == cedula)
                    {
                        return RegistroTxtADoctor(parts);
                    }
                }
                reader.Close();
            }
            return null;
        }

        public Doctor RegistroTxtADoctor(string[] parts)
        {
            Doctor doctor = new()
            {
                Nombre = parts[1].Trim(),
                Direccion = parts[2].Trim(),
                Cedula = parts[3].Trim(),
                Telefono = parts[4].Trim(),
            };
            return doctor;
        }

        public void Guardar(Doctor doctor)
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
                writer.WriteLine(doctor);
                writer.Close();
            }
        }
    }
}
