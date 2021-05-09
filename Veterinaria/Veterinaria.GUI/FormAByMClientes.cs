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
    public partial class FormAByMClientes : Form
    {
        private Form _menu;
        private SucVeterinaria _sucVeterinaria;
        public FormAByMClientes(Form frmMenu, SucVeterinaria sucVeterinaria)
        {
            _menu = frmMenu;
            _sucVeterinaria = sucVeterinaria;
            InitializeComponent();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            //No uso limpiar y me limpia igual los text box, por qué?
            //Limpiar();
            CargarLista();
        }

        private void CargarLista()
        {
            LimpiarLista();
            lstClientes.DataSource = _sucVeterinaria.Clientes;
        }

        private void LimpiarLista()
        {
            lstClientes.DataSource = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Hide();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarLista();
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            try
            {
                ValidarStrings();
                cliente = new Cliente(txtIdCliente.Text, txtNombre.Text, txtDomicilio.Text, txtTelefono.Text, txtEmail.Text);
                _sucVeterinaria.GuardarCliente(cliente);
                MessageBox.Show($"Cliente agregado:\n {cliente.ToString()}");
                Limpiar();
                CargarLista();
            }
            catch (ClienteExistenteException clienteExistExcep)
            {
                MessageBox.Show(clienteExistExcep.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = null;
            Cliente clienteSeleccionado = (Cliente)lstClientes.SelectedValue;
            try
            {
                ValidarStrings();
                if (clienteSeleccionado.Id != txtIdCliente.Text) { throw new Exception("No puede modificarse el ID"); }
                cliente = new Cliente(txtIdCliente.Text, txtNombre.Text, txtDomicilio.Text, txtTelefono.Text, txtEmail.Text);
                _sucVeterinaria.ModificarCliente(cliente);
                MessageBox.Show($"Cliente modificado:\n {cliente.ToString()}");
                Limpiar();
                CargarLista();
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

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)lstClientes.SelectedValue;
            try
            {
                /*ver botón para confirmar eliminación
                if (ConfirmarEliminacion(clienteSeleccionado) == true)
                {
                }
                */

                _sucVeterinaria.EliminarCliente(clienteSeleccionado);
                MessageBox.Show($"Cliente eliminado");
                Limpiar();
                CargarLista();
            }
            catch (ClienteInexistenteException clienteInexistExcep)
            {
                MessageBox.Show(clienteInexistExcep.Message);
            }
            catch (PacientesIngresadosException pacientesIngresExcep)
            {
                MessageBox.Show(pacientesIngresExcep.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private bool ConfirmarEliminacion(Cliente cliente)
        {
            FormConfirmacion frmConfirmacion = new FormConfirmacion(this, $"¿Eliminar al cliente {cliente.ToString()}?");
            frmConfirmacion.Show();
            this.Hide();
            return frmConfirmacion.Confirmacion;
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Para qué? 
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnAgregar.Enabled = true;
            */
            CargarClienteSeleccionado();
        }

        private void CargarClienteSeleccionado()
        {
            if (lstClientes.DataSource!=null)
            {
                Cliente clienteSeleccionado = (Cliente)lstClientes.SelectedValue;
                txtIdCliente.Text = clienteSeleccionado.Id;
                txtNombre.Text = clienteSeleccionado.Nombre;
                txtDomicilio.Text = clienteSeleccionado.Domicilio;
                txtTelefono.Text = clienteSeleccionado.NumeroTel;
                txtEmail.Text = clienteSeleccionado.Email;
            }
        }

        private void ValidarStrings()
        {
            if (
                txtIdCliente.Text == string.Empty ||
                txtNombre.Text == string.Empty ||
                txtDomicilio.Text == string.Empty ||
                txtTelefono.Text == string.Empty ||
                txtEmail.Text == string.Empty
                )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
        }

        private void Limpiar()
        {
            txtIdCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
