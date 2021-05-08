using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnAByM_Click(object sender, EventArgs e)
        {
            FormAByM frmAByM = new FormAByM(this, sucursal1);
            frmAByM.Show();
            this.Hide();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {

            MessageBox.Show(sucursal1.ListarClientes());
        }

        private void btnAltaPaciente_Click(object sender, EventArgs e)
        {
            FormAltaPaciente frmAltaPaciente = new FormAltaPaciente(this, sucursal1);
            frmAltaPaciente.Show();
            this.Hide();
        }

        private void btnBajaPaciente_Click(object sender, EventArgs e)
        {
            FormBajaPaciente frmBajaPaciente = new FormBajaPaciente(this, sucursal1);
            frmBajaPaciente.Show();
            this.Hide();
        }

    }
}
