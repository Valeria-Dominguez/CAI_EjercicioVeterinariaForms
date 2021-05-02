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
    public partial class FormAltaProfesional : Form
    {
        public FormAltaProfesional()
        {
            InitializeComponent();
        }

        private void btnAgregarProfesional_Click(object sender, EventArgs e)
        {
            Profesional profesional = null;
            try
            {
                Validar();
                profesional = new Profesional(txtIdProf.Text, txtNombreProf.Text, txtDomicilioProf.Text, txtTelefonoProf.Text, txtEmailProf.Text);
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
               txtIdProf.Text==string.Empty || 
               txtNombreProf.Text==string.Empty || 
               txtDomicilioProf.Text==string.Empty || 
               txtTelefonoProf.Text==string.Empty ||
               txtEmailProf.Text==string.Empty 
               )
            {
                throw new Exception("Ningún campo puede estar vacío");
            }
        }
        private void Limpiar()
        {
            txtIdProf.Text = string.Empty;
            txtNombreProf.Text = string.Empty;
            txtDomicilioProf.Text = string.Empty;
            txtTelefonoProf.Text = string.Empty;
            txtEmailProf.Text = string.Empty;
        }
    }
}
