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
    public partial class FormAgregarVisita : Form
    {
        private SucVeterinaria _sucVeterinaria;
        private Paciente _pacienteVisita;
        public FormAgregarVisita(Form form, SucVeterinaria sucVeterinaria)
        {
            _sucVeterinaria = sucVeterinaria;
            _pacienteVisita = null;
            this.Owner = form;
            InitializeComponent();
        }

        private void AgregarVisita_Load(object sender, EventArgs e)
        {
            FormPedirPaciente frmPedirPaciente = new FormPedirPaciente(this, _sucVeterinaria);
            this.Hide();
            frmPedirPaciente.Show();
            _pacienteVisita = frmPedirPaciente.PacienteEncontrado;
            if(_pacienteVisita!=null)
            {
                lblNombrePaciente.Text = _pacienteVisita.Nombre;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarStrings();
                Visita visita = new Visita(txtFecha.Text, txtMotivo.Text, txtDiagnostico.Text, txtPrescripciones.Text, txtObservaciones.Text, txtProfesional.Text);
                _sucVeterinaria.GuardarVisita(_pacienteVisita.IdPaciente, visita);
                MessageBox.Show($"Visita agregada");
                Limpiar();

            }
            catch (PacienteInexistenteException pacienteInexsistExcep)
            {
                MessageBox.Show(pacienteInexsistExcep.Message);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtFecha.Text = string.Empty;
            txtMotivo.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtPrescripciones.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtProfesional.Text = string.Empty;
        }

        private void ValidarStrings()
        {
            if
              (
               txtFecha.Text==string.Empty || 
               txtMotivo.Text==string.Empty || 
               txtDiagnostico.Text==string.Empty || 
               txtPrescripciones.Text==string.Empty || 
               txtFecha.Text==string.Empty || 
               txtProfesional.Text==string.Empty
               )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
        }
    }
}
