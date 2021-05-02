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
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            try
            {
                Validar();
                cliente = new Cliente (txtIdCliente.Text, txtNombreCliente.Text, txtDomicilioCliente.Text,txtTelCliente.Text,txtEmailCliente.Text);
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
    }
}
