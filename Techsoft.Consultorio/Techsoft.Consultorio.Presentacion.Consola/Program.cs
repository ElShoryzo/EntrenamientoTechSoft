// See https://aka.ms/new-console-template for more information
using Techsoft.Consultorio.Aplicacion.Servicios;
using Techsoft.Consultorio.Dominio.Entidades;

Console.WriteLine("Hello, World!");
//var service = new DoctoresService();
var doctor = new Doctor(
    "",
    "",
    "",
    ""
);
try
{
    //service.Guardar(doctor);
}catch(Exception ex)
{
    Console.WriteLine($"Error {ex}.");
}

Console.WriteLine($"Doctor {doctor} guardado");