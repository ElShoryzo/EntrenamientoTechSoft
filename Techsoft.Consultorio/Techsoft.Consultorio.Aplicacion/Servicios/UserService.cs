using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Aplicacion.Servicios
{
    public class UserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task Almacenar(User user)
        {
            // _repo.Save(user);
            // await _repo.AcceptChanges();
        }

        /*
        public async Task<List<User>> ConsultarTodos()
        {
            /return await _repo.GetAll();
        }*/

        public async Task<User> ConsultarUser(string login)
        {
            return await _repo.GetClientesByLogin(login);
        }
    }
}
