using System;
using System.Collections.Generic;
using System.Text;
using Techsoft.Consultorio.Dominio.GuardAntiguo;

namespace Techsoft.Consultorio.Dominio.Entidades
{
    public class Consulta : Entity
    {
        private DateTime _fechaConsulta;

        public DateTime FechaConsulta
        {
            get
            {
                return _fechaConsulta;
            }
            set
            {
                _fechaConsulta = value.LaterThatHour(1, "Fecha Consulta");
            }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value.Range(0, 30, nameof(_direccion)); }
        }

        public string DoctorId { get; private set; }
        //public Doctor Doctor { get; private set; }

        public string PacienteId { get; private set; }
        //public Paciente Paciente { get; private set; }

        private Consulta()
        {

        }
        public Consulta(Paciente paciente, Doctor doctor, DateTime fechaconsulta, string direccion)
        {
            FechaConsulta = fechaconsulta.LaterThatHour(1, "Fecha Consulta");
            Direccion = direccion.Range(0, 30, nameof(direccion));
            DoctorId = doctor.Id;
            PacienteId = paciente.Id;
            //Paciente = paciente;
            //Doctor = doctor;
        }
    }
}
