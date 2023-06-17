using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Techsoft.Consultorio.Aplicacion.Servicios;
using Techsoft.Consultorio.Dominio.Entidades;
namespace Techsoft.Consultorio.Presentacion
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
            pacientes = new List<Paciente>();
        }
        internal List<Paciente> pacientes;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // var service = new PacientesService();
            Paciente paciente = new(
                txtNombre.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                int.Parse(txtEdad.Text)
            );

            try
            {
                //service.Guardar(paciente);
                MessageBox.Show($"Doctor {paciente} guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}.");
            }

            // var fabrica = new PacientesFabrik();

            // Tenemos que cambiar PacientesFabrik.CrearPacientesRepository() a un metodo estatico debido a que nunca recibe nada ni cambia de estado, siempre hace lo mismo
            // Es decir, si no se va a modificar la clase se hace estatico
            // IPacientesRepository repo = PacientesFabrik.CrearRepository();
            // repo.Guardar(paciente);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
