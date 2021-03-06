using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using Veterinaria.Libreria.Entidades;
using Veterinaria.Libreria.Exceptions;

namespace Veterinaria.GUI
{
    public partial class FormAByMPacientes : Form
    {
        private SucVeterinaria _sucVeterinaria;
        private Cliente _clienteSeleccionado;

        public FormAByMPacientes(Form form, SucVeterinaria sucVeterinaria, Cliente cliente)
        {
            this.Owner = form;
            _sucVeterinaria = sucVeterinaria;
            _clienteSeleccionado = cliente;
            InitializeComponent();
        }
        private void FormAltaPaciente_Load(object sender, EventArgs e)
        {
            lbIdCliente.Text = $"Cliente: {_clienteSeleccionado.Nombre}";
            CargarLista();
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarPacienteSeleccionado();
        }

        private void CambiarPacienteSeleccionado()
        {
            if (lstPacientes.DataSource != null)
            {
                Paciente pacienteSeleccionado = (Paciente)lstPacientes.SelectedValue;
                txtIdPaciente.Text = pacienteSeleccionado.IdPaciente;
                txtNombre.Text = pacienteSeleccionado.Nombre;
                txtFechaNacim.Text = pacienteSeleccionado.FechaNacimiento;
                txtPeso.Text = pacienteSeleccionado.Peso.ToString();
            }
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = null;
                ValidarStrings();
                double peso = Validaciones.Validaciones.ValidarDouble(txtPeso.Text);
                paciente = new Paciente(txtIdPaciente.Text, txtNombre.Text, txtFechaNacim.Text, peso);
                _clienteSeleccionado.GuardarPaciente(paciente);
                MessageBox.Show($"Paciente agregado:\n {paciente.ToString()}");
                Limpiar();
                CargarLista();

            }
            catch (ClienteInexistenteException clienteInexistExcep)
            {
                MessageBox.Show(clienteInexistExcep.Message);
            }
            catch (PacienteExistenteException pacienteExistExcep)
            {
                MessageBox.Show(pacienteExistExcep.Message);
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = null;
                Paciente pacienteSeleccionado = (Paciente)lstPacientes.SelectedValue;
                if (pacienteSeleccionado == null) { throw new Exception("Debe seleccionar un paciente"); }
                if (pacienteSeleccionado.IdPaciente != txtIdPaciente.Text) { throw new Exception("No puede modificarse el ID"); }

                ValidarStrings();
                double peso = Validaciones.Validaciones.ValidarDouble(txtPeso.Text);

                paciente = new Paciente(txtIdPaciente.Text, txtNombre.Text, txtFechaNacim.Text, peso);
                _clienteSeleccionado.ModificarPaciente(paciente, pacienteSeleccionado);
                MessageBox.Show($"Paciente modificado:\n {paciente.ToString()}");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente pacienteSeleccionado = (Paciente)lstPacientes.SelectedValue;
                if (pacienteSeleccionado == null) { throw new Exception("Debe seleccionar un paciente"); }
                /*ver botón para confirmar eliminación
                if (ConfirmarEliminacion(clienteSeleccionado) == true)
                {
                }
                */

                _clienteSeleccionado.EliminarPaciente(pacienteSeleccionado);
                MessageBox.Show($"Paciente eliminado");
                Limpiar();
                CargarLista();
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

        private void ValidarStrings()
        {
            if(
                txtIdPaciente.Text==string.Empty || 
                txtNombre.Text == string.Empty || 
                txtFechaNacim.Text == string.Empty
                )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
        }
        private void Limpiar()
        {
            txtIdPaciente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtFechaNacim.Text = string.Empty;
            txtPeso.Text = string.Empty;
        }

        private void CargarLista()
        {
            LimpiarLista();
            lstPacientes.DataSource = _clienteSeleccionado.Mascotas;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void LimpiarLista()
        {
            lstPacientes.DataSource = null;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
