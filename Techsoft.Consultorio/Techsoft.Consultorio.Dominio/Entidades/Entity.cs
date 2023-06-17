using System;
using System.Collections.Generic;
using System.Text;

namespace Techsoft.Consultorio.Dominio.Entidades
{
    public abstract class Entity
    {
        public string Id { get; private set; }
        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
