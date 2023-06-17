using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Dominio.Contratos
{
    public interface IConsultasRepository
    {
        Task<List<Consulta>> GetCustomerAllDates(string clienteId);
        Task<List<Consulta>> GetCustomerDates(string clienteId, DateTime fecha);
        Task<List<Consulta>> GetDoctorDates(string doctorId, DateTime fecha);
    }
}
