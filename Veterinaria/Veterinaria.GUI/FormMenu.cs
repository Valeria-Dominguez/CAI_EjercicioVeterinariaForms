using System;
using System.Windows.Forms;
using Veterinaria.Libreria.Entidades;

namespace Veterinaria.GUI
{
    public partial class FormMenu : Form
    {
        SucVeterinaria sucursal1;
        public FormMenu()
        {
            sucursal1 = new SucVeterinaria("Sucursal 1", "Calle 1 1234", "Telefono Sucursal1", "Encargado Sucursal1");
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.lblSucVet.Text = $"{sucursal1.Nombre} - {sucursal1.Domicilio}";
        }

        private void btnAByMClientes_Click(object sender, EventArgs e)
        {
            FormAByMClientes frmAByMClientes = new FormAByMClientes(this, sucursal1);
            frmAByMClientes.Show();
            this.Hide();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sucursal1.ListarClientes());
        }

        private void btnAByMPacientes_Click(object sender, EventArgs e)
        {
            FormPedirCliente frmPedirCliente = new FormPedirCliente(this, sucursal1);
            frmPedirCliente.Show();
            this.Hide();
        }

        private void btnListarHistoria_Click(object sender, EventArgs e)
        {
            FormPedirPaciente frmPedirPaciente = new FormPedirPaciente(this, sucursal1);
            frmPedirPaciente.Show();
            this.Hide();

            //Por qué no funciona?
            if (frmPedirPaciente.PacienteEncontrado != null)
            {
                MessageBox.Show(frmPedirPaciente.PacienteEncontrado.ListarHistoria());
            }
        }

        private void btnAgregarVisita_Click(object sender, EventArgs e)
        {
            FormAgregarVisita frmAgregarVisita = new FormAgregarVisita(this, sucursal1);
            frmAgregarVisita.Show();
            this.Hide();
        }
    }
}
