using System;
using System.Collections.Generic;
using System.Text;

namespace Techsoft.Consultorio.Dominio.Entidades
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Contraseña { get; set; }
        public User(string login, string contraseña)
        {
            Login = login;
            Contraseña = contraseña;
        }
    }
}
