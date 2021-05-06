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
    public partial class FormAltaCliente : Form
    {
        private Form _menu;
        private SucVeterinaria _sucVeterinaria;

        public FormAltaCliente(Form form, SucVeterinaria sucVeterinaria)
        {
            _menu = form;            
            _sucVeterinaria = sucVeterinaria;
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            try
            {
                Validar();
                cliente = new Cliente (txtIdCliente.Text, txtNombreCliente.Text, txtDomicilioCliente.Text,txtTelCliente.Text,txtEmailCliente.Text);
                _sucVeterinaria.GuardarCliente(cliente);
                MessageBox.Show($"Cliente agregado:\n {cliente.ListarPersona()}");
                Limpiar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Validar()
        {
            if (
                txtIdCliente.Text == string.Empty || 
                txtNombreCliente.Text == string.Empty || 
                txtDomicilioCliente.Text == string.Empty || 
                txtTelCliente.Text == string.Empty || 
                txtEmailCliente.Text == string.Empty
                )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
        }

        private void Limpiar()
        {
            txtIdCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtDomicilioCliente.Text = string.Empty;
            txtTelCliente.Text = string.Empty;
            txtEmailCliente.Text = string.Empty;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Hide();
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            //No uso limpiar y me limpia igual los text box, por qué?
            //Limpiar();
        }
    }
}
