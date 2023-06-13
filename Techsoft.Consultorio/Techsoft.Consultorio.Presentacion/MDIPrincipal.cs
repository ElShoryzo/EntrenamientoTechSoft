using Techsoft.Consultorio.Infraestructura.Fabricas;
using static Techsoft.Consultorio.Infraestructura.Fabricas.GlobalConfig;

namespace Techsoft.Consultorio.Presentacion
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
            GlobalConfig.SetRepositoryOption(RepositoryOption.TextFile);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            var frmPacientes = new frmPacientes();
            frmPacientes.ShowDialog();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            var frmDoctores = new frmDoctores();
            frmDoctores.ShowDialog();
        }
    }
}