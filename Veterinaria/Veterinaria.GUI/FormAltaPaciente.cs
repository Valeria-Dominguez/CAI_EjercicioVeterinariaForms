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

namespace Veterinaria.GUI
{
    public partial class FormAltaPaciente : Form
    {
        public FormAltaPaciente()
        {
            InitializeComponent();
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = null;
            try
            {
                Validar();
                double peso = Validaciones.Validaciones.ValidarDouble(txtPesoPaciente.Text);
                paciente = new Paciente(txtIdPaciente.Text, txtNombrePaciente.Text, txtFechaNacimPaciente.Text, peso);
                Limpiar();

            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }
        
        private void Validar()
        {
            if(
                txtIdPaciente.Text==string.Empty || 
                txtNombrePaciente.Text == string.Empty || 
                txtFechaNacimPaciente.Text == string.Empty
                )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
        }
        private void Limpiar()
        {
            txtIdPaciente.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;
            txtFechaNacimPaciente.Text = string.Empty;
            txtPesoPaciente.Text = string.Empty;
        }


    }
}
