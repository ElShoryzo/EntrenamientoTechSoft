using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Dominio.Contratos
{
    public interface IDoctoresRepository
    {
        void Guardar(Doctor doctor);
        Doctor ConsultarCedula(string cedula);
        Doctor ConsultarDoctorPorId(string doctorId);
        Consulta ConsultarDisponibilidadDoctor(Doctor doctor, DateTime horario);
        Task<Doctor> GetById(string id);
    }
}
