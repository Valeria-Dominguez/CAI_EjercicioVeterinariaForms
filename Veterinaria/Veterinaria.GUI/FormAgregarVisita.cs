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
            _pacienteVisita = null;
            lblNombrePaciente.Text = "Nombre paciente";
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIdPaciente.Text==string.Empty){throw new Exception("Ningún campo puede estar vacío");}
                _pacienteVisita = _sucVeterinaria.BuscarPaciente(txtIdPaciente.Text);
                if (_pacienteVisita != null) { lblNombrePaciente.Text = _pacienteVisita.Nombre; }
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
                
                if (_pacienteVisita == null) { throw new Exception("Debe seleccionar un paciente"); }

                else
                {
                    _pacienteVisita.GuardarVisita(visita);
                }
                MessageBox.Show($"Visita agregada en el paciente {_pacienteVisita.Nombre}");
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
            txtIdPaciente.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtMotivo.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtPrescripciones.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            txtProfesional.Text = string.Empty;
        }

        private void ValidarStrings()
        {
            if
              (
               txtIdPaciente.Text==string.Empty ||
               txtFecha.Text==string.Empty || 
               txtMotivo.Text==string.Empty || 
               txtDiagnostico.Text==string.Empty || 
               txtPrescripciones.Text==string.Empty || 
               txtObservaciones.Text==string.Empty ||
               txtProfesional.Text==string.Empty
               )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
        }

    }
}
