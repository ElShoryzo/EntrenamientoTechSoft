using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techsoft.Consultorio.Dominio.Contratos;
using Techsoft.Consultorio.Dominio.Entidades;
using Techsoft.Consultorio.Infraestructura.Fabricas;
using Techsoft.Consultorio.Infraestructura.Repositorios;

namespace Techsoft.Consultorio.Aplicacion.Servicios
{
    public class DoctoresService
    {
        private readonly IDoctoresRepository _doctoresRepo;
        public DoctoresService()
        {
            // DbContextOptionsBuilder options = new DbContextOptionsBuilder();
            // options.UseSqlServer("server=.;Initial Catalog=BDEntrenamiento; Trusted_Connection=true; Encrypt=false");
            // IDoctoresRepository repo = new DoctoresRepositorio(options.Options);
            _doctoresRepo = DoctoresFabrik.CrearRepository();
        }

        public void Guardar(Doctor doctor)
        {
            UsuarioDuplicado(doctor);
            _doctoresRepo.Guardar(doctor);
        }

        private void UsuarioDuplicado(Doctor doctor)
        {
            var result = _doctoresRepo.ConsultarCedula(doctor.Cedula);

            if (result is not null)
            {
                throw new InvalidOperationException("El doctor ya existe");
            }

        }
    }
}
