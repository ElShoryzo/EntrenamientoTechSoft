using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Techsoft.Consultorio.Aplicacion.Servicios;
using Techsoft.Consultorio.Dominio.Entidades;

namespace Techsoft.Consultorio.Presentacion
{
    public partial class frmDoctores : Form
    {
        public frmDoctores()
        {
            InitializeComponent();
            doctores = new List<Doctor>();
        }
        internal List<Doctor> doctores;
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // var service = new DoctoresService();
            Doctor doctor = new(
                txtNombre.Text,
                txtDireccion.Text,
                txtCedula.Text,
                txtTelefono.Text
            );
            try
            {
                // service.Guardar(doctor);
                MessageBox.Show($"Doctor {doctor} guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}.");
            }
            
        }
    }
}
