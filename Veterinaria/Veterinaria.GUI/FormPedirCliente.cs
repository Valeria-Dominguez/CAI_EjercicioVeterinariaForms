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
    public partial class FormPedirCliente : Form
    {
        private Form _menu;
        private SucVeterinaria _sucVeterinaria;
        public FormPedirCliente(Form form, SucVeterinaria sucVeterinaria)
        {
            _menu = form;
            _sucVeterinaria = sucVeterinaria;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCliente.Text == string.Empty) { throw new Exception("El campo no puede estar vacío"); }
                Cliente cliente =_sucVeterinaria.BuscarCliente(txtIdCliente.Text);
                FormAByMPacientes frmAByMPacientes = new FormAByMPacientes(this,_sucVeterinaria, cliente);
                frmAByMPacientes.Show();
                this.Hide();
                Limpiar();
            }
            catch (ClienteInexistenteException clienteInexistExcep)
            {
                MessageBox.Show(clienteInexistExcep.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Limpiar()
        {
            txtIdCliente.Text = string.Empty;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }

        private void FormBajaPaciente_Load(object sender, EventArgs e)
        {
            //No uso limpiar y me limpia igual los text box, por qué?
            //Limpiar();
        }
    }
}
