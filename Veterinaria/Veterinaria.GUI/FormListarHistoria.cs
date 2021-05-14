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
using Veterinaria.Libreria.Exceptions;

namespace Veterinaria.GUI
{
    public partial class FormListarHistoria : Form
    {
        private SucVeterinaria _sucursalVeterinaria;

        public FormListarHistoria(Form form, SucVeterinaria sucVeterinaria)
        {
            this.Owner = form;
            _sucursalVeterinaria = sucVeterinaria;
            InitializeComponent();
        }

        private void PedirPaciente_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPaciente.Text == string.Empty) { throw new Exception("El campo no puede estar vacío"); }
                MessageBox.Show(_sucursalVeterinaria.ListarHistoria(txtIdPaciente.Text));
                Limpiar();
                this.Owner.Show();
                this.Close();
            }
            catch (PacienteInexistenteException pacienteInexistExcep)
            {
                MessageBox.Show(pacienteInexistExcep.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Limpiar()
        {
            txtIdPaciente.Text = string.Empty;
        }
    }
}
