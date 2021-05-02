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
    public partial class FormAltaVisita : Form
    {
        public FormAltaVisita()
        {
            InitializeComponent();
        }

        private void btnAgregarVisita_Click(object sender, EventArgs e)
        {
            Visita visita = null;
            try
            {
                Validar();
                visita = new Visita(txtFecha.Text, txtMotivoConsulta.Text, txtDiagnostico.Text, txtPrescripciones.Text, txtObservaciones.Text, txtProfesional.Text);
                Limpiar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Validar()
        {
            if(
               txtFecha.Text == string.Empty || 
               txtMotivoConsulta.Text == string.Empty || 
               txtDiagnostico.Text == string.Empty || 
               txtPrescripciones.Text == string.Empty || 
               txtObservaciones.Text == string.Empty || 
               txtProfesional.Text == string.Empty 
               )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
        }

        private void Limpiar()
        {
            txtFecha.Text = string.Empty;
            txtMotivoConsulta.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtPrescripciones.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            txtProfesional.Text = string.Empty;
        }

    }
}
