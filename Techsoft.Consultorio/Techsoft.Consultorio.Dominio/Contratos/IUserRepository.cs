using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Dominio.Contratos
{
    public interface IUserRepository 
    {
        Task<User> GetClientesByLogin(string login);
    }
}
